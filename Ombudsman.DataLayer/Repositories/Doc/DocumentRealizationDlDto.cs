using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.DataLayer;

public class DocumentRealizationDlDto
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
}
