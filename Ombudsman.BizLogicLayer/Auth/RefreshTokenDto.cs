namespace Ombudsman.BizLogicLayer.Auth;

public record RefreshTokenDto(
    string accessToken,
    string refreshToken);