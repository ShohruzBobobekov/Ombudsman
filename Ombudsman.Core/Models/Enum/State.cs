using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ombudsman.Core.Models;

[Table("enum_state")]
public partial class State
{
    public State()
    {
        DocumentRealizations = new HashSet<DocumentRealization>();
        DocumentRealizerTypes = new HashSet<DocumentRealizerType>();
        DocumentStates = new HashSet<DocumentState>();
        DocumentTypes = new HashSet<DocumentType>();
        GovernmentOrganizationTypes = new HashSet<GovernmentOrganizationType>();
        Translates = new HashSet<StateTranslate>();
        UserRoles = new HashSet<UserRole>();
        DocumentImportances = new HashSet<DocumentImportance>();
        Organizations = new HashSet<Organization>();
        Sectors = new HashSet<Sector>();
        StatePrograms = new HashSet<StateProgram>();
    }

    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("short_name")]
    [StringLength(100)]
    public string? ShortName { get; set; }
    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    public virtual ICollection<DocumentRealization> DocumentRealizations { get; set; }
    public virtual ICollection<DocumentRealizerType> DocumentRealizerTypes { get; set; }
    public virtual ICollection<DocumentState> DocumentStates { get; set; }
    public virtual ICollection<DocumentType> DocumentTypes { get; set; }
    public virtual ICollection<GovernmentOrganizationType> GovernmentOrganizationTypes { get; set; }
    public virtual ICollection<StateTranslate> Translates { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }
    public virtual ICollection<DocumentImportance> DocumentImportances { get; set; }
    
    public virtual ICollection<Organization> Organizations { get; set; }
   
    public virtual ICollection<Sector> Sectors { get; set; }
    
    public virtual ICollection<StateProgram> StatePrograms { get; set; }
}
public static class StateIdConst
{
    public const int ACTIVE = 1;
    public const int PASSIVE = 2;
    public const int DELETED = 3;
}
