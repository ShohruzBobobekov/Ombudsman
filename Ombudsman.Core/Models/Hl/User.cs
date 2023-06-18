using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

using Ombudsman.Core.Models;

namespace Ombudsman.Core.Models;

[Table("hl_user")]
public partial class User
{
    private const int DEFAULT_EXPIRE_DATE_IN_MINUTES=1440;

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
    public string Email { get; set; } = null!;
    [Column("phone")]
    [StringLength(20)]
    public string Phone { get; set; } = null!;
    [Column("password_hash")]
    [StringLength(256)]
    public string PasswordHash { get; set; } = null!;
    [Column("salt")]
    [StringLength(100)]
    public string Salt { get; set; } = null!;
    [Column("language_id")]
    public int LanguageId { get; set; } = 1;
    public int StateId { get; set; } = 1;
    [Column("organization_id")]
    public int OrganizationId { get; set; }
    [Column("refresh_token")]
    [StringLength(256)]
    public string? RefreshToken { get; set; }
    [Column("refresh_token_expire_date", TypeName = "timestamp without time zone")]
    public DateTime? RefreshTokenExpireDate { get; set; }
    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }
    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }
    [Column("updated_at", TypeName = "timestamp without time zone")]
    public DateTime? UpdatedAt { get; set; }
    [Column("updated_user_id")]
    public int? UpdatedUserId { get; set; }

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; } = null!;
    [ForeignKey("RoleId")]
    public virtual UserRole Role { get; set; } = null!;

    public void UpdateRefreshToken(
     string refreshToken,
     int expireDateInMinutes = DEFAULT_EXPIRE_DATE_IN_MINUTES)
    {
        RefreshToken = refreshToken;

        RefreshTokenExpireDate = DateTime.Now
            .AddMinutes(expireDateInMinutes);
    }
}
