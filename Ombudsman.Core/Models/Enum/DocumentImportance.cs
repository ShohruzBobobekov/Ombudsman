using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("info_document_importance")]
public partial class DocumentImportance
{
    public DocumentImportance()
    {
        DocumentRealizations = new HashSet<DocumentRealization>();
        Translates = new HashSet<DocumentImportanceTranslate>();
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
    public virtual ICollection<DocumentRealization> DocumentRealizations { get; set; }
    public virtual ICollection<DocumentImportanceTranslate> Translates { get; set; }
}
