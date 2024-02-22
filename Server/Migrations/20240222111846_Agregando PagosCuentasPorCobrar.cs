using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoPagosCuentasPorCobrar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PagosCuentasPorCobrar",
                columns: table => new
                {
                    CuentasPorCobrarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FormaDePago = table.Column<string>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: true),
                    Monto = table.Column<decimal>(type: "TEXT", nullable: false),
                    FacturaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosCuentasPorCobrar", x => x.CuentasPorCobrarId);
                    table.ForeignKey(
                        name: "FK_PagosCuentasPorCobrar_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 22, 7, 18, 46, 92, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.CreateIndex(
                name: "IX_PagosCuentasPorCobrar_FacturaId",
                table: "PagosCuentasPorCobrar",
                column: "FacturaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PagosCuentasPorCobrar");

            migrationBuilder.UpdateData(
                table: "SegurosMedicos",
                keyColumn: "SeguroMedicoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 2, 20, 15, 46, 55, 288, DateTimeKind.Local).AddTicks(4905));
        }
    }
}
