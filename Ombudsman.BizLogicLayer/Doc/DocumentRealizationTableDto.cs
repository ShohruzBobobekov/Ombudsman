using System.Text.Json.Serialization;


namespace Ombudsman.BizLogicLayer;

public class DocumentRealizationTableDto
{
    public int Id { get; set; }
    public int OrganizationId { get; set; }
    public string VisaIssuerFullName { get; set; }
    public string VisaIssuerPosition { get; set; }
    public string ResponsibleEmployeeFullName { get; set; }
    public string ResponsibleEmployeePhone { get; set; }
    
    public DateOnly DateEnteredForVisa { get; set; }
    
    public DateOnly DateOfVisaIssuance { get; set; }
    public int OwnerId { get; set; }
}
