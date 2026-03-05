using Medolai.Database;
using Medolai.Repository.Utils;
using Medolai.Shared;
using Medolai.Shared.Models;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Medolai.Repository.Services
{
    public interface IGdtService
    {
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
    }
}

