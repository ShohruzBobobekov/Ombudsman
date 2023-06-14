using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("info_document_importance", Schema = "public")]
public class DocumentImportance : BaseEnum
{
}
