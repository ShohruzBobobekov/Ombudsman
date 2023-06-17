using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;
[Table("enum_language", Schema = "public")]
public class Language
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
}
