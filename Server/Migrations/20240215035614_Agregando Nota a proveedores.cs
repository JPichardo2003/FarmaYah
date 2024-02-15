using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoNotaaproveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nota",
                table: "Preedores",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Preedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Nota",
                value: null);

            migrationBuilder.UpdateData(
                table: "Preedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Nota",
                value: null);

            migrationBuilder.UpdateData(
                table: "Preedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Nota",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Preedores");
        }
    }
}
