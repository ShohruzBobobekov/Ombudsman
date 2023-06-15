using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_state_translate", Schema = "public")]
public class StateTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public State Owner { get; set; }
}
