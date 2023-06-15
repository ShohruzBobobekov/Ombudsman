using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_user_role_translate")]
internal class UserRoleTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public UserRole Owner { get; set; }
}
