using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.DataLayer.Models
{
    [Table("doc_document_realization")]
    public partial class DocDocumentRealization
    {
        public DocDocumentRealization()
        {
            DocDocumentRealizationTables = new HashSet<DocDocumentRealizationTable>();
            DocInformationLetters = new HashSet<DocInformationLetter>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("document_speciality")]
        [StringLength(200)]
        public string DocumentSpeciality { get; set; } = null!;
        [Column("is_included_in_state_program")]
        public bool IsIncludedInStateProgram { get; set; }
        [Column("state_program_name")]
        [StringLength(200)]
        public string? StateProgramName { get; set; }
        [Column("document_summary")]
        [StringLength(1000)]
        public string? DocumentSummary { get; set; }
        [Column("sent_date")]
        public DateOnly SentDate { get; set; }
        [Column("responsible_sector_id")]
        public int ResponsibleSectorId { get; set; }
        [Column("main_ministry")]
        [StringLength(200)]
        public string MainMinistry { get; set; } = null!;
        [Column("main_realizer")]
        [StringLength(200)]
        public string MainRealizer { get; set; } = null!;
        [Column("additional_realizers")]
        [StringLength(200)]
        public string AdditionalRealizers { get; set; } = null!;
        [Column("initiative")]
        [StringLength(200)]
        public string Initiative { get; set; } = null!;
        [Column("doc_number")]
        [StringLength(200)]
        public string? DocNumber { get; set; }
        [Column("doc_date")]
        public DateOnly? DocDate { get; set; }
        [Column("file_id")]
        public Guid? FileId { get; set; }
        [Column("document_type_id")]
        public int DocumentTypeId { get; set; }
        [Column("importance_id")]
        public int ImportanceId { get; set; }
        [Column("initiative_type_id")]
        public int InitiativeTypeId { get; set; }
        [Column("state_id")]
        public int StateId { get; set; }
        [Column("full_name")]
        [StringLength(200)]
        public string FullName { get; set; } = null!;
        [Column("short_name")]
        [StringLength(200)]
        public string ShortName { get; set; } = null!;
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }
        [Column("created_user_id")]
        public int? CreatedUserId { get; set; }
        [Column("updated_at", TypeName = "timestamp without time zone")]
        public DateTime? UpdatedAt { get; set; }
        [Column("updated_user_id")]
        public int? UpdatedUserId { get; set; }

        [ForeignKey("DocumentTypeId")]
        public virtual EnumDocumentType DocumentType { get; set; } = null!;
        [ForeignKey("FileId")]
        public virtual SysFile? File { get; set; }
        [ForeignKey("ImportanceId")]
        public virtual InfoDocumentImportance Importance { get; set; } = null!;
        [ForeignKey("InitiativeTypeId")]
        public virtual EnumInitiativeType InitiativeType { get; set; } = null!;
        [ForeignKey("ResponsibleSectorId")]
        public virtual InfoSector ResponsibleSector { get; set; } = null!;
        [ForeignKey("StateId")]
        public virtual EnumState State { get; set; } = null!;
        public virtual ICollection<DocDocumentRealizationTable> DocDocumentRealizationTables { get; set; }
        public virtual ICollection<DocInformationLetter> DocInformationLetters { get; set; }
    }
}
