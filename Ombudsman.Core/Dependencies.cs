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

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme=JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer=true,
                ValidateAudience=true,
                ValidateLifetime=true,
                ValidateIssuerSigningKey=true,
                ValidIssuer=configuration["JwtOptions:Issuer"],
                ValidAudience=configuration["JwtOptions:Audience"],
                IssuerSigningKey=new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JwtOptions:SecretKey"])),
                ClockSkew=TimeSpan.Zero
            };
        });

        services.AddAuthorization();

        services.AddSingleton<IJwtTokenHandler, JwtTokenHandler>();
        services.AddSingleton<IPasswordHasher, PasswordHasher>();
        return services;
    }
}
