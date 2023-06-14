namespace Ombudsman.Core.Models;

public class Organization : Auditable
{
    public GovernmentOrganizationType GovernmentOrganizationType { get; set; }
    public bool IsGrouper { get; set; }
    public Organization SuperiorOrganization { get; set; }
    public State State { get; set; }
}
