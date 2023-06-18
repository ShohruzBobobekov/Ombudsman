using Ombudsman.BizLogicLayer.Manual;

namespace Ombudsman.BizLogicLayer;

public class OrganizationDto
{
    public int Id { get; set; }
    public int GovernmentOrganizationTypeId { get; set; }
    public bool IsGrouper { get; set; }
    public int? SuperiorOrganizationId { get; set; }
    public int StateId { get; set; }
    public string FullName { get; set; } = null!;
    public string ShortName { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }
    public int? CreatedUserId { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedUserId { get; set; }
    public StateDto State { get; set; }
}
