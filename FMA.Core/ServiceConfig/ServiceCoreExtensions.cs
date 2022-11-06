using FMA.Core.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FMA.Core.ServiceConfig;
public static class ServiceCoreExtensions
{
    public static IServiceCollection AddServiceCoreConfig(this IServiceCollection services, IConfiguration configuration)
    {


        // for google & facebook
        services.Configure<AppSettingOptions>(configuration.GetSection("AppSettings"));


        return services;
    }
}
