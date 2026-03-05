using GtdXmlEf.Models;
using Medolai.Database;
using Medolai.Repository.Utils;
using Medolai.Shared;
using Medolai.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Medolai.Repository.Services
{
    public interface IGdtService
    {
        Task<List<GtdDeclarationGridRow>> GetAllForGridAsync(CancellationToken ct = default);
        Task<AnswerBasic> SaveFileAsync(FileModel file);
    }

    public sealed class GdtService : IGdtService
    {
        private readonly ILogger<GdtService> logger;
        private readonly MyDbContext db;
        private readonly string root = AppDomain.CurrentDomain.BaseDirectory;

        public GdtService(ILogger<GdtService> logger, MyDbContext db)
        {
            this.logger = logger;
            this.db = db;
        }

        public async Task<AnswerBasic> SaveFileAsync(FileModel file)
        {
            await using var tran = await db.Database.BeginTransactionAsync();
            try
            {

                if (file == null || file.File.Length == 0)
                {
                    await tran.RollbackAsync();
                    return new AnswerBasic(0, $"File '{file.File.FileName}' uploaded successfully.");
                }

                string basePath = $"{Path.DirectorySeparatorChar}documents{Path.DirectorySeparatorChar}";
                string fullDir = Path.Combine(root, "documents");

                if (!Directory.Exists(fullDir))
                    Directory.CreateDirectory(fullDir);

                string uniquePath = GetUniqueFilePath(fullDir, file.File.FileName);
                string finalFileName = Path.GetFileName(uniquePath);

                await using (var fs = new FileStream(
                    uniquePath,
                    FileMode.CreateNew,
                    FileAccess.Write,
                    FileShare.None,
                    81920,
                    useAsync: true))
                {
                    await file.File.CopyToAsync(fs);
                }

                var decl = XmlToEfMapper.ParseFile(uniquePath);

                await db.T1Set.AddAsync(decl);
                await db.SaveChangesAsync();
                await tran.CommitAsync();

                return new AnswerBasic(1, $"File '{file.File.FileName}' uploaded successfully.");
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError(ex, "Error saving file");
                return new AnswerBasic(0, "An error occurred while saving the file.");
            }
        }

        private static string GetUniqueFilePath(string directory, string fileName)
        {
            var name = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName);

            var fullPath = Path.Combine(directory, fileName);
            var index = 1;

            while (File.Exists(fullPath))
            {
                var tempFileName = $"{name} ({index}){extension}";
                fullPath = Path.Combine(directory, tempFileName);
                index++;
            }

            return fullPath;
        }

        private async Task<Answer<List<GtdT1>>> GetAllAsync(CancellationToken ct = default)
        {
            try
            {
                var res = await db.T1Set
                    .AsNoTracking()
                    .Include(x => x.T2Rows).ThenInclude(x => x.T4Rows)
                    .Include(x => x.T2Rows).ThenInclude(x => x.T7Rows)
                    .Include(x => x.T2Rows).ThenInclude(x => x.T9Rows)
                    .AsSplitQuery()
                    .ToListAsync(ct);

                return new Answer<List<GtdT1>>(1, "", "", res);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error fetching data");
                return new Answer<List<GtdT1>>(0, "An error occurred while fetching data.", null, new List<GtdT1>());
            }
        }

        public async Task<List<GtdDeclarationGridRow>> GetAllForGridAsync(CancellationToken ct = default)
        {
            var list = await GetAllAsync(ct);
            return list.Data.Select(MapToGridRow).ToList();
        }

        private static GtdDeclarationGridRow MapToGridRow(GtdT1 t1)
        {
            var goods = (t1.T2Rows ?? new List<GtdT2>())
                .OrderBy(x => x.Field3 ?? int.MaxValue)
                .ToList();

            var payments = goods.SelectMany(g => g.T4Rows ?? new List<GtdT4>()).ToList();
            var docs = goods.SelectMany(g => g.T9Rows ?? new List<GtdT9>()).ToList();

            return new GtdDeclarationGridRow
            {
                Id = t1.Id,
                DeclarationType = t1.Field2,
                ImporterName = t1.Field22,
                ImporterAddress = t1.Field23 ?? t1.Field32,
                ImporterPhone = t1.Field12 ?? t1.Field244,
                ImporterEmail = t1.Field14,
                ExporterName = t1.Field39,
                TotalAmount = t1.Field37,

                GoodsCount = goods.Count,

                GoodsSummary = string.Join("; ",
                    goods.Take(3).Select(g => $"{g.Field9} — {g.Field4}".Trim()).Where(s => s != "—")),

                DocumentsSummary = string.Join("; ",
                    docs.Select(d => BuildDoc(d)).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().Take(6)),

                PaymentsSummary = string.Join("; ",
                    payments
                        .GroupBy(p => p.Field3) // P3T4 (вид платежа)
                        .OrderBy(g => g.Key ?? int.MaxValue)
                        .Select(g =>
                        {
                            var cur = g.Select(x => x.Field8).FirstOrDefault(x => !string.IsNullOrWhiteSpace(x)) ?? "";
                            var sum = g.Sum(x => x.Field9 ?? 0m);
                            var code = g.Key?.ToString() ?? "?";
                            return $"{code}: {sum:0.##} {cur}".Trim();
                        })
                        .Take(6)
                ),

                Goods = goods.Select(MapGoods).ToList()
            };
        }

        private static GtdGoodsGridRow MapGoods(GtdT2 g)
        {
            var payments = (g.T4Rows ?? new List<GtdT4>()).ToList();
            var docs = (g.T9Rows ?? new List<GtdT9>()).ToList();

            return new GtdGoodsGridRow
            {
                Id = g.Id,
                ItemNo = g.Field3,
                HsCode = g.Field9,
                Name = g.Field4,
                Quantity = g.Field11,
                WeightOrParam = g.Field18,

                PaymentsSummary = string.Join("; ",
                    payments
                        .GroupBy(p => p.Field3)
                        .OrderBy(x => x.Key ?? int.MaxValue)
                        .Select(gr =>
                        {
                            var cur = gr.Select(x => x.Field8).FirstOrDefault(x => !string.IsNullOrWhiteSpace(x)) ?? "";
                            var sum = gr.Sum(x => x.Field9 ?? 0m);
                            var code = gr.Key?.ToString() ?? "?";
                            return $"{code}: {sum:0.##} {cur}".Trim();
                        })
                        .Take(6)
                ),

                DocumentsSummary = string.Join("; ",
                    docs.Select(d => BuildDoc(d)).Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().Take(6))
            };
        }

        private static string BuildDoc(GtdT9 d)
        {
            // В XML видно, что:
            // - P6T9 похоже на код документа (например ИНВ/УПЛИСТ)
            // - P7T9 номер
            // - P8T9 дата (yyyy-MM-dd)
            // - P12T9 название
            var code = d.Field6;
            var num = d.Field7;
            var date = d.Field8?.ToString("yyyy-MM-dd");
            var name = d.Field12;

            // делаем компактно и читабельно
            var left = string.Join(" ", new[] { code, num }.Where(x => !string.IsNullOrWhiteSpace(x)));
            var right = string.Join(" ", new[] { date, name }.Where(x => !string.IsNullOrWhiteSpace(x)));

            if (left.Length == 0) return right;
            if (right.Length == 0) return left;
            return $"{left} ({right})";
        }
    }
}

