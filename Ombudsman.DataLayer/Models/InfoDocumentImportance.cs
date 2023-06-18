using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("info_document_importance")]
    public partial class InfoDocumentImportance
    {
        public InfoDocumentImportance()
        {
            DocDocumentRealizations = new HashSet<DocDocumentRealization>();
            InfoDocumentImportanceTranslates = new HashSet<InfoDocumentImportanceTranslate>();
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
        public virtual EnumState State { get; set; } = null!;
        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
        public virtual ICollection<InfoDocumentImportanceTranslate> InfoDocumentImportanceTranslates { get; set; }
    }
}
