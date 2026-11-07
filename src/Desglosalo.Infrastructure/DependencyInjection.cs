using Desglosalo.Application.Breakdowns;
using Desglosalo.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Desglosalo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Persistence (EF Core / SQL Server) and other adapters get registered here.
        services.AddScoped<IBreakdownRepository, BreakdownRepository>();
        return services;
    }
}

