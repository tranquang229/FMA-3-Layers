using FMA.BL.Services.Impls;
using FMA.BL.Services.Interfaces;
using FMA.Data.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FMA.BL.DI;
public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddBusinessComponents(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessComponents(configuration);
        services.AddScoped<IEmployeeBiz, EmployeeBiz>();

        return services;
    }
}
