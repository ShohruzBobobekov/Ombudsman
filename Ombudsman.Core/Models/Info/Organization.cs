using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("info_organization")]
public partial class Organization
{
    public Organization()
    {
        HlUsers = new HashSet<User>();
        InverseSuperiorOrganization = new HashSet<Organization>();
    }

    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("government_organization_type_id")]
    public int GovernmentOrganizationTypeId { get; set; }
    [Column("is_grouper")]
    public bool IsGrouper { get; set; }
    [Column("superior_organization_id")]
    public int? SuperiorOrganizationId { get; set; }
    [Column("state_id")]
    public int StateId { get; set; }
    [Column("full_name")]
    [StringLength(100)]
    public string FullName { get; set; } = null!;
    [Column("short_name")]
    [StringLength(100)]
    public string ShortName { get; set; } = null!;
    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }
    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }
    [Column("updated_at", TypeName = "timestamp without time zone")]
    public DateTime? UpdatedAt { get; set; }
    [Column("updated_user_id")]
    public int? UpdatedUserId { get; set; }

    [ForeignKey("GovernmentOrganizationTypeId")]
    public virtual GovernmentOrganizationType GovernmentOrganizationType { get; set; } = null!;
    [ForeignKey("StateId")]
    public virtual State State { get; set; } = null!;
    [ForeignKey("SuperiorOrganizationId")]
    public virtual Organization SuperiorOrganization { get; set; } = null;
    public virtual ICollection<User> HlUsers { get; set; }
    public virtual ICollection<Organization> InverseSuperiorOrganization { get; set; }
}
