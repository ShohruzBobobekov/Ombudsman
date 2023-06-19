using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

using Ombudsman.Core.Configurations;

namespace Ombudsman.Core;

public static class Dependencies
{
    public static IServiceCollection AddCoreLayer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddSingleton<IJwtTokenHandler, JwtTokenHandler>();
        services.AddSingleton<IPasswordHasher, PasswordHasher>();
        return services;
    }
}
