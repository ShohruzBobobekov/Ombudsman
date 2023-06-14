using System.ComponentModel.DataAnnotations;

namespace Ombudsman.Core.Models;

public abstract class Auditable
{
    [Key]
    public int Id { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public DateTime CreatedDate { get; set; }
    public int? CreatedUserId { get; set; }
    public DateTime UpdatedDate { get; set; }
    public int? UpdatedUserId { get; set; }


}
