namespace Ombudsman.BizLogicLayer;

public class CreateOrganizationDto
{
    public int GovernmentOrganizationTypeId { get; set; }
    public bool IsGrouper { get; set; }
    public int? SuperiorOrganizationId { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
}
