using System.ComponentModel.DataAnnotations;

namespace Ombudsman.Core.Models;

public class Language
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
}
