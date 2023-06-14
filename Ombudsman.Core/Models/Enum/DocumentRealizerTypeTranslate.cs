using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public class DocumentRealizerTypeTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentRealizationTable Owner { get; set; }
}
