using System.ComponentModel.DataAnnotations;

namespace Ombudsman.BizLogicLayer;

public class UserDlDto
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public int RoleId { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int? OrganizationId { get; set; }

}
