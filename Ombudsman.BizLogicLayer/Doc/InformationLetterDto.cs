namespace Ombudsman.BizLogicLayer;

public class InformationLetterDto
{
    public int Id { get; set; }
    public string? DocNumber { get; set; }

    public DateOnly? DocDate { get; set; }
    public string InformationLetterText { get; set; }
    public string MainRealizer { get; set; }
    public string AdditionalRealizers { get; set; }
    public string ResponsibleEmployeeFullName { get; set; }
    public string PhoneNumber { get; set; }
    public int OwnerId { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }


    public List<InformationLetterTableDto> InformationLetterTables { get; set; }
}
