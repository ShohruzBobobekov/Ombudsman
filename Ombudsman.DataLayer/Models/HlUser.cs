using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("hl_user")]
    public partial class HlUser
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;
        [Column("last_name")]
        [StringLength(100)]
        public string LastName { get; set; } = null!;
        [Column("username")]
        [StringLength(100)]
        public string Username { get; set; } = null!;
        [Column("role_id")]
        public int RoleId { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }
        [Column("phone")]
        [StringLength(20)]
        public string? Phone { get; set; }
        [Column("password_hash")]
        [StringLength(256)]
        public string? PasswordHash { get; set; }
        [Column("salt")]
        [StringLength(100)]
        public string? Salt { get; set; }
        [Column("language_id")]
        public int LanguageId { get; set; }
        [Column("state_id")]
        public int StateId { get; set; }
        [Column("organization_id")]
        public int OrganizationId { get; set; }
        [Column("refresh_token")]
        [StringLength(256)]
        public string? RefreshToken { get; set; }
        [Column("refresh_token_expire_date", TypeName = "timestamp without time zone")]
        public DateTime? RefreshTokenExpireDate { get; set; }
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }
        [Column("created_user_id")]
        public int? CreatedUserId { get; set; }
        [Column("updated_at", TypeName = "timestamp without time zone")]
        public DateTime? UpdatedAt { get; set; }
        [Column("updated_user_id")]
        public int? UpdatedUserId { get; set; }

        [ForeignKey("OrganizationId")]
        [InverseProperty("HlUsers")]
        public virtual InfoOrganization Organization { get; set; } = null!;
        [ForeignKey("RoleId")]
        [InverseProperty("HlUsers")]
        public virtual EnumUserRole Role { get; set; } = null!;
        [ForeignKey("StateId")]
        [InverseProperty("HlUsers")]
        public virtual EnumState State { get; set; } = null!;
    }
}
