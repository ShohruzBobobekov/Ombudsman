using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer.Manual;

public class DocumentImportanceDto
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
}
