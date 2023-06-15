using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_government_organization_type_translate", Schema = "public")]
public class GovernmentOrganizationTypeTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public GovernmentOrganizationType Owner { get; set; }
}
