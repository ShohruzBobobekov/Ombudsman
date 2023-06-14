using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("sys_file",Schema ="public")]
public class FileModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Extension { get; set; }
}
