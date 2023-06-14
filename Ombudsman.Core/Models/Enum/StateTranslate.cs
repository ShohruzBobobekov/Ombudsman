using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public class StateTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public State Owner { get; set; }
}
