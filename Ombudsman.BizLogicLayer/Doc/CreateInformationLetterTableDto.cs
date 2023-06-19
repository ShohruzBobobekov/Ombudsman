using System.Text.Json.Serialization;

namespace Ombudsman.BizLogicLayer;

public class CreateInformationLetterTableDto
{
    public int OrganizationId { get; set; }
    public string VisaIssuerFullName { get; set; }
    public string VisaIssuerPosition { get; set; }
    public string ResponsibleEmployeeFullName { get; set; }
    public string ResponsibleEmployeePhone { get; set; }
    public DateTime DateEnteredForVisa { get; set; }
    public DateTime DateOfVisaIssuance { get; set; }
}
