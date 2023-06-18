using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("enum_document_state")]
    public partial class EnumDocumentState
    {
        public EnumDocumentState()
        {
            EnumDocumentStateTranlates = new HashSet<EnumDocumentStateTranlate>();
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
        public virtual EnumState State { get; set; } = null!;
        public virtual ICollection<EnumDocumentStateTranlate> EnumDocumentStateTranlates { get; set; }
    }
}
