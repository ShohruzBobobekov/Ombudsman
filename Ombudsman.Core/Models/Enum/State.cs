using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_state", Schema = "public")]
public class State 
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
}
