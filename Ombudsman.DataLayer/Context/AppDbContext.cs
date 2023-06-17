using Microsoft.EntityFrameworkCore;

using Ombudsman.Core.Models;


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
    public virtual DbSet<FileModel> FileModels { get; set; }
    public virtual DbSet<InformationLetter> InformationLetters { get; set; }
    public virtual DbSet<InformationLetterTable> InformationLetterTables { get; set; }
    #endregion

    #region Enum
    public virtual DbSet<DocumentRealizerType> DocumentRealizerTypes { get; set; }
    public virtual DbSet<DocumentRealizerTypeTranslate> DocumentRealizerTypeTranslates { get; set; }
    public virtual DbSet<DocumentState> DocumentStates { get; set; }
    public virtual DbSet<DocumentStateTranslate> DocumentStateTranslates { get; set; }
    public virtual DbSet<DocumentType> DocumentTypes { get; set; }
    public virtual DbSet<DocumentTypeTranslate> DocumentTypeTranslates { get; set; }
    public virtual DbSet<GovernmentOrganizationType> GovernmentOrganizationTypes { get; set; }
    public virtual DbSet<GovernmentOrganizationTypeTranslate> GovernmentOrganizationTypeTranslates { get; set; }
    public virtual DbSet<InitiativeType> InitiativeTypes { get; set; }
    public virtual DbSet<InitiativeTypeTranslate> InitiativeTypeTranslates { get; set; }
    public virtual DbSet<Language> Languages { get; set; }
    public virtual DbSet<State> States { get; set; }
    public virtual DbSet<StateTranslate> StateTranslates { get; set; }
    public virtual DbSet<DocumentImportance> DocumentImportances { get; set; }
    public virtual DbSet<DocumentImportanceTranslate> DocumentImportanceTranslates { get; set; }
    #endregion

    #region Hl
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    #endregion

    #region Info
    public virtual DbSet<Organization> Organizations { get; set; }
    public virtual DbSet<Sector> Sectors { get; set; }
    public virtual DbSet<StateProgram> StatePrograms { get; set; }
    #endregion

}
