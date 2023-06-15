﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Ombudsman.Core.Models;

[Table("enum_document_realizer_type_translate", Schema = "public")]
public class DocumentRealizerTypeTranslate : BaseEntityTranslate
{
    [ForeignKey(nameof(OwnerId))]
    public DocumentRealizationTable Owner { get; set; }
}
