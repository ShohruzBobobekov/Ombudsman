using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models
{
    [Table("doc_information_letter")]
    public partial class InformationLetter
    {
        public InformationLetter()
        {
            Tables = new HashSet<InformationLetterTable>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("doc_number")]
        [StringLength(100)]
        public string? DocNumber { get; set; }
        [Column("doc_date")]
        public DateOnly? DocDate { get; set; }
        [Column("information_letter_text")]
        [StringLength(5000)]
        public string InformationLetterText { get; set; } = null!;
        [Column("main_realizer")]
        [StringLength(100)]
        public string MainRealizer { get; set; } = null!;
        [Column("additional_realizers")]
        [StringLength(100)]
        public string AdditionalRealizers { get; set; } = null!;
        [Column("responsible_employee_full_name")]
        [StringLength(100)]
        public string ResponsibleEmployeeFullName { get; set; } = null!;
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = null!;
        [Column("owner_id")]
        public int OwnerId { get; set; }
        [Column("full_name")]
        [StringLength(100)]
        public string FullName { get; set; } = null!;
        [Column("short_name")]
        [StringLength(100)]
        public string ShortName { get; set; } = null!;
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }
        [Column("created_user_id")]
        public int CreatedUserId { get; set; }
        [Column("updated_at", TypeName = "timestamp without time zone")]
        public DateTime UpdatedAt { get; set; }
        [Column("updated_user_id")]
        public int? UpdatedUserId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public virtual DocumentRealization Owner { get; set; } = null!;
        public virtual ICollection<InformationLetterTable> Tables { get; set; }
    }
}
