using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer;

public class InitiativeTypeDto
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }

}
