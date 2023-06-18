using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_document_state_tranlate")]
public partial class DocumentStateTranslate
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

    [ForeignKey(nameof(LanguageId))]
    public virtual Language? Language { get; set; }
    [ForeignKey(nameof(OwnerId))]
    [InverseProperty(nameof(DocumentState.Translates))]
    public virtual DocumentState Owner { get; set; } = null!;
}
