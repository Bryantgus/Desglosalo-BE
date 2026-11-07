using Desglosalo.Application.Breakdowns;
using Microsoft.Extensions.DependencyInjection;

namespace Desglosalo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBreakdownService, BreakdownService>();
        return services;
    }
}
