using backend.Helpers.Seeders;
using backend.Repositories.ComandaProdusRepository;
using backend.Repositories.ComandaRepository;
using backend.Repositories.ProdusRepository;
using backend.Repositories.UtilizatorRepository;
using backend.Services.ComandaProdusService;
using backend.Services.ComandaService;
using backend.Services.ProdusService;
using backend.Services.TestService;

namespace backend.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUtilizatorRepository, UtilizatorRepository>();
        services.AddTransient<IComandaRepository, ComandaRepository>();
        services.AddTransient<IProdusRepository, ProdusRepository>();
        services.AddTransient<IComandaProdusRepository, ComandaProdusRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IUtilizatorService, UtilizatorService>();
        services.AddTransient<IComandaService, ComandaService>();
        services.AddTransient<IProdusService, ProdusService>();
        services.AddTransient<IComandaProdusService, ComandaProdusService>();
        
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