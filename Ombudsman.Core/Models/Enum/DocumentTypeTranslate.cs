using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public class DocumentTypeTranslate :BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentType Owner { get; set; }
}
