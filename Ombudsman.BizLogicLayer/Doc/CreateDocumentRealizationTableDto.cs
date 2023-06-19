using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer;

public class CreateDocumentRealizationTableDto
{
    public int OrganizationId { get; set; }
    public string VisaIssuerFullName { get; set; }
    public string VisaIssuerPosition { get; set; }
    public string ResponsibleEmployeeFullName { get; set; }
    public string ResponsibleEmployeePhone { get; set; }
    public DateTime DateEnteredForVisa { get; set; }
    public DateTime DateOfVisaIssuance { get; set; }
}
