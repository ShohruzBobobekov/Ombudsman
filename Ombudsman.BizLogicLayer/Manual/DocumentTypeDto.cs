using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer.Manual;

public class DocumentTypeDto
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
}
