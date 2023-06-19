using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.Core.Configurations;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer.Repositories;

namespace Ombudsman.Api.Middleware
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;

        public UserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context,
            IAuthService authService,
            IUserRepository repository)
        {
            // Check if the current endpoint has the [Authorize] attribute
            var endpoint = context.GetEndpoint();
            var authorizeAttribute = endpoint?.Metadata.GetMetadata<Microsoft.AspNetCore.Authorization.AuthorizeAttribute>();

            if(authorizeAttribute != null)
            {
                string emailClaim = (context.User.Claims.FirstOrDefault(c => c.Type == CustomClaimNames.Email)).Value;
                var user = await repository.SelectByIdWithDetailsAsync(
                    expression: user => user.Email == emailClaim,
                    includes: new string[] { nameof(User.Role), nameof(User.Organization) });
                authService.User = user;

                // Invoke the UserMiddleware
                await _next.Invoke(context);
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }

}
