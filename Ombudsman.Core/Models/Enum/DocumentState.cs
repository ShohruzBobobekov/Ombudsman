using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_document_state")]
public partial class DocumentState
{
    public DocumentState()
    {
        Translates = new HashSet<DocumentStateTranslate>();
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
    public virtual State State { get; set; } = null!;
    public virtual ICollection<DocumentStateTranslate> Translates { get; set; }
}
public static class DocumentStateIdConst
{
    public const int LOYIHALANGAN = 1;
    public const int KIRITILGAN = 2;
    public const int RAD_YETILGAN = 3;
    public const int TASDIQLANGAN = 4;
    public const int KUCHGA_KIRGAN = 5;
}
