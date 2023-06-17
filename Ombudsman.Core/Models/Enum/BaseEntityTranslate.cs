using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;


[Index(nameof(LanguageId), nameof(OwnerId), IsUnique = true)]
public class BaseEntityTranslate
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int LanguageId { get; set; }
    [ForeignKey(nameof(LanguageId))]
    public Language Language { get; set; }
    public string ColumnName { get; set; }
    public string TranslateText { get; set; }
}
