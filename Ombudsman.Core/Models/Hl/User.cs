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

}
