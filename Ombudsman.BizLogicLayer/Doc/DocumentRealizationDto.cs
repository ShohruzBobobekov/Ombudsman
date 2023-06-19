using Ombudsman.BizLogicLayer.Manual;
using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class DocumentRealizationDto
{
    public int Id { get; set; }
    public string DocumentSpeciality { get; set; }
    public bool IsIncludedInStateProgram { get; set; }
    public string? StateProgramName { get; set; }
    public string? DocumentSummary { get; set; }
    public DateOnly SentDate { get; set; }
    public int ResponsibleSectorId { get; set; }
    public string MainMinistry { get; set; }
    public string MainRealizer { get; set; }
    public string AdditionalRealizers { get; set; }
    public string Initiative { get; set; }
    public string? DocNumber { get; set; }
    public DateOnly? DocDate { get; set; }
    public Guid? FileId { get; set; }
    public int DocumentTypeId { get; set; }
    public int ImportanceId { get; set; }
    public int InitiativeTypeId { get; set; }
    public int StateId { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedUserId { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedUserId { get; set; }
    public string FileName { get; set; }

    public DocumentTypeDto DocumentType { get; set; }
    public DocumentImportanceDto Importance { get; set; }
    public virtual InitiativeType InitiativeType { get; set; }
    public virtual SectorDto ResponsibleSector { get; set; }
    public virtual StateDto State { get; set; }
    public virtual ICollection<DocumentRealizationTableDto> Tables { get; set; }
    public virtual ICollection<InformationLetterDto> InformationLetters { get; set; }
}
