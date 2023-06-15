using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("info_document_importance_translate", Schema = "public")]

public class DocumentImportanceTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentImportance Owner { get; set; }
}
