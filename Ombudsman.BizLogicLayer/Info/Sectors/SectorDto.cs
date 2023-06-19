namespace Ombudsman.BizLogicLayer;

public class SectorDto
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public string SectorNumber { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public int StateId { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedUserId { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedUserId { get; set; }
}
