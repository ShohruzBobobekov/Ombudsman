namespace Ombudsman.BizLogicLayer;

public class UpdateDocumentRealizationDto : CreateDocumentRealizationDto
{
    public int Id { get; set; }
    public UpdateInformationLetterDto InformationLetter { get; set; }
    public List<UpdateDocumentRealizationTableDto> DocumentRealizationTables { get; set; }


}
