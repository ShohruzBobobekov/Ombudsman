using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("info_organization")]
    public partial class InfoOrganization
    {
        public InfoOrganization()
        {
            DocDocumentRealizations = new HashSet<DocDocumentRealization>();
            HlUsers = new HashSet<HlUser>();
            InverseSuperiorOrganization = new HashSet<InfoOrganization>();
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
        public DateTime CreatedAt { get; set; }
        [Column("created_user_id")]
        public int? CreatedUserId { get; set; }
        [Column("updated_at", TypeName = "timestamp without time zone")]
        public DateTime? UpdatedAt { get; set; }
        [Column("updated_user_id")]
        public int? UpdatedUserId { get; set; }

        [ForeignKey("GovernmentOrganizationTypeId")]
        [InverseProperty("InfoOrganizations")]
        public virtual EnumGovernmentOrganizationType GovernmentOrganizationType { get; set; } = null!;
        [ForeignKey("StateId")]
        [InverseProperty("InfoOrganizations")]
        public virtual EnumState State { get; set; } = null!;
        [ForeignKey("SuperiorOrganizationId")]
        [InverseProperty("InverseSuperiorOrganization")]
        public virtual InfoOrganization? SuperiorOrganization { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<HlUser> HlUsers { get; set; }
        [InverseProperty("SuperiorOrganization")]
        public virtual ICollection<InfoOrganization> InverseSuperiorOrganization { get; set; }
    }
}
