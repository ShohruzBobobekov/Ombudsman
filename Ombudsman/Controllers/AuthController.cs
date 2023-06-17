using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer.Auth;

namespace Ombudsman.Controllers;

[Route("api/auth/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService authenticationService;

    public AuthController(
        IAuthService authenticationService)
    {
        this.authenticationService=authenticationService;
    }

    [HttpPost]
    public async ValueTask<ActionResult<TokenDto>> LoginAsync(
        AuthenticationDto authenticationDto)
    {
        var tokenDto = await this.authenticationService
            .LoginAsync(authenticationDto);

        return Ok(tokenDto);
    }

    [HttpPost("refresh-token")]
    public async ValueTask<ActionResult<TokenDto>> RefreshTokenAsync(
        RefreshTokenDto refreshTokenDto)
    {
        var tokenDto = await this.authenticationService
            .RefreshTokenAsync(refreshTokenDto);

        return Ok(tokenDto);
    }
}
