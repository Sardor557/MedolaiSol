using EFCoreSecondLevelCacheInterceptor;
using Medolai.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Medolai.Database
{
    public static class MyEFSecondLevelCache
    {
        public static void AddMyEFSecondLevelCache(this IServiceCollection services, IConfiguration conf)
        {
            int cacheTimeOut = 5;
            if (!string.IsNullOrWhiteSpace(conf["Vars:CacheTimeOut"]))
                cacheTimeOut = conf["Vars:CacheTimeOut"].ToInt();

            services.AddEFSecondLevelCache(o =>
                        o.DisableLogging(false)
                         .UseMemoryCacheProvider(CacheExpirationMode.Absolute, TimeSpan.FromMinutes(cacheTimeOut))
                         .UseCacheKeyPrefix("EF_")
                         .SkipCachingResults(r => r.Value == null || r.Value is EFTableRows rows && rows.RowsCount == 0)
                    );
        }
    }
}
