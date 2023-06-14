namespace Ombudsman.Core.Models;

public class Sector : Auditable
{
    public string OrderNumber { get; set; }
    public string SectorNumber { get; set;}
    public State State { get; set; }
}
