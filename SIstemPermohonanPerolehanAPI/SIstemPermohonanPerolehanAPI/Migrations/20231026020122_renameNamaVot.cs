using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIstemPermohonanPerolehanAPI.Migrations
{
    /// <inheritdoc />
    public partial class renameNamaVot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VotName",
                table: "Vot",
                newName: "NamaVot");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NamaVot",
                table: "Vot",
                newName: "VotName");
        }
    }
}
