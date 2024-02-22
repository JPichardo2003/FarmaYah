using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 13, 59, 59, 528, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 13, 59, 59, 528, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 13, 59, 59, 528, DateTimeKind.Local).AddTicks(1681));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 13, 36, 28, 396, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 13, 36, 28, 396, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 13, 36, 28, 396, DateTimeKind.Local).AddTicks(8185));
        }
    }
}
