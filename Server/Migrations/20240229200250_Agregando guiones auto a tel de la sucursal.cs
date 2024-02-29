using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Agregandoguionesautoateldelasucursal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 16, 2, 50, 316, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 16, 2, 50, 316, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 16, 2, 50, 316, DateTimeKind.Local).AddTicks(7869));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
