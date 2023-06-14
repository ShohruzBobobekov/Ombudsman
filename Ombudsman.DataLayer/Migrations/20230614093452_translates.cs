using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ombudsman.DataLayer.Migrations
{
    public partial class translates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "document_importance_translates",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    column_name = table.Column<string>(type: "text", nullable: false),
                    translate_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_importance_translates", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_importance_translates_enum_language_language_id",
                        column: x => x.language_id,
                        principalSchema: "public",
                        principalTable: "enum_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_importance_translates_info_document_importance_own",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "info_document_importance",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_realizer_type_translates",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    column_name = table.Column<string>(type: "text", nullable: false),
                    translate_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_realizer_type_translates", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_realizer_type_translates_doc_document_realization_",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "doc_document_realization_table",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_realizer_type_translates_enum_language_language_id",
                        column: x => x.language_id,
                        principalSchema: "public",
                        principalTable: "enum_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_type_translates",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    column_name = table.Column<string>(type: "text", nullable: false),
                    translate_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_type_translates", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_type_translates_enum_document_type_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "enum_document_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_document_type_translates_enum_language_language_id",
                        column: x => x.language_id,
                        principalSchema: "public",
                        principalTable: "enum_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "government_organization_type_translates",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    column_name = table.Column<string>(type: "text", nullable: false),
                    translate_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_government_organization_type_translates", x => x.id);
                    table.ForeignKey(
                        name: "fk_government_organization_type_translates_enum_government_org",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "enum_government_organization_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_government_organization_type_translates_enum_language_langu",
                        column: x => x.language_id,
                        principalSchema: "public",
                        principalTable: "enum_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "initiative_type_translates",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    column_name = table.Column<string>(type: "text", nullable: false),
                    translate_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_initiative_type_translates", x => x.id);
                    table.ForeignKey(
                        name: "fk_initiative_type_translates_enum_initiative_type_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "enum_initiative_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_initiative_type_translates_enum_language_language_id",
                        column: x => x.language_id,
                        principalSchema: "public",
                        principalTable: "enum_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "state_translates",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    column_name = table.Column<string>(type: "text", nullable: false),
                    translate_text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_state_translates", x => x.id);
                    table.ForeignKey(
                        name: "fk_state_translates_enum_language_language_id",
                        column: x => x.language_id,
                        principalSchema: "public",
                        principalTable: "enum_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_state_translates_enum_state_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "public",
                        principalTable: "enum_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_document_importance_translates_language_id",
                table: "document_importance_translates",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_importance_translates_owner_id",
                table: "document_importance_translates",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizer_type_translates_language_id",
                table: "document_realizer_type_translates",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_realizer_type_translates_owner_id",
                table: "document_realizer_type_translates",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_type_translates_language_id",
                table: "document_type_translates",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_type_translates_owner_id",
                table: "document_type_translates",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_government_organization_type_translates_language_id",
                table: "government_organization_type_translates",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_government_organization_type_translates_owner_id",
                table: "government_organization_type_translates",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_initiative_type_translates_language_id",
                table: "initiative_type_translates",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_initiative_type_translates_owner_id",
                table: "initiative_type_translates",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_state_translates_language_id",
                table: "state_translates",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_state_translates_owner_id",
                table: "state_translates",
                column: "owner_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "document_importance_translates");

            migrationBuilder.DropTable(
                name: "document_realizer_type_translates");

            migrationBuilder.DropTable(
                name: "document_type_translates");

            migrationBuilder.DropTable(
                name: "government_organization_type_translates");

            migrationBuilder.DropTable(
                name: "initiative_type_translates");

            migrationBuilder.DropTable(
                name: "state_translates");
        }
    }
}
