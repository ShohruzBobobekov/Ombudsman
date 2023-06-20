using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("info_document_importance_translate")]
    public partial class InfoDocumentImportanceTranslate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("owner_id")]
        public int OwnerId { get; set; }
        [Column("language_id")]
        public int LanguageId { get; set; }
        [Column("column_name")]
        [StringLength(100)]
        public string ColumnName { get; set; } = null!;
        [Column("translate_text")]
        [StringLength(100)]
        public string TranslateText { get; set; } = null!;

        [ForeignKey("LanguageId")]
        [InverseProperty("InfoDocumentImportanceTranslates")]
        public virtual EnumLanguage Language { get; set; } = null!;
        [ForeignKey("OwnerId")]
        [InverseProperty("InfoDocumentImportanceTranslates")]
        public virtual InfoDocumentImportance Owner { get; set; } = null!;
    }
}
