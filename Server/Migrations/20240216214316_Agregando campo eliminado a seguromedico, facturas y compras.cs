using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Agregandocampoeliminadoaseguromedicofacturasycompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoberturaSeguro",
                table: "Facturas");

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "SegurosMedicos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Facturas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Compras",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                columns: new[] { "Eliminado", "Fecha" },
                values: new object[] { false, new DateTime(2024, 2, 16, 17, 43, 15, 846, DateTimeKind.Local).AddTicks(6044) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "SegurosMedicos");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Compras");

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
    }
}
