using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ombudsman.DataLayer.Models
{
    public partial class OmbudsmanAppContext : DbContext
    {
        public OmbudsmanAppContext()
        {
        }

        public OmbudsmanAppContext(DbContextOptions<OmbudsmanAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DocDocumentRealization> DocDocumentRealizations { get; set; } = null!;
        public virtual DbSet<DocDocumentRealizationTable> DocDocumentRealizationTables { get; set; } = null!;
        public virtual DbSet<DocInformationLetter> DocInformationLetters { get; set; } = null!;
        public virtual DbSet<DocInformationLetterTable> DocInformationLetterTables { get; set; } = null!;
        public virtual DbSet<EnumDocumentRealizerType> EnumDocumentRealizerTypes { get; set; } = null!;
        public virtual DbSet<EnumDocumentRealizerTypeTranslate> EnumDocumentRealizerTypeTranslates { get; set; } = null!;
        public virtual DbSet<EnumDocumentState> EnumDocumentStates { get; set; } = null!;
        public virtual DbSet<EnumDocumentStateTranlate> EnumDocumentStateTranlates { get; set; } = null!;
        public virtual DbSet<EnumDocumentType> EnumDocumentTypes { get; set; } = null!;
        public virtual DbSet<EnumDocumentTypeTranslate> EnumDocumentTypeTranslates { get; set; } = null!;
        public virtual DbSet<EnumGovernmentOrganizationType> EnumGovernmentOrganizationTypes { get; set; } = null!;
        public virtual DbSet<EnumGovernmentOrganizationTypeTranslate> EnumGovernmentOrganizationTypeTranslates { get; set; } = null!;
        public virtual DbSet<EnumInitiativeType> EnumInitiativeTypes { get; set; } = null!;
        public virtual DbSet<EnumInitiativeTypeTranslate> EnumInitiativeTypeTranslates { get; set; } = null!;
        public virtual DbSet<EnumLanguage> EnumLanguages { get; set; } = null!;
        public virtual DbSet<EnumState> EnumStates { get; set; } = null!;
        public virtual DbSet<EnumStateTranslate> EnumStateTranslates { get; set; } = null!;
        public virtual DbSet<EnumUserRole> EnumUserRoles { get; set; } = null!;
        public virtual DbSet<HlEmployee> HlEmployees { get; set; } = null!;
        public virtual DbSet<HlUser> HlUsers { get; set; } = null!;
        public virtual DbSet<InfoDocumentImportance> InfoDocumentImportances { get; set; } = null!;
        public virtual DbSet<InfoDocumentImportanceTranslate> InfoDocumentImportanceTranslates { get; set; } = null!;
        public virtual DbSet<InfoOrganization> InfoOrganizations { get; set; } = null!;
        public virtual DbSet<InfoSector> InfoSectors { get; set; } = null!;
        public virtual DbSet<InfoStateProgram> InfoStatePrograms { get; set; } = null!;
        public virtual DbSet<SysFile> SysFiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OmbudsmanApp;Username=postgres;Password=sH0409Sh");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocDocumentRealization>(entity =>
            {
                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.DocDocumentRealizations)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_document_realization_document_type_id_fkey");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.DocDocumentRealizations)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("doc_document_realization_file_id_fkey");

                entity.HasOne(d => d.Importance)
                    .WithMany(p => p.DocDocumentRealizations)
                    .HasForeignKey(d => d.ImportanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_document_realization_importance_id_fkey");

                entity.HasOne(d => d.InitiativeType)
                    .WithMany(p => p.DocDocumentRealizations)
                    .HasForeignKey(d => d.InitiativeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_document_realization_initiative_type_id_fkey");

                entity.HasOne(d => d.ResponsibleSector)
                    .WithMany(p => p.DocDocumentRealizations)
                    .HasForeignKey(d => d.ResponsibleSectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_document_realization_responsible_sector_id_fkey");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.DocDocumentRealizations)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_document_realization_state_id_fkey");
            });

            modelBuilder.Entity<DocDocumentRealizationTable>(entity =>
            {
                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.DocDocumentRealizationTables)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_document_realization_table_owner_id_fkey");
            });

            modelBuilder.Entity<DocInformationLetter>(entity =>
            {
                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.DocInformationLetters)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_information_letter_owner_id_fkey");
            });

            modelBuilder.Entity<DocInformationLetterTable>(entity =>
            {
                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.DocInformationLetterTables)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_information_letter_table_owner_id_fkey");
            });

            modelBuilder.Entity<EnumDocumentRealizerType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.EnumDocumentRealizerTypes)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_realizer_type_state_id_fkey");
            });

            modelBuilder.Entity<EnumDocumentRealizerTypeTranslate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EnumDocumentRealizerTypeTranslates)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_realizer_type_translate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.EnumDocumentRealizerTypeTranslates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_realizer_type_translate_owner_id_fkey");
            });

            modelBuilder.Entity<EnumDocumentState>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.EnumDocumentStates)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_state_state_id_fkey");
            });

            modelBuilder.Entity<EnumDocumentStateTranlate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EnumDocumentStateTranlates)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("enum_document_state_tranlate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.EnumDocumentStateTranlates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_state_tranlate_owner_id_fkey");
            });

            modelBuilder.Entity<EnumDocumentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.EnumDocumentTypes)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_type_state_id_fkey");
            });

            modelBuilder.Entity<EnumDocumentTypeTranslate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EnumDocumentTypeTranslates)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_type_translate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.EnumDocumentTypeTranslates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_document_type_translate_owner_id_fkey");
            });

            modelBuilder.Entity<EnumGovernmentOrganizationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.EnumGovernmentOrganizationTypes)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_government_organization_type_state_id_fkey");
            });

            modelBuilder.Entity<EnumGovernmentOrganizationTypeTranslate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EnumGovernmentOrganizationTypeTranslates)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_government_organization_type_translate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.EnumGovernmentOrganizationTypeTranslates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_government_organization_type_translate_owner_id_fkey");
            });

            modelBuilder.Entity<EnumInitiativeType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnumInitiativeTypeTranslate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EnumInitiativeTypeTranslates)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_initiative_type_translate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.EnumInitiativeTypeTranslates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_initiative_type_translate_owner_id_fkey");
            });

            modelBuilder.Entity<EnumLanguage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnumState>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnumStateTranslate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EnumStateTranslates)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_state_translate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.EnumStateTranslates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_state_translate_owner_id_fkey");
            });

            modelBuilder.Entity<EnumUserRole>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.EnumUserRoles)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("enum_user_role_state_id_fkey");
            });

            modelBuilder.Entity<HlUser>(entity =>
            {
                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.HlUsers)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hl_user_organization_id_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.HlUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hl_user_role_id_fkey");
            });

            modelBuilder.Entity<InfoDocumentImportance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.InfoDocumentImportances)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_document_importance_state_id_fkey");
            });

            modelBuilder.Entity<InfoDocumentImportanceTranslate>(entity =>
            {
                entity.HasOne(d => d.Language)
                    .WithMany(p => p.InfoDocumentImportanceTranslates)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_document_importance_translate_language_id_fkey");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.InfoDocumentImportanceTranslates)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_document_importance_translate_owner_id_fkey");
            });

            modelBuilder.Entity<InfoOrganization>(entity =>
            {
                entity.HasOne(d => d.GovernmentOrganizationType)
                    .WithMany(p => p.InfoOrganizations)
                    .HasForeignKey(d => d.GovernmentOrganizationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_organization_government_organization_type_id_fkey");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.InfoOrganizations)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_organization_state_id_fkey");

                entity.HasOne(d => d.SuperiorOrganization)
                    .WithMany(p => p.InverseSuperiorOrganization)
                    .HasForeignKey(d => d.SuperiorOrganizationId)
                    .HasConstraintName("info_organization_superior_organization_id_fkey");
            });

            modelBuilder.Entity<InfoSector>(entity =>
            {
                entity.HasOne(d => d.State)
                    .WithMany(p => p.InfoSectors)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_sector_state_id_fkey");
            });

            modelBuilder.Entity<InfoStateProgram>(entity =>
            {
                entity.HasOne(d => d.State)
                    .WithMany(p => p.InfoStatePrograms)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("fk_info_state_program_enum_state_state_id");
            });

            modelBuilder.Entity<SysFile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
