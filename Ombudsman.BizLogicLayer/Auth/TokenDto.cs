namespace Ombudsman.BizLogicLayer.Auth;
public record TokenDto(
    string accessToken,
    string? refreshToken,
    DateTime expireDate);