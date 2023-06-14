using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("info_sector", Schema = "public")]
public class Sector : Auditable
{
    public string OrderNumber { get; set; }
    public string SectorNumber { get; set;}
    public State State { get; set; }
}
