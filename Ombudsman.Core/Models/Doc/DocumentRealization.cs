using System.ComponentModel.DataAnnotations.Schema;
using Ombudsman.Core.Models.Enum;

namespace Ombudsman.Core.Models;
[Table("doc_document_realization",Schema = "public")]
public class DocumentRealization : Auditable
{
    public string DocumentSpeciality { get; set; }
    public bool IsIncludedInStateProgram { get; set; }
    public string? StateProgramName { get; set; }
    public string? DocumentSummary { get; set; }
    public DateOnly SentDate { get; set; }
    public Sector ResponsibleSector { get; set; }
    public string MainMinistry { get; set; }
    public string MainRealizer { get; set; }
    public string AdditionalRealizers { get; set; }
    public string Initiative { get; set; }
    public string? DocNumber { get; set; }
    public DateOnly? DocDate { get; set; }
    public Guid? FileId { get; set; }
    [ForeignKey(nameof(FileId))]
    public FileModel FileModel { get; set; }

    public DocumentType DocumentType { get; set; }
    public DocumentImportance Importance { get; set; }
    public InitiativeType InitiativeType { get; set; }
    public State State { get; set; }
    public ICollection<DocumentRealizationTable> Tables { get; set; }
    public InformationLetter InformationLetter { get; set; }


}
