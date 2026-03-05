using Medolai.Repository.Services;
using Medolai.Shared.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Medolai.Repository
{
    public static class DependencyInjection
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddScoped<IMyHttpContextAccessorExtensions, MyHttpContextAccessorExtensions>();
            services.AddScoped<IGdtService, GdtService>();
        }
    }
}
