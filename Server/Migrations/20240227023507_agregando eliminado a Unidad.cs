using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class agregandoeliminadoaUnidad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configuracion",
                keyColumn: "ConfiguracionId",
                keyValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Unidades",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Laboratorios",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Laboratorios",
                keyColumn: "LaboratorioId",
                keyValue: 1,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Laboratorios",
                keyColumn: "LaboratorioId",
                keyValue: 2,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 35, 7, 478, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 35, 7, 478, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 26, 22, 35, 7, 478, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 1,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 2,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 3,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 4,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 5,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 6,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 7,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 8,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 9,
                column: "Eliminado",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Unidades");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Laboratorios");

            migrationBuilder.InsertData(
                table: "Configuracion",
                columns: new[] { "ConfiguracionId", "ReOrden" },
                values: new object[] { 1, false });

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 17, 25, 33, 82, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 17, 25, 33, 82, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 17, 25, 33, 82, DateTimeKind.Local).AddTicks(9260));
        }
    }
}
