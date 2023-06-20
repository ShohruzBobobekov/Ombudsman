using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("doc_information_letter_table")]
    public partial class DocInformationLetterTable
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("organization_id")]
        public int OrganizationId { get; set; }
        [Column("visa_issuer_full_name")]
        [StringLength(100)]
        public string VisaIssuerFullName { get; set; } = null!;
        [Column("visa_issuer_position")]
        [StringLength(100)]
        public string VisaIssuerPosition { get; set; } = null!;
        [Column("responsible_employee_full_name")]
        [StringLength(100)]
        public string ResponsibleEmployeeFullName { get; set; } = null!;
        [Column("responsible_employee_phone")]
        [StringLength(20)]
        public string ResponsibleEmployeePhone { get; set; } = null!;
        [Column("date_entered_for_visa")]
        public DateOnly DateEnteredForVisa { get; set; }
        [Column("date_of_visa_issuance")]
        public DateOnly DateOfVisaIssuance { get; set; }
        [Column("owner_id")]
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        [InverseProperty("DocInformationLetterTables")]
        public virtual DocInformationLetter Owner { get; set; } = null!;
    }
}
