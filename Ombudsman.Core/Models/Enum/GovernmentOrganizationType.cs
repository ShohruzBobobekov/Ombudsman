﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_government_organization_type")]
public partial class GovernmentOrganizationType
{
    public GovernmentOrganizationType()
    {
        Translates = new HashSet<GovernmentOrganizationTypeTranslate>();
        InfoOrganizations = new HashSet<Organization>();
    }

    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("order_number")]
    [StringLength(100)]
    public string OrderNumber { get; set; } = null!;
    [Column("short_name")]
    [StringLength(100)]
    public string ShortName { get; set; } = null!;
    [Column("full_name")]
    [StringLength(100)]
    public string FullName { get; set; } = null!;
    [Column("state_id")]
    public int StateId { get; set; }

    [ForeignKey("StateId")]
    public virtual State State { get; set; } = null!;
    public virtual ICollection<GovernmentOrganizationTypeTranslate> Translates { get; set; }
    public virtual ICollection<Organization> InfoOrganizations { get; set; }
}
