//using System.ComponentModel.DataAnnotations;
//using System.Security.Claims;
//using System.Text;

//namespace Ombudsman.BizLogicLayer.Auth;

//public class AuthenticationService : IAuthenticationService
//{
//    private readonly IUserRepository userRepository;
//    private readonly IJwtTokenHandler jwtTokenHandler;
//    private readonly IPasswordHasher passwordHasher;
//    private readonly JwtOption jwtOptions;

//    public AuthenticationService(
//        IUserRepository userRepository,
//        IJwtTokenHandler jwtTokenHandler,
//        IPasswordHasher passwordHasher,
//        IOptions<JwtOption> options)
//    {
//        this.userRepository=userRepository;
//        this.jwtTokenHandler=jwtTokenHandler;
//        this.passwordHasher=passwordHasher;
//        jwtOptions=options.Value;
//    }

//    public async Task<TokenDto> LoginAsync(
//        AuthenticationDto authenticationDto)
//    {
//        var user = await userRepository
//            .SelectByIdWithDetailsAsync(
//                expression: user => user.Email==authenticationDto.email,
//                includes: Array.Empty<string>());

//        if(user is null)
//        {
//            throw new NotFoundException("User with given credentials not found");
//        }

//        if(!passwordHasher.Verify(
//            hash: user.PasswordHash,
//            password: authenticationDto.password,
//            salt: user.Salt))
//        {
//            throw new ValidationException("Username or password is not valid");
//        }

//        string refreshToken = jwtTokenHandler
//            .GenerateRefreshToken();

//        user.UpdateRefreshToken(refreshToken);

//        var updatedUser = await userRepository
//            .UpdateAsync(user);

//        var accessToken = jwtTokenHandler
//            .GenerateAccessToken(updatedUser);

//        return new TokenDto(
//            accessToken: new JwtSecurityTokenHandler().WriteToken(accessToken),
//            refreshToken: user.RefreshToken,
//            expireDate: accessToken.ValidTo);
//    }

//    public async Task<TokenDto> RefreshTokenAsync(
//        RefreshTokenDto refreshTokenDto)
//    {
//        var claimsPrincipal = GetPrincipalFromExpiredToken(
//            refreshTokenDto.accessToken);

//        var userId = claimsPrincipal.FindFirstValue(CustomClaimNames.Id);

//        var storageUser = await userRepository
//            .SelectByIdAsync(Guid.Parse(userId));

//        if(!storageUser.RefreshToken.Equals(refreshTokenDto.refreshToken))
//        {
//            throw new ValidationException("Refresh token is not valid");
//        }

//        if(storageUser.RefreshTokenExpireDate<=DateTime.UtcNow)
//        {
//            throw new ValidationException("Refresh token has already been expired");
//        }

//        var newAccessToken = jwtTokenHandler
//            .GenerateAccessToken(storageUser);

//        return new TokenDto(
//            accessToken: new JwtSecurityTokenHandler()
//                .WriteToken(newAccessToken),

//            refreshToken: storageUser.RefreshToken,
//            expireDate: newAccessToken.ValidTo);
//    }

//    private ClaimsPrincipal GetPrincipalFromExpiredToken(
//        string accessToken)
//    {
//        var tokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateAudience=true,
//            ValidAudience=jwtOptions.Audience,
//            ValidateIssuer=true,
//            ValidIssuer=jwtOptions.Issuer,
//            ValidateIssuerSigningKey=true,
//            ValidateLifetime=false,

//            IssuerSigningKey=new SymmetricSecurityKey(
//                Encoding.UTF8.GetBytes(jwtOptions.SecretKey))
//        };

//        var tokenHandler = new JwtSecurityTokenHandler();

//        var principal = tokenHandler.ValidateToken(
//            token: accessToken,
//            validationParameters: tokenValidationParameters,
//            validatedToken: out SecurityToken securityToken);

//        var jwtSecurityToken = securityToken as JwtSecurityToken;

//        if(jwtSecurityToken==null||!jwtSecurityToken.Header.Alg.Equals(
//            SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
//        {
//            throw new ValidationException("Invalid token");
//        }

//        return principal;
//    }
//}
