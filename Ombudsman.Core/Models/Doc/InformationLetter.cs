using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("doc_information_letter", Schema = "public")]
public class InformationLetter : Auditable
{
    public string? DocNumber { get; set; }
    public DateOnly? DocDate { get; set; }
    public string InformationLetterText { get; set; }
    public string MainRealizer { get; set; }
    public string AdditionalRealizers { get; set; }
    public string ResponsibleEmployeeFullName { get; set; }
    public string PhoneNumber { get; set; }
    public int OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))]
    [InverseProperty(nameof(DocumentRealization.InformationLetter))]
    public DocumentRealization Owner { get; set; }
    public ICollection<InformationLetterTable> Tables { get; set;}
}
