using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Agregandoguionesautoateldelcliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Reordenable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Reordenable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 15, 54, 42, 237, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 15, 54, 42, 237, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 15, 54, 42, 237, DateTimeKind.Local).AddTicks(8822));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Reordenable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Reordenable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 27, 16, 50, 12, 707, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 27, 16, 50, 12, 707, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 27, 16, 50, 12, 707, DateTimeKind.Local).AddTicks(4231));
        }
    }
}
