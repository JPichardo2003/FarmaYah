using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoatrinbutoEliminadoaproveedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Preedores",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Preedores",
                keyColumn: "ProveedorId",
                keyValue: 1,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Preedores",
                keyColumn: "ProveedorId",
                keyValue: 2,
                column: "Eliminado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Preedores",
                keyColumn: "ProveedorId",
                keyValue: 3,
                column: "Eliminado",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Preedores");
        }
    }
}
