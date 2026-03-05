using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Medolai.Database
{
    public static class MyDbContextService
    {
        public static void AddMyDatabaseService(this IServiceCollection services, IConfiguration conf)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var connStr = conf.GetConnectionString("DbConnectionString");
            services.AddDbContextPool<MyDbContext>((serviceProvider, o) =>
            {
                o.UseNpgsql(connStr, builder =>
                {
                    builder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                    builder.CommandTimeout(60);
                })
                 .UseSnakeCaseNamingConvention()
                 .EnableDetailedErrors()
                 .EnableSensitiveDataLogging();
            }, 300);
        }

        public static void UseDatabaseMigrate(this IHost app)
        {
            using (var serviceScope = app.Services.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<MyDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
