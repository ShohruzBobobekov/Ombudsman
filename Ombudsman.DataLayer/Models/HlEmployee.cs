using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("hl_employee")]
    public partial class HlEmployee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
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
}
