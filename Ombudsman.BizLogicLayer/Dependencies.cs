using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Ombudsman.BizLogicLayer;

public static class Dependencies
{
    public static IServiceCollection AddBizLogicLayer(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        services.AddHttpContextAccessor();

        return services;
    }
}
