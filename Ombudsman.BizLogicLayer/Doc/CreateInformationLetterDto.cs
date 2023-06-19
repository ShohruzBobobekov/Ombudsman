using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer;

public class CreateInformationLetterDto
{
    public string? DocNumber { get; set; }
    public DateTime? DocDate { get; set; }
    public string InformationLetterText { get; set; }
    public string MainRealizer { get; set; }
    public string AdditionalRealizers { get; set; }
    public string ResponsibleEmployeeFullName { get; set; }
    public string PhoneNumber { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }


    public List<CreateInformationLetterTableDto> InformationLetterTables { get; set; }
}
