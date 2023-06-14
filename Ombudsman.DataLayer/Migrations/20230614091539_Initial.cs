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
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "enum_initiative_type",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_enum_initiative_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "enum_language",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_enum_language", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "enum_state",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_enum_state", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sys_file",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    extension = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sys_file", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "enum_document_realizer_type",
                schema: "public",
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
                    table.PrimaryKey("pk_enum_document_realizer_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_enum_document_realizer_type_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enum_document_type",
                schema: "public",
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
                    table.PrimaryKey("pk_enum_document_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_enum_document_type_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enum_government_organization_type",
                schema: "public",
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
                    table.PrimaryKey("pk_enum_government_organization_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_enum_government_organization_type_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "info_document_importance",
                schema: "public",
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
                    table.PrimaryKey("pk_info_document_importance", x => x.id);
                    table.ForeignKey(
                        name: "fk_info_document_importance_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "info_sector",
                schema: "public",
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
                    table.PrimaryKey("pk_info_sector", x => x.id);
                    table.ForeignKey(
                        name: "fk_info_sector_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "info_state_program",
                schema: "public",
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
                    table.PrimaryKey("pk_info_state_program", x => x.id);
                    table.ForeignKey(
                        name: "fk_info_state_program_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "info_organization",
                schema: "public",
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
                    table.PrimaryKey("pk_info_organization", x => x.id);
                    table.ForeignKey(
                        name: "fk_info_organization_enum_government_organization_type_governm",
                        column: x => x.government_organization_type_id,
                        principalSchema: "public",
                        principalTable: "enum_government_organization_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_info_organization_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_info_organization_info_organization_superior_organization_id",
                        column: x => x.superior_organization_id,
                        principalSchema: "public",
                        principalTable: "info_organization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doc_document_realization",
                schema: "public",
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
                    file_id = table.Column<Guid>(type: "uuid", nullable: true),
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
                    table.PrimaryKey("pk_doc_document_realization", x => x.id);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_enum_document_type_document_type_id",
                        column: x => x.document_type_id,
                        principalSchema: "public",
                        principalTable: "enum_document_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_enum_initiative_type_initiative_typ",
                        column: x => x.initiative_type_id,
                        principalSchema: "public",
                        principalTable: "enum_initiative_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_enum_state_state_id",
                        column: x => x.state_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_info_document_importance_importanc",
                        column: x => x.importance_id,
                        principalSchema: "public",
                        principalTable: "info_document_importance",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_info_sector_responsible_sector_id",
                        column: x => x.responsible_sector_id,
                        principalSchema: "public",
                        principalTable: "info_sector",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_sys_file_file_id",
                        column: x => x.file_id,
                        principalSchema: "public",
                        principalTable: "sys_file",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "hl_user",
                schema: "public",
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
                    organization_id = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    short_name = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_user_id = table.Column<int>(type: "integer", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_user_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hl_user", x => x.id);
                    table.ForeignKey(
                        name: "fk_hl_user_info_organization_organization_id",
                        column: x => x.organization_id,
                        principalSchema: "public",
                        principalTable: "info_organization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doc_document_realization_table",
                schema: "public",
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
                    table.PrimaryKey("pk_doc_document_realization_table", x => x.id);
                    table.ForeignKey(
                        name: "fk_doc_document_realization_table_doc_document_realization_own",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "doc_document_realization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doc_information_letter",
                schema: "public",
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
                    table.PrimaryKey("pk_doc_information_letter", x => x.id);
                    table.ForeignKey(
                        name: "fk_doc_information_letter_doc_document_realization_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "doc_document_realization",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doc_information_letter_table",
                schema: "public",
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
                    table.PrimaryKey("pk_doc_information_letter_table", x => x.id);
                    table.ForeignKey(
                        name: "fk_doc_information_letter_table_doc_information_letter_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "doc_information_letter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_document_type_id",
                schema: "public",
                table: "doc_document_realization",
                column: "document_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_file_id",
                schema: "public",
                table: "doc_document_realization",
                column: "file_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_importance_id",
                schema: "public",
                table: "doc_document_realization",
                column: "importance_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_initiative_type_id",
                schema: "public",
                table: "doc_document_realization",
                column: "initiative_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_responsible_sector_id",
                schema: "public",
                table: "doc_document_realization",
                column: "responsible_sector_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_state_id",
                schema: "public",
                table: "doc_document_realization",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_document_realization_table_owner_id",
                schema: "public",
                table: "doc_document_realization_table",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_doc_information_letter_owner_id",
                schema: "public",
                table: "doc_information_letter",
                column: "owner_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_doc_information_letter_table_owner_id",
                schema: "public",
                table: "doc_information_letter_table",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_enum_document_realizer_type_state_id",
                schema: "public",
                table: "enum_document_realizer_type",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_enum_document_type_state_id",
                schema: "public",
                table: "enum_document_type",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_enum_government_organization_type_state_id",
                schema: "public",
                table: "enum_government_organization_type",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_hl_user_organization_id",
                schema: "public",
                table: "hl_user",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_info_document_importance_state_id",
                schema: "public",
                table: "info_document_importance",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_info_organization_government_organization_type_id",
                schema: "public",
                table: "info_organization",
                column: "government_organization_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_info_organization_state_id",
                schema: "public",
                table: "info_organization",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_info_organization_superior_organization_id",
                schema: "public",
                table: "info_organization",
                column: "superior_organization_id");

            migrationBuilder.CreateIndex(
                name: "ix_info_sector_state_id",
                schema: "public",
                table: "info_sector",
                column: "state_id");

            migrationBuilder.CreateIndex(
                name: "ix_info_state_program_state_id",
                schema: "public",
                table: "info_state_program",
                column: "state_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doc_document_realization_table",
                schema: "public");

            migrationBuilder.DropTable(
                name: "doc_information_letter_table",
                schema: "public");

            migrationBuilder.DropTable(
                name: "enum_document_realizer_type",
                schema: "public");

            migrationBuilder.DropTable(
                name: "enum_language",
                schema: "public");

            migrationBuilder.DropTable(
                name: "hl_user",
                schema: "public");

            migrationBuilder.DropTable(
                name: "info_state_program",
                schema: "public");

            migrationBuilder.DropTable(
                name: "doc_information_letter",
                schema: "public");

            migrationBuilder.DropTable(
                name: "info_organization",
                schema: "public");

            migrationBuilder.DropTable(
                name: "doc_document_realization",
                schema: "public");

            migrationBuilder.DropTable(
                name: "enum_government_organization_type",
                schema: "public");

            migrationBuilder.DropTable(
                name: "enum_document_type",
                schema: "public");

            migrationBuilder.DropTable(
                name: "enum_initiative_type",
                schema: "public");

            migrationBuilder.DropTable(
                name: "info_document_importance",
                schema: "public");

            migrationBuilder.DropTable(
                name: "info_sector",
                schema: "public");

            migrationBuilder.DropTable(
                name: "sys_file",
                schema: "public");

            migrationBuilder.DropTable(
                name: "enum_state",
                schema: "public");
        }
    }
}
