using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_document_realizer_type")]
public partial class DocumentRealizerType
{
    public DocumentRealizerType()
    {
        Translates = new HashSet<DocumentRealizerTypeTranslate>();
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
    public virtual ICollection<DocumentRealizerTypeTranslate> Translates { get; set; }
}
