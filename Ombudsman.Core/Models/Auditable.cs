using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public abstract class Auditable
{
    [Key]
    public int Id { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }
    public int? CreatedUserId { get; set; }
    [Column(TypeName = "timestamp without time zone")]
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedUserId { get; set; } = null;
    public int StateId { get; set; } = 1;
    public State State { get; set; }
}
