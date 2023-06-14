using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

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
