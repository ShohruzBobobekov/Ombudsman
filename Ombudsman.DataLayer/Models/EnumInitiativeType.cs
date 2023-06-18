using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_initiative_type")]
    public partial class EnumInitiativeType
    {
        public EnumInitiativeType()
        {
            DocDocumentRealizations = new HashSet<DocDocumentRealization>();
            EnumInitiativeTypeTranslates = new HashSet<EnumInitiativeTypeTranslate>();
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

        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
        public virtual ICollection<EnumInitiativeTypeTranslate> EnumInitiativeTypeTranslates { get; set; }
    }
}
