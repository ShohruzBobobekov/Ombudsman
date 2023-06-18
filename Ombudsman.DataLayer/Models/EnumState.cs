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

        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
        public virtual ICollection<EnumDocumentRealizerType> EnumDocumentRealizerTypes { get; set; }
        public virtual ICollection<EnumDocumentState> EnumDocumentStates { get; set; }
        public virtual ICollection<EnumDocumentType> EnumDocumentTypes { get; set; }
        public virtual ICollection<EnumGovernmentOrganizationType> EnumGovernmentOrganizationTypes { get; set; }
        public virtual ICollection<EnumStateTranslate> EnumStateTranslates { get; set; }
        public virtual ICollection<EnumUserRole> EnumUserRoles { get; set; }
        public virtual ICollection<InfoDocumentImportance> InfoDocumentImportances { get; set; }
        public virtual ICollection<InfoOrganization> InfoOrganizations { get; set; }
        public virtual ICollection<InfoSector> InfoSectors { get; set; }
        public virtual ICollection<InfoStateProgram> InfoStatePrograms { get; set; }
    }
}
