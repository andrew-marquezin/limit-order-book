using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.Scan(selector => selector
            .FromAssemblies(typeof(DependencyInjection).Assembly)
            .AddClasses(c => c.Where(type => !type.IsAbstract))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }
}
