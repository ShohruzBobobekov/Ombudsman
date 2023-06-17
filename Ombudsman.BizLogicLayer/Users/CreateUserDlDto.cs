using System.ComponentModel.DataAnnotations;

namespace Ombudsman.BizLogicLayer;

public class CreateUserDlDto : UserDlDto
{
    [Required]
    public string Password { get; set; }
}
