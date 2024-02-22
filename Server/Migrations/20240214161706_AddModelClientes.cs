using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddModelClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Facturas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fidelidad",
                table: "Clientes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Dirección", "Fidelidad", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Direccion 1", 0, "Juan Perez", "8094587412" },
                    { 2, "Direccion 2", 0, "Maria Lopez", "8091287602" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Fidelidad",
                table: "Clientes");
        }
    }
}
