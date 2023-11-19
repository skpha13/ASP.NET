using Lab4_23.Helpers.Seeders;
using Lab4_23.Repositories.PostRepository;
using Lab4_23.Services.PostService;

namespace Lab4_23.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IPostRepository, PostRepository>();
        
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IPostService, PostService>();

        return services;
    }

    public static IServiceCollection AddSeeders(this IServiceCollection services)
    {
        services.AddTransient<PostsSeeder>();

        return services;
    }
}