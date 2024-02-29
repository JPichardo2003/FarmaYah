using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Agregandoforaneadeseguromedicoafactura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 26, 16, 286, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 26, 16, 286, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 26, 16, 286, DateTimeKind.Local).AddTicks(4657));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
