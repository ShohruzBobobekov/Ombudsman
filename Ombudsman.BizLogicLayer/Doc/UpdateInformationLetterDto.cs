namespace Ombudsman.BizLogicLayer;

public class UpdateInformationLetterDto : CreateInformationLetterDto
{
    public int? Id { get; set; }
    public List<UpdateInformationLetterTableDto> InformationLetterTables { get; set; }

}
