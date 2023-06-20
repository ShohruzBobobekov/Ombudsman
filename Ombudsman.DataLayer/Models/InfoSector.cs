using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("info_sector")]
    public partial class InfoSector
    {
        public InfoSector()
        {
            DocDocumentRealizations = new HashSet<DocDocumentRealization>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("order_number")]
        [StringLength(100)]
        public string OrderNumber { get; set; } = null!;
        [Column("sector_number")]
        [StringLength(100)]
        public string SectorNumber { get; set; } = null!;
        [Column("state_id")]
        public int StateId { get; set; }
        [Column("full_name")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;
        [Column("short_name")]
        [StringLength(100)]
        public string ShortName { get; set; } = null!;
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }
        [Column("created_user_id")]
        public int? CreatedUserId { get; set; }
        [Column("updated_at", TypeName = "timestamp without time zone")]
        public DateTime? UpdatedAt { get; set; }
        [Column("updated_user_id")]
        public int? UpdatedUserId { get; set; }

        [ForeignKey("StateId")]
        [InverseProperty("InfoSectors")]
        public virtual EnumState State { get; set; } = null!;
        [InverseProperty("ResponsibleSector")]
        public virtual ICollection<DocDocumentRealization> DocDocumentRealizations { get; set; }
    }
}
