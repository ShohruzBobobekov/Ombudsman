using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

internal class UserRoleTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public UserRole Owner { get; set; }
}
