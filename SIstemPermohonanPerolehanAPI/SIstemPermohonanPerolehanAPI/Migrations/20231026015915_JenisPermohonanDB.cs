using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIstemPermohonanPerolehanAPI.Migrations
{
    /// <inheritdoc />
    public partial class JenisPermohonanDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JenisPerolehan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JenisPermohonan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisPerolehan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VotName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanPerolehan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tajuk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KetuaProjek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nilai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarikhPermohonan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhDirancang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoriPerolehan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusPermohonan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerifyBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorizeBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VotId = table.Column<int>(type: "int", nullable: false),
                    JenisPerolehanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanPerolehan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermohonanPerolehan_JenisPerolehan_JenisPerolehanId",
                        column: x => x.JenisPerolehanId,
                        principalTable: "JenisPerolehan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermohonanPerolehan_Vot_VotId",
                        column: x => x.VotId,
                        principalTable: "Vot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PermohonanPerolehan_JenisPerolehanId",
                table: "PermohonanPerolehan",
                column: "JenisPerolehanId");

            migrationBuilder.CreateIndex(
                name: "IX_PermohonanPerolehan_VotId",
                table: "PermohonanPerolehan",
                column: "VotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermohonanPerolehan");

            migrationBuilder.DropTable(
                name: "JenisPerolehan");

            migrationBuilder.DropTable(
                name: "Vot");
        }
    }
}
