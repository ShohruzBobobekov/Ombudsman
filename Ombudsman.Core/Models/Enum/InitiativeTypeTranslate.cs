using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_initiative_type_translate", Schema = "public")]
public class InitiativeTypeTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public InitiativeType Owner { get; set; }
}
