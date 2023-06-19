using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("sys_file")]
public partial class FileModel
{
    public FileModel()
    {
        DocumentRealizations = new HashSet<DocumentRealization>();
    }

    [Key]
    [Column("id")]
    public Guid Id { get; set; }
    [Column("name")]
    [StringLength(100)]
    public string Name { get; set; } = null!;
    [Column("extension")]
    [StringLength(10)]
    public string Extension { get; set; } = null!;

    public virtual ICollection<DocumentRealization> DocumentRealizations { get; set; }
}
