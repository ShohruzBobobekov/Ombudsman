using Ombudsman.Core.Interfaces;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer;

public class CreateDocumentRealizationDto : DocumentRealizationDlDto,
    IEntityDto<CreateDocumentRealizationDto, DocumentRealization>
{

    public CreateInformationLetterDto InformationLetter { get; set; }
    public List<CreateDocumentRealizationTableDto> DocumentRealizationTables { get; set; }
}
