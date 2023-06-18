using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombudsman.BizLogicLayer;

public class UserDto : UpdateUserDlDto
{
    public string Organization { get; set; }
    public string Role { get; set; }

}
