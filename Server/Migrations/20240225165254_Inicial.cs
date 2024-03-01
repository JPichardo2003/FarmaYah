using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClientesClienteId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_ClientesClienteId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "ClientesClienteId",
                table: "Facturas");

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 25, 12, 52, 54, 415, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 25, 12, 52, 54, 415, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 25, 12, 52, 54, 415, DateTimeKind.Local).AddTicks(158));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientesClienteId",
                table: "Facturas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 25, 12, 46, 11, 96, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 2, 25, 12, 46, 11, 96, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 2, 25, 12, 46, 11, 96, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClientesClienteId",
                table: "Facturas",
                column: "ClientesClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClientesClienteId",
                table: "Facturas",
                column: "ClientesClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId");
        }
    }
}
