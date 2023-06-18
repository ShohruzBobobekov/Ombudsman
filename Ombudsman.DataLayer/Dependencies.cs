using Microsoft.EntityFrameworkCore;
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
        AddDataBase(services, configuration);

        return services;
    }

    private static void AddDataBase(
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
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IDocumentRealizationRepository, DocumentRealizationRepository>();
        services.AddScoped<IOrganizationRepository, OrganizationRepository>();
        services.AddScoped<ISectorRepository, SectorRepository>();
        services.AddScoped<IStateProgramRepository, StateProgramRepository>();
    }
}