using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

public class DocumentRealizationTable
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
    [ForeignKey(nameof(OwnerId))]
    [InverseProperty(nameof(DocumentRealization.Tables))]
    public DocumentRealization Owner { get; set; }
}
