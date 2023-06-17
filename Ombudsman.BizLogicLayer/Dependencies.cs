using AutoMapper;

using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

using Ombudsman.BizLogicLayer.Users;

namespace Ombudsman.BizLogicLayer;

public static class Dependencies
{
    public static IServiceCollection AddBizLogicLayer(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddAutoMapper(typeof(UserDtoConfig));
        services.AddSingleton<IPasswordHasher,PasswordHasher>();

        services.AddScoped<IUserService, UserService>();

        services.AddHttpContextAccessor();

        return services;
    }
}
