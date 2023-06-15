using System.ComponentModel.DataAnnotations;

namespace Ombudsman.BizLogicLayer.User;

public class UpdateUserDlDto : UserDlDto
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Id { get; set; }
}
