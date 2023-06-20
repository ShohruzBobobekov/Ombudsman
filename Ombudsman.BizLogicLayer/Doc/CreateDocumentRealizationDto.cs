
using System.Text.Json.Serialization;

using Microsoft.AspNetCore.Http;

namespace Ombudsman.BizLogicLayer;

public class CreateDocumentRealizationDto
{
    public string DocumentSpeciality { get; set; }
    public bool IsIncludedInStateProgram { get; set; }
    public string? StateProgramName { get; set; }
    public string? DocumentSummary { get; set; }
    public DateTime SentDate { get; set; }
    public int ResponsibleSectorId { get; set; }
    public string MainMinistry { get; set; }
    public string MainRealizer { get; set; }
    public string AdditionalRealizers { get; set; }
    public string Initiative { get; set; }
    public string? DocNumber { get; set; }
    public DateTime? DocDate { get; set; }
    public int DocumentTypeId { get; set; }
    public int ImportanceId { get; set; }
    public int InitiativeTypeId { get; set; }
    public int StateId { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
    public int DocumentStateId { get; set; }
    public int OrganizationId { get; set; }
    public CreateInformationLetterDto InformationLetter { get; set; }
    public List<CreateDocumentRealizationTableDto> DocumentRealizationTables { get; set; }
}
