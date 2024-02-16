using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIstemPermohonanPerolehanAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TarikhDirancang",
                table: "PermohonanPerolehan",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CategoriPerolehan",
                table: "PermohonanPerolehan",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "JenisPermohonan",
                table: "JenisPerolehan",
                newName: "Jenis");

            migrationBuilder.AddColumn<int>(
                name: "NilaiVot",
                table: "Vot",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PermohonanPerolehan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PermohonanPerolehan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TarikhMulaProjek",
                table: "PermohonanPerolehan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NilaiVot",
                table: "Vot");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PermohonanPerolehan");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PermohonanPerolehan");

            migrationBuilder.DropColumn(
                name: "TarikhMulaProjek",
                table: "PermohonanPerolehan");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "PermohonanPerolehan",
                newName: "TarikhDirancang");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "PermohonanPerolehan",
                newName: "CategoriPerolehan");

            migrationBuilder.RenameColumn(
                name: "Jenis",
                table: "JenisPerolehan",
                newName: "JenisPermohonan");
        }
    }
}
