using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public class DocumentImportanceTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentImportance Owner { get; set; }
}
