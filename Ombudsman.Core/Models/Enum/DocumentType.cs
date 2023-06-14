using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;
[Table("enum_document_type", Schema = "public")]
public class DocumentType : BaseEnum
{

}
