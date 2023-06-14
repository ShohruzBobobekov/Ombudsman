using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ombudsman.DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "initiative_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_initiative_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_states", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: false),
                    password_salt = table.Column<string>(type: "text", nullable: false),
                    language_id = table.Column<string>(type: "text", nullable: true),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "document_importances",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_number = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_importances", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_importances_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_realizer_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_number = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_realizer_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_realizer_types_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_number = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_types_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "government_organization_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_number = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_government_organization_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_government_organization_types_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sectors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_number = table.Column<string>(type: "text", nullable: false),
                    sector_number = table.Column<string>(type: "text", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sectors", x => x.id);
                    table.ForeignKey(
                        name: "fk_sectors_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "state_programs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_number = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_state_programs", x => x.id);
                    table.ForeignKey(
                        name: "fk_state_programs_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "organizations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    government_organization_type_id = table.Column<int>(type: "integer", nullable: false),
                    is_grouper = table.Column<bool>(type: "boolean", nullable: false),
                    superior_organization_id = table.Column<int>(type: "integer", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_organizations", x => x.id);
                    table.ForeignKey(
                        name: "fk_organizations_government_organization_types_government_organ",
                        column: x => x.government_organization_type_id,
                        principalTable: "government_organization_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_organizations_organizations_superior_organization_id",
                        column: x => x.superior_organization_id,
                        principalTable: "organizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_organizations_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_realizations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    document_speciality = table.Column<string>(type: "text", nullable: false),
                    is_included_in_state_program = table.Column<bool>(type: "boolean", nullable: false),
                    state_program_name = table.Column<string>(type: "text", nullable: true),
                    document_summary = table.Column<string>(type: "text", nullable: true),
                    sent_date = table.Column<DateOnly>(type: "date", nullable: false),
                    responsible_sector_id = table.Column<int>(type: "integer", nullable: false),
                    main_ministry = table.Column<string>(type: "text", nullable: false),
                    main_realizer = table.Column<string>(type: "text", nullable: false),
                    additional_realizers = table.Column<string>(type: "text", nullable: false),
                    initiative = table.Column<string>(type: "text", nullable: false),
                    doc_number = table.Column<string>(type: "text", nullable: true),
                    doc_date = table.Column<DateOnly>(type: "date", nullable: true),
                    document_type_id = table.Column<int>(type: "integer", nullable: false),
                    importance_id = table.Column<int>(type: "integer", nullable: false),
                    initiative_type_id = table.Column<int>(type: "integer", nullable: false),
                    state_id = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_realizations", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_realizations_document_importances_importance_id",
                        column: x => x.importance_id,
                        principalTable: "document_importances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_realizations_document_types_document_type_id",
                        column: x => x.document_type_id,
                        principalTable: "document_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_realizations_initiative_types_initiative_type_id",
                        column: x => x.initiative_type_id,
                        principalTable: "initiative_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_realizations_sectors_responsible_sector_id",
                        column: x => x.responsible_sector_id,
                        principalTable: "sectors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_realizations_states_state_id",
                        column: x => x.state_id,
                        principalTable: "states",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_realization_tables",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    organization_id = table.Column<int>(type: "integer", nullable: false),
                    visa_issuer_full_name = table.Column<string>(type: "text", nullable: false),
                    visa_issuer_position = table.Column<string>(type: "text", nullable: false),
                    responsible_employee_full_name = table.Column<string>(type: "text", nullable: false),
                    responsible_employee_phone = table.Column<string>(type: "text", nullable: false),
                    date_entered_for_visa = table.Column<DateOnly>(type: "date", nullable: false),
                    date_of_visa_issuance = table.Column<DateOnly>(type: "date", nullable: false),
                    owner_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_realization_tables", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_realization_tables_document_realizations_owner_id",
                        column: x => x.owner_id,
                        principalTable: "document_realizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "information_letters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    doc_number = table.Column<string>(type: "text", nullable: true),
                    doc_date = table.Column<DateOnly>(type: "date", nullable: true),
                    information_letter_text = table.Column<string>(type: "text", nullable: false),
                    main_realizer = table.Column<string>(type: "text", nullable: false),
                    additional_realizers = table.Column<string>(type: "text", nullable: false),
                    responsible_employee_full_name = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_information_letters", x => x.id);
                    table.ForeignKey(
                        name: "fk_information_letters_document_realizations_owner_id",
                        column: x => x.owner_id,
                        principalTable: "document_realizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "information_letter_tables",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    organization_id = table.Column<int>(type: "integer", nullable: false),
                    visa_issuer_full_name = table.Column<string>(type: "text", nullable: false),
                    visa_issuer_position = table.Column<string>(type: "text", nullable: false),
                    responsible_employee_full_name = table.Column<string>(type: "text", nullable: false),
                    responsible_employee_phone = table.Column<string>(type: "text", nullable: false),
                    date_entered_for_visa = table.Column<DateOnly>(type: "date", nullable: false),
                    date_of_visa_issuance = table.Column<DateOnly>(type: "date", nullable: false),
                    owner_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_information_letter_tables", x => x.id);
                    table.ForeignKey(
                        name: "fk_information_letter_tables_information_letters_owner_id",
                        column: x => x.owner_id,
                        principalTable: "information_letters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_document_importances_state_id",
                table: "document_importances",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realization_tables_owner_id",
                table: "document_realization_tables",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizations_document_type_id",
                table: "document_realizations",
                column: "document_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizations_importance_id",
                table: "document_realizations",
                column: "importance_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizations_initiative_type_id",
                table: "document_realizations",
                column: "initiative_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizations_responsible_sector_id",
                table: "document_realizations",
                column: "responsible_sector_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizations_state_id",
                table: "document_realizations",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizer_types_state_id",
                table: "document_realizer_types",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_types_state_id",
                table: "document_types",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_government_organization_types_state_id",
                table: "government_organization_types",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_information_letter_tables_owner_id",
                table: "information_letter_tables",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_information_letters_owner_id",
                table: "information_letters",
                column: "owner_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_organizations_government_organization_type_id",
                table: "organizations",
                column: "government_organization_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_organizations_state_id",
                table: "organizations",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_organizations_superior_organization_id",
                table: "organizations",
                column: "superior_organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_sectors_state_id",
                table: "sectors",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_state_programs_state_id",
                table: "state_programs",
                column: "state_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "document_realization_tables");

            migrationBuilder.DropTable(
                name: "document_realizer_types");

            migrationBuilder.DropTable(
                name: "information_letter_tables");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "organizations");

            migrationBuilder.DropTable(
                name: "state_programs");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "information_letters");

            migrationBuilder.DropTable(
                name: "government_organization_types");

            migrationBuilder.DropTable(
                name: "document_realizations");

            migrationBuilder.DropTable(
                name: "document_importances");

            migrationBuilder.DropTable(
                name: "document_types");

            migrationBuilder.DropTable(
                name: "initiative_types");

            migrationBuilder.DropTable(
                name: "sectors");

            migrationBuilder.DropTable(
                name: "states");
        }
    }
}
