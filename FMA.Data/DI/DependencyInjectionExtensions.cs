using FMA.Data.Services.Impls;
using FMA.Data.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FMA.Data.DI;
public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddDataAccessComponents(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }

    private static void ConfigDapperMap()
    {

    }
}