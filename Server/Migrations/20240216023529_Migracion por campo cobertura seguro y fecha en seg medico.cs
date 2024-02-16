using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Migracionporcampocoberturaseguroyfechaensegmedico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "SegurosMedicos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "CoberturaSeguro",
                table: "Facturas",
                type: "REAL",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 15, 22, 35, 28, 854, DateTimeKind.Local).AddTicks(2701));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "SegurosMedicos");

            migrationBuilder.DropColumn(
                name: "CoberturaSeguro",
                table: "Facturas");
        }
    }
}
