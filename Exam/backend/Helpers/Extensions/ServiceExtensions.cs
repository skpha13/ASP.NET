using backend.Helpers.Seeders;
using backend.Repositories.TestRepository;
using backend.Services.TestService;

namespace backend.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUtilizatorRepository, UtilizatorRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IUtilizatorService, UtilizatorService>();
        
        return services;
    }

    public static IServiceCollection AddSeeders(this IServiceCollection services)
    {
        services.AddTransient<UtilizatorSeeder>();
        services.AddTransient<ComandaSeeder>();
        services.AddTransient<ProdusSeeder>();
        services.AddTransient<RelatieSeeder>();
    
        return services;
    }
}