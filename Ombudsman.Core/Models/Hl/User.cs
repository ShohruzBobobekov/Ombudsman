using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("hl_user", Schema = "public")]
public class User : Auditable
{
    public string Username { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string Password { get; set; }
    public string PasswordSalt { get; set; }
    public string? LanguageId { get; set; }
    public int? OrganizationId { get; set; }
    [ForeignKey(nameof(OrganizationId))]
    [InverseProperty(nameof(Organization.Users))]
    public Organization UserOrganization { get; set; }

}
