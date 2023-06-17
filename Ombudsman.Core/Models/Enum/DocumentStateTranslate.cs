using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_document_state_translate")]
public class DocumentStateTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentState Owner { get; set; }
}
