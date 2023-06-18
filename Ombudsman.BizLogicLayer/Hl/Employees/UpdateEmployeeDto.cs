using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer.Hl.Employees
{
    public class UpdateEmployeeDto : CreateEmployeeDto
    {
        public int Id { get; set; }
    }
}
