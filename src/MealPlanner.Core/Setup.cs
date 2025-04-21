using Microsoft.Extensions.DependencyInjection;

namespace MealPlanner.Core;
public static class Setup
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}