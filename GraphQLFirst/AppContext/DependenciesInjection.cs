using GraphQLFirst.Contracts;
using Microsoft.EntityFrameworkCore;

namespace GraphQLFirst.AppContext;

public static class DependenciesBootstrapper
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName));

            options.EnableDetailedErrors();
            options.EnableSensitiveDataLogging();
        });

        services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());

        return services;
    }
}