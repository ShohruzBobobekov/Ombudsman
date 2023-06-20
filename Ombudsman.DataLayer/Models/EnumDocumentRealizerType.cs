using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_document_realizer_type")]
    public partial class EnumDocumentRealizerType
    {
        public EnumDocumentRealizerType()
        {
            EnumDocumentRealizerTypeTranslates = new HashSet<EnumDocumentRealizerTypeTranslate>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("order_number")]
        [StringLength(100)]
        public string OrderNumber { get; set; } = null!;
        [Column("short_name")]
        [StringLength(100)]
        public string ShortName { get; set; } = null!;
        [Column("full_name")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;
        [Column("state_id")]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        [InverseProperty("EnumDocumentRealizerTypes")]
        public virtual EnumState State { get; set; } = null!;
        [InverseProperty("Owner")]
        public virtual ICollection<EnumDocumentRealizerTypeTranslate> EnumDocumentRealizerTypeTranslates { get; set; }
    }
}
