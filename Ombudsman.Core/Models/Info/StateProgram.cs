using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("info_state_program", Schema = "public")]
public class StateProgram : BaseEnum
{
}
