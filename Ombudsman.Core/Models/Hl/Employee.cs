using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ombudsman.Core.Models;

[Table("hl_employee")]
public partial class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; } = null!;
    [Column("last_name")]
    public string LastName { get; set; } = null!;
    [Column("organization_id")]
    public int OrganizationId { get; set; }
    [Column("position")]
    [StringLength(100)]
    public string Position { get; set; } = null!;
    [Column("salary")]
    public decimal? Salary { get; set; }
    [Column("phone_number")]
    [StringLength(20)]
    public string? PhoneNumber { get; set; }
    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime CreatedAt { get; set; }
    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }
    [Column("updated_at", TypeName = "timestamp without time zone")]
    public DateTime? UpdatedAt { get; set; }
    [Column("updated_user_id")]
    public int? UpdatedUserId { get; set; }
}
