using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.BizLogicLayer.Manual.Concrete;
using Ombudsman.BizLogicLayer.Users;

namespace Ombudsman.BizLogicLayer;

public static class Dependencies
{
    public static IServiceCollection AddBizLogicLayer(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddSingleton<IPasswordHasher, PasswordHasher>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ISectorService, SectorService>();
        services.AddScoped<IManualService, ManualService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IOrganizationService, OrganizationService>();
        services.AddScoped<IStateProgramService, StateProgramService>();
        services.AddScoped<IDocumentRealizationService, DocumentRealizationService>();

        services.AddHttpContextAccessor();

        return services;
    }
}
