using System.IdentityModel.Tokens.Jwt;

using Ombudsman.Core.Models;

namespace Ombudsman.Core.Configurations;

public interface IJwtTokenHandler
{
    JwtSecurityToken GenerateAccessToken(User user);
    string GenerateRefreshToken();
}