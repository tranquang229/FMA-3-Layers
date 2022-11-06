using FMA.Core.Common;
using FMA.Data;
using Microsoft.EntityFrameworkCore;

namespace FMA.API.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add needed instances for database
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        // Configure DbContext with Scoped lifetime   
        services.AddDbContext<DemoContext>(options =>
            {

                services.Configure<AppSettingOptions>(configuration.GetSection(AppSettingOptions.AppSettings));
                var appSettingOptions = new AppSettingOptions();
                configuration.GetSection(AppSettingOptions.AppSettings).Bind(appSettingOptions);

                options.UseSqlServer(appSettingOptions.ConnectionStrings,
                    sqlOptions => sqlOptions.CommandTimeout(120));
                options.UseLazyLoadingProxies();
            }
        );

        //services.AddScoped<Func<DemoContext>>((provider) => () => provider.GetService<DemoContext>());
        //services.AddScoped<DbFactory>();
        //services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }

}
