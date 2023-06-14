using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public class InitiativeTypeTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public InitiativeType Owner { get; set; }
}
