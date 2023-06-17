using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("hl_user", Schema = "public")]
public class User : Auditable
{
    private const int DEFAULT_EXPIRE_DATE_IN_MINUTES = 1440;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set;}
    public int RoleId { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public int LanguageId { get; set; } = 1;
    public int? OrganizationId { get; set; } 
    public string? RefreshToken { get; private set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime? RefreshTokenExpireDate { get; private set; }

    [ForeignKey(nameof(OrganizationId))]
    [InverseProperty(nameof(Organization.Users))]
    public Organization UserOrganization { get; set; }

    [ForeignKey(nameof(RoleId))]
    public UserRole Role { get; set; }
    public void UpdateRefreshToken(
       string refreshToken,
       int expireDateInMinutes = DEFAULT_EXPIRE_DATE_IN_MINUTES)
    {
        RefreshToken=refreshToken;

        RefreshTokenExpireDate=DateTime.UtcNow
            .AddMinutes(expireDateInMinutes);
    }
}
