using FMA.DAL;
using FMA.Domain.Abstractions;
using FMA.Service;

namespace FMA.API.Extensions;

public static class ServiceExtensions
{
    public static void AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
    }
}