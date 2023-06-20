using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_state")]
    public partial class EnumState
    {
        public EnumState()
        {
            DocDocumentRealizations = new HashSet<DocDocumentRealization>();
            EnumDocumentRealizerTypes = new HashSet<EnumDocumentRealizerType>();
            EnumDocumentStates = new HashSet<EnumDocumentState>();
            EnumDocumentTypes = new HashSet<EnumDocumentType>();
            EnumGovernmentOrganizationTypes = new HashSet<EnumGovernmentOrganizationType>();
            EnumStateTranslates = new HashSet<EnumStateTranslate>();
            EnumUserRoles = new HashSet<EnumUserRole>();
            HlUsers = new HashSet<HlUser>();
            InfoDocumentImportances = new HashSet<InfoDocumentImportance>();
            InfoOrganizations = new HashSet<InfoOrganization>();
            InfoSectors = new HashSet<InfoSector>();
            InfoStatePrograms = new HashSet<InfoStateProgram>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("short_name")]
        [StringLength(100)]
        public string? ShortName { get; set; }
        [Column("full_name")]
        [StringLength(100)]
        public string? FullName { get; set; }

        [InverseProperty("State")]
        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<EnumDocumentRealizerType> EnumDocumentRealizerTypes { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<EnumDocumentState> EnumDocumentStates { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<EnumDocumentType> EnumDocumentTypes { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<EnumGovernmentOrganizationType> EnumGovernmentOrganizationTypes { get; set; }
        [InverseProperty("Owner")]
        public virtual ICollection<EnumStateTranslate> EnumStateTranslates { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<EnumUserRole> EnumUserRoles { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<HlUser> HlUsers { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<InfoDocumentImportance> InfoDocumentImportances { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<InfoOrganization> InfoOrganizations { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<InfoSector> InfoSectors { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<InfoStateProgram> InfoStatePrograms { get; set; }
    }
}
