using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_language")]
public partial class Language
{
    public Language()
    {
        EnumDocumentRealizerTypeTranslates = new HashSet<DocumentRealizerTypeTranslate>();
        EnumDocumentStateTranlates = new HashSet<DocumentStateTranslate>();
        EnumDocumentTypeTranslates = new HashSet<DocumentTypeTranslate>();
        EnumGovernmentOrganizationTypeTranslates = new HashSet<GovernmentOrganizationTypeTranslate>();
        EnumInitiativeTypeTranslates = new HashSet<InitiativeTypeTranslate>();
        EnumStateTranslates = new HashSet<StateTranslate>();
        InfoDocumentImportanceTranslates = new HashSet<DocumentImportanceTranslate>();
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

    public virtual ICollection<DocumentRealizerTypeTranslate> EnumDocumentRealizerTypeTranslates { get; set; }
    public virtual ICollection<DocumentStateTranslate> EnumDocumentStateTranlates { get; set; }
    public virtual ICollection<DocumentTypeTranslate> EnumDocumentTypeTranslates { get; set; }
    public virtual ICollection<GovernmentOrganizationTypeTranslate> EnumGovernmentOrganizationTypeTranslates { get; set; }
    public virtual ICollection<InitiativeTypeTranslate> EnumInitiativeTypeTranslates { get; set; }
    public virtual ICollection<StateTranslate> EnumStateTranslates { get; set; }
    public virtual ICollection<DocumentImportanceTranslate> InfoDocumentImportanceTranslates { get; set; }
}
