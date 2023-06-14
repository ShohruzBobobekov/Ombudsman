using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using Ombudsman.Core.Models;
using Ombudsman.Core.Models.Enum;

namespace Ombudsman.DataLayer;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options)
    {
    }
    #region Doc
    public virtual DbSet<DocumentRealization> DocumentRealizations { get; set; }
    public virtual DbSet<DocumentRealizationTable> DocumentRealizationTables { get; set; }
    public virtual DbSet<InformationLetter> InformationLetters { get; set; }
    public virtual DbSet<InformationLetterTable> InformationLetterTables { get; set; }
    #endregion

    #region Enum
    public virtual DbSet<DocumentRealizerType> DocumentRealizerTypes { get; set; }
    public virtual DbSet<DocumentType> DocumentTypes { get; set; }
    public virtual DbSet<GovernmentOrganizationType> GovernmentOrganizationTypes { get; set; }
    public virtual DbSet<InitiativeType> InitiativeTypes { get; set; }
    public virtual DbSet<Language> Languages { get; set; }
    public virtual DbSet<State> States { get; set; }
    #endregion

    #region Hl
    public virtual DbSet<User> Users { get; set; }
    #endregion

    #region Info
    public virtual DbSet<DocumentImportance> DocumentImportances { get; set; }
    public virtual DbSet<Organization> Organizations { get; set; }
    public virtual DbSet<Sector> Sectors { get; set; }
    public virtual DbSet<StateProgram> StatePrograms { get; set; }
    #endregion

}
