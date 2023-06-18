using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("sys_file")]
    public partial class SysFile
    {
        public SysFile()
        {
            DocDocumentRealizations = new HashSet<DocDocumentRealization>();
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

        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
    }
}
