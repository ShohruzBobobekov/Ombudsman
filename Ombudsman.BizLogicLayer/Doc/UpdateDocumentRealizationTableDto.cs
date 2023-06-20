using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer;

public class UpdateDocumentRealizationTableDto : CreateDocumentRealizationTableDto
{
    public int? Id { get; set; }
}
