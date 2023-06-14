namespace Ombudsman.BizLogicLayer.Auth;

public record AuthenticationDto(
    string email, string password);