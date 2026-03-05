using Medolai.Database;
using Medolai.Repository;
using Medolai.Services;
using Medolai.Shared;
using Medolai.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Serilog;
using Serilog.AspNetCore;
using Serilog.Exceptions;
using Serilog.Settings.Configuration;
using System;

namespace Medolai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddEnvironmentVariables();

            var configurationAssemblies = new[]
            {
                typeof(ConsoleLoggerConfigurationExtensions).Assembly,
                typeof(FileLoggerConfigurationExtensions).Assembly,
                typeof(LoggerConfigurationTelegramExtensions).Assembly
            };

            var options = new ConfigurationReaderOptions(configurationAssemblies);

            Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .Enrich.WithMachineName()
                    .Enrich.WithExceptionDetails()
                    .Enrich.WithProperty("Environment", builder.Environment)
                    .ReadFrom.Configuration(builder.Configuration, options)
                    .CreateLogger();

            builder.Services.AddControllers(o => { o.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true; })
                            .AddNewtonsoftJson(o => { o.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver(); });                            

            builder.Services.ApiMyVersion();
            builder.Services.AddMySwagger();
            builder.Services.AddSerilog();
            builder.Services.AddMyResponseCompression();
            builder.Services.Configure<Vars>(builder.Configuration.GetSection("Vars"));
            builder.Services.Configure<JwtVars>(builder.Configuration.GetSection("JWT"));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });
            builder.Services.Configure<RequestLoggingOptions>(o =>
            {
                o.EnrichDiagnosticContext = (d, h) =>
                {
                    d.Set("RemoteIpAddress", h.Connection.RemoteIpAddress.MapToIPv4());
                };
            });

            //builder.Services.AddMyAuthentication(builder.Configuration);
            builder.Services.AddMemoryCache();
            builder.Services.AddHttpContextAccessor();            
            builder.Services.AddMyDatabaseService(builder.Configuration);
                        
            builder.Services.AddMyServices();

            builder.Services.AddScoped<ICRestClient, CRestClient>(); 

            var app = builder.Build();
            app.UseMySwagger();
            app.UseMyStaticFiles();

            app.UseRouting();
            app.UseCors("AllowAllHeaders");
            app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto });
            app.MapControllers();

                        
            app.UseSerilogRequestLogging();
            app.UseResponseCompression();
            app.UpdateMigrateDatabase();

            app.Run();
        }
    }
}
