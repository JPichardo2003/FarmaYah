using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Agregandocamposasucursal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RNC",
                table: "Sucursales",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 1,
                columns: new[] { "Direccion", "RNC" },
                values: new object[] { "Libertad", "402456782" });

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 2,
                columns: new[] { "Direccion", "RNC" },
                values: new object[] { "New York", "402456783" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RNC",
                table: "Sucursales");

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

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 1,
                column: "Direccion",
                value: "Direccion 1");

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "SucursalId",
                keyValue: 2,
                column: "Direccion",
                value: "Direccion 2");
        }
    }
}
