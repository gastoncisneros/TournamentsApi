using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Inyects all commands and queries from the assembly.
        services.AddMediatR(mediatRConfiguration =>
        {
            mediatRConfiguration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });
        
        return services;
    }
}