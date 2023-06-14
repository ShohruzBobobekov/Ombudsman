using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models.Enum
{
    public class GovernmentOrganizationTypeTranslate : BaseEntityTranslate
    {
        [ForeignKey(nameof(OwnerId))]
        public GovernmentOrganizationType Owner { get; set; }
    }
}
