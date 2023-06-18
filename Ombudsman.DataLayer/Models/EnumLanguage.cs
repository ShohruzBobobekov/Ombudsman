using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_language")]
    public partial class EnumLanguage
    {
        public EnumLanguage()
        {
            EnumDocumentRealizerTypeTranslates = new HashSet<EnumDocumentRealizerTypeTranslate>();
            EnumDocumentStateTranlates = new HashSet<EnumDocumentStateTranlate>();
            EnumDocumentTypeTranslates = new HashSet<EnumDocumentTypeTranslate>();
            EnumGovernmentOrganizationTypeTranslates = new HashSet<EnumGovernmentOrganizationTypeTranslate>();
            EnumInitiativeTypeTranslates = new HashSet<EnumInitiativeTypeTranslate>();
            EnumStateTranslates = new HashSet<EnumStateTranslate>();
            InfoDocumentImportanceTranslates = new HashSet<InfoDocumentImportanceTranslate>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("short_name")]
        [StringLength(100)]
        public string ShortName { get; set; } = null!;
        [Column("full_name")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;

        public virtual ICollection<EnumDocumentRealizerTypeTranslate> EnumDocumentRealizerTypeTranslates { get; set; }
        public virtual ICollection<EnumDocumentStateTranlate> EnumDocumentStateTranlates { get; set; }
        public virtual ICollection<EnumDocumentTypeTranslate> EnumDocumentTypeTranslates { get; set; }
        public virtual ICollection<EnumGovernmentOrganizationTypeTranslate> EnumGovernmentOrganizationTypeTranslates { get; set; }
        public virtual ICollection<EnumInitiativeTypeTranslate> EnumInitiativeTypeTranslates { get; set; }
        public virtual ICollection<EnumStateTranslate> EnumStateTranslates { get; set; }
        public virtual ICollection<InfoDocumentImportanceTranslate> InfoDocumentImportanceTranslates { get; set; }
    }
}
