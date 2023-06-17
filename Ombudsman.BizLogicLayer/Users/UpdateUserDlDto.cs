using System.ComponentModel.DataAnnotations;

namespace Ombudsman.BizLogicLayer;

public class UpdateUserDlDto : UserDlDto
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Id { get; set; }
}
