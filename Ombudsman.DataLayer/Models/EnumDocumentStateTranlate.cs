using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_document_state_tranlate")]
    public partial class EnumDocumentStateTranlate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("owner_id")]
        public int OwnerId { get; set; }
        [Column("language_id")]
        public int? LanguageId { get; set; }
        [Column("column_name")]
        [StringLength(100)]
        public string ColumnName { get; set; } = null!;
        [Column("translate_text")]
        [StringLength(100)]
        public string TranslateText { get; set; } = null!;

        [ForeignKey("LanguageId")]
        [InverseProperty("EnumDocumentStateTranlates")]
        public virtual EnumLanguage? Language { get; set; }
        [ForeignKey("OwnerId")]
        [InverseProperty("EnumDocumentStateTranlates")]
        public virtual EnumDocumentState Owner { get; set; } = null!;
    }
}
