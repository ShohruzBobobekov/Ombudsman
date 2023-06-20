using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_government_organization_type")]
    public partial class EnumGovernmentOrganizationType
    {
        public EnumGovernmentOrganizationType()
        {
            EnumGovernmentOrganizationTypeTranslates = new HashSet<EnumGovernmentOrganizationTypeTranslate>();
            InfoOrganizations = new HashSet<InfoOrganization>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("order_number")]
        [StringLength(100)]
        public string OrderNumber { get; set; } = null!;
        [Column("short_name")]
        [StringLength(100)]
        public string ShortName { get; set; } = null!;
        [Column("full_name")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;
        [Column("state_id")]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        [InverseProperty("EnumGovernmentOrganizationTypes")]
        public virtual EnumState State { get; set; } = null!;
        [InverseProperty("Owner")]
        public virtual ICollection<EnumGovernmentOrganizationTypeTranslate> EnumGovernmentOrganizationTypeTranslates { get; set; }
        [InverseProperty("GovernmentOrganizationType")]
        public virtual ICollection<InfoOrganization> InfoOrganizations { get; set; }
    }
}
