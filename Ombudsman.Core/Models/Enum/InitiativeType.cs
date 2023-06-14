using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_initiative_type", Schema = "public")]
public class InitiativeType
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
}
