using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Quitandoforaneadeseguromedicoafactura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_SegurosMedicos_SeguroMedicoId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_SeguroMedicoId",
                table: "Facturas");

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 25, 2, 752, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 25, 2, 752, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 25, 2, 752, DateTimeKind.Local).AddTicks(8252));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 21, 54, 4, 276, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 21, 54, 4, 276, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 21, 54, 4, 276, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_SeguroMedicoId",
                table: "Facturas",
                column: "SeguroMedicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_SegurosMedicos_SeguroMedicoId",
                table: "Facturas",
                column: "SeguroMedicoId",
                principalTable: "SegurosMedicos",
                principalColumn: "SeguroMedicoId");
        }
    }
}
