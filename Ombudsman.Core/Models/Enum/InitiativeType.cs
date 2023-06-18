using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_initiative_type")]
public partial class InitiativeType
{
    public InitiativeType()
    {
        DocDocumentRealizations = new HashSet<DocumentRealization>();
        Translates = new HashSet<InitiativeTypeTranslate>();
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

    public virtual ICollection<DocumentRealization> DocDocumentRealizations { get; set; }
    public virtual ICollection<InitiativeTypeTranslate> Translates { get; set; }
}
