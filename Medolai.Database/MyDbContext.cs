using Microsoft.EntityFrameworkCore;
using GtdXmlEf.Models;

namespace Medolai.Database;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<GtdT1> T1Set => Set<GtdT1>();
    public DbSet<GtdT2> T2Set => Set<GtdT2>();
    public DbSet<GtdT4> T4Set => Set<GtdT4>();
    public DbSet<GtdT7> T7Set => Set<GtdT7>();
    public DbSet<GtdT9> T9Set => Set<GtdT9>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<GtdT2>()
            .HasOne(e => e.T1)
            .WithMany(p => p.T2Rows)
            .HasForeignKey(e => e.T1Id)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<GtdT4>()
            .HasOne(e => e.T2)
            .WithMany(p => p.T4Rows)
            .HasForeignKey(e => e.T2Id)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<GtdT7>()
            .HasOne(e => e.T2)
            .WithMany(p => p.T7Rows)
            .HasForeignKey(e => e.T2Id)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<GtdT9>()
            .HasOne(e => e.T2)
            .WithMany(p => p.T9Rows)
            .HasForeignKey(e => e.T2Id)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<GtdT1>()
            .ToTable(t => t.HasComment("Декларация на товары (шапка)"));

        modelBuilder.Entity<GtdT2>()
            .ToTable(t => t.HasComment("Товарные позиции декларации (строки товара)"));

        modelBuilder.Entity<GtdT4>()
            .ToTable(t => t.HasComment("Платежи по товару"));

        modelBuilder.Entity<GtdT7>()
            .ToTable(t => t.HasComment("Описание/характеристики товара (31 графа)"));
        
        modelBuilder.Entity<GtdT9>()
            .ToTable(t => t.HasComment("Документы по товарной позиции (приложенные/подтверждающие документы)"));
    }
}
