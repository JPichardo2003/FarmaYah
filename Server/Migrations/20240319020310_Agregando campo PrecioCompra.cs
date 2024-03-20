using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandocampoPrecioCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecioCompra",
                table: "ProveedoresProductos",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 3, 18, 22, 3, 9, 924, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 3, 18, 22, 3, 9, 924, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 3, 18, 22, 3, 9, 924, DateTimeKind.Local).AddTicks(6601));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioCompra",
                table: "ProveedoresProductos");

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 19, 9, 28, 957, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 19, 9, 28, 957, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 29, 19, 9, 28, 957, DateTimeKind.Local).AddTicks(3595));
        }
    }
}
