using MarvelComicsApi.DbConn;
using MarvelComicsApi.Interfaces;
using MarvelComicsApi.Repositories;
using MarvelComicsApi.Services;
using Microsoft.EntityFrameworkCore;

namespace MarvelComicsApi.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddAdditionalServices(this IServiceCollection serviceCollection)
    {
        
        serviceCollection.AddScoped<IComicRepository,ComicRepository>();
        serviceCollection.AddScoped<IComicService, ComicService>();


        return serviceCollection;
    }
    
    
    public static IServiceCollection AddDatabaseConnection(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(Environment.GetEnvironmentVariable("DefaultConnection")));
        return services;
    }       
}