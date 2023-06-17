﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Ombudsman.DataLayer.Repositories;

namespace Ombudsman.DataLayer;

public static class Dependencies
{
    public static IServiceCollection AddDataLayer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        AddPersistence(services, configuration);

        return services;
    }

    private static void AddPersistence(
        IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContextPool<AppDbContext>(options =>
        {
            string connectionString = configuration
                .GetConnectionString("DefaultConnectionString");

            options.UseNpgsql(
                connectionString: connectionString,
                options => options.EnableRetryOnFailure())
                    .UseSnakeCaseNamingConvention();
        });



        RegisterRepositories(services);
    }

    private static void RegisterRepositories(
        IServiceCollection services)
    {
         services.AddScoped<IUserRepository, UserRepository>();
    }
}