using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_document_type_translate", Schema = "public")]
public class DocumentTypeTranslate :BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentType Owner { get; set; }
}
