using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer;

public class CreateSectorDto
{
    public string OrderNumber { get; set; }
    public string SectorNumber { get; set; }
    public string FullName { get; set; }
    public string ShortName { get; set; }
}
