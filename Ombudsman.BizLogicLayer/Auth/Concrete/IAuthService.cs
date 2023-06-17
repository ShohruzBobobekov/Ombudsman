using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer.Auth;


public interface IAuthService
{
    public User User { get; set; }
    Task<TokenDto> LoginAsync(AuthenticationDto authenticationDto);
    Task<TokenDto> RefreshTokenAsync(RefreshTokenDto refreshTokenDto);
}
