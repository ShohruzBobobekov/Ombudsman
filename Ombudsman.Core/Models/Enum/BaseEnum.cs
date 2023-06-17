using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;


public abstract class BaseEnum
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public State State { get; set; }
}
