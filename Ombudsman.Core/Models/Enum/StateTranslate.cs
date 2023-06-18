using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_state_translate")]
public partial class StateTranslate
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

    [ForeignKey(nameof(LanguageId))]    
    public virtual Language Language { get; set; } = null!;
    [ForeignKey(nameof(OwnerId))]
    [InverseProperty(nameof(State.Translates))]
    public virtual State Owner { get; set; } = null!;
}
