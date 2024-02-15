using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoentidadProveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preedores",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false),
                    RNC = table.Column<string>(type: "TEXT", nullable: true),
                    TipoContribuyente = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preedores", x => x.ProveedorId);
                });

            migrationBuilder.InsertData(
                table: "Preedores",
                columns: new[] { "ProveedorId", "Categoria", "Direccion", "Email", "Nombre", "RNC", "Telefono", "TipoContribuyente" },
                values: new object[,]
                {
                    { 1, "Nacional", "Direccion 1", "Mamey@gmail.com", "mamey", "123456789", "809-546-8915", "Persona Juridica" },
                    { 2, "Internacional", "Direccion 2", "Pfizer@gmail.com", "Pfizer", "123456798", "809-546-8519", "Persona Juridica" },
                    { 3, "Internacional", "Direccion 3", "Bayer@gmail.com", "Bayer", "123456897", "809-546-8195", "Persona Juridica" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preedores");
        }
    }
}
