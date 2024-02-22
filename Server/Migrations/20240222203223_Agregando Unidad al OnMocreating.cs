using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoUnidadalOnMocreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 16, 32, 23, 589, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.InsertData(
                table: "Unidades",
                columns: new[] { "UnidadId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Pastilla" },
                    { 2, "Jarabe" },
                    { 3, "Capsulas" },
                    { 4, "Inyección" },
                    { 5, "Crema" },
                    { 6, "Supositorio" },
                    { 7, "Gotas" },
                    { 8, "Spray" },
                    { 9, "Otros" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Unidades",
                keyColumn: "UnidadId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 7, 18, 46, 92, DateTimeKind.Local).AddTicks(7718));
        }
    }
}
