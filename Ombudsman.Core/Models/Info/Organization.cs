using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("info_organization", Schema = "public")]
public class Organization : Auditable
{
    public GovernmentOrganizationType GovernmentOrganizationType { get; set; }
    public bool IsGrouper { get; set; }
    public Organization SuperiorOrganization { get; set; }
    public State State { get; set; }
    public ICollection<User> Users { get; set; }
}
