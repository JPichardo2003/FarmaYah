using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmaYah.Server.Migrations
{
    /// <inheritdoc />
    public partial class SuarezGrupo3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Fidelidad = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    MontoTotal = table.Column<float>(type: "REAL", nullable: false),
                    FechaPedida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaRecibida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Entregado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "Laboratorios",
                columns: table => new
                {
                    LaboratorioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorios", x => x.LaboratorioId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
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
                    TipoContribuyente = table.Column<string>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Nota = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedorId);
                });

            migrationBuilder.CreateTable(
                name: "SegurosMedicos",
                columns: table => new
                {
                    SeguroMedicoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegurosMedicos", x => x.SeguroMedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    SucursalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    EstadoOperativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.SucursalId);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    UnidadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.UnidadId);
                });

            migrationBuilder.CreateTable(
                name: "CuentasPorPagar",
                columns: table => new
                {
                    CuentasPorPagarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pago = table.Column<float>(type: "REAL", nullable: false),
                    Deuda = table.Column<float>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: true),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasPorPagar", x => x.CuentasPorPagarId);
                    table.ForeignKey(
                        name: "FK_CuentasPorPagar_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "d_Compra",
                columns: table => new
                {
                    d_CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    LaboratorioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_d_Compra", x => x.d_CompraId);
                    table.ForeignKey(
                        name: "FK_d_Compra_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    LaboratorioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<float>(type: "REAL", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: false),
                    UnidadId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Laboratorios_LaboratorioId",
                        column: x => x.LaboratorioId,
                        principalTable: "Laboratorios",
                        principalColumn: "LaboratorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SegurosMedicosDetalles",
                columns: table => new
                {
                    SeguroMedicoDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    SeguroMedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descuento = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegurosMedicosDetalles", x => x.SeguroMedicoDetalleId);
                    table.ForeignKey(
                        name: "FK_SegurosMedicosDetalles_SegurosMedicos_SeguroMedicoId",
                        column: x => x.SeguroMedicoId,
                        principalTable: "SegurosMedicos",
                        principalColumn: "SeguroMedicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    SucursalId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProveedoresProductos",
                columns: table => new
                {
                    ProveedorProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedoresProductos", x => x.ProveedorProductoId);
                    table.ForeignKey(
                        name: "FK_ProveedoresProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProveedoresProductos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "ProveedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SeguroMedicoId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    SucursalId = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: true),
                    Devolucion = table.Column<float>(type: "REAL", nullable: false),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Pago = table.Column<float>(type: "REAL", nullable: false),
                    MontoTotal = table.Column<float>(type: "REAL", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientesClienteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_ClientesClienteId",
                        column: x => x.ClientesClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId");
                    table.ForeignKey(
                        name: "FK_Facturas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_SegurosMedicos_SeguroMedicoId",
                        column: x => x.SeguroMedicoId,
                        principalTable: "SegurosMedicos",
                        principalColumn: "SeguroMedicoId");
                    table.ForeignKey(
                        name: "FK_Facturas_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacturasDetalles",
                columns: table => new
                {
                    FacturaDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacturaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasDetalles", x => x.FacturaDetalleId);
                    table.ForeignKey(
                        name: "FK_FacturasDetalles_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Dirección", "Fidelidad", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Direccion 1", 7m, "Juan Perez", "8094587412" },
                    { 2, "Direccion 2", 10m, "Maria Lopez", "8091287602" }
                });

            migrationBuilder.InsertData(
                table: "Laboratorios",
                columns: new[] { "LaboratorioId", "Direccion", "Nombre" },
                values: new object[] { 1, "Direccion 1", "Pfizer" });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "ProveedorId", "Categoria", "Direccion", "Eliminado", "Email", "Nombre", "Nota", "RNC", "Telefono", "TipoContribuyente" },
                values: new object[,]
                {
                    { 1, "Nacional", "Direccion 1", false, "Mamey@gmail.com", "mamey", null, "123456789", "809-546-8915", "Persona Juridica" },
                    { 2, "Internacional", "Direccion 2", false, "Pfizer@gmail.com", "Pfizer", null, "123456798", "809-546-8519", "Persona Juridica" },
                    { 3, "Internacional", "Direccion 3", false, "Bayer@gmail.com", "Bayer", null, "123456897", "809-546-8195", "Persona Juridica" }
                });

            migrationBuilder.InsertData(
                table: "SegurosMedicos",
                columns: new[] { "SeguroMedicoId", "Eliminado", "Fecha", "Nombre" },
                values: new object[] { 1, false, new DateTime(2024, 2, 20, 15, 46, 55, 288, DateTimeKind.Local).AddTicks(4905), "ARS Humano" });

            migrationBuilder.InsertData(
                table: "Sucursales",
                columns: new[] { "SucursalId", "Direccion", "EstadoOperativo", "Nombre", "Telefono" },
                values: new object[] { 1, "Direccion 1", true, "Sucursal 1", "8094587412" });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Nombre", "SucursalId" },
                values: new object[] { 1, "Julio", 1 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Descripcion", "Eliminado", "Existencia", "LaboratorioId", "Nombre", "Precio", "UnidadId" },
                values: new object[] { 1, "Dolor de cabeza", false, 0, 1, "Ibuprofeno", 100f, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_CuentasPorPagar_CompraId",
                table: "CuentasPorPagar",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_d_Compra_CompraId",
                table: "d_Compra",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClientesClienteId",
                table: "Facturas",
                column: "ClientesClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_EmpleadoId",
                table: "Facturas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_SeguroMedicoId",
                table: "Facturas",
                column: "SeguroMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_SucursalId",
                table: "Facturas",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasDetalles_FacturaId",
                table: "FacturasDetalles",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_LaboratorioId",
                table: "Productos",
                column: "LaboratorioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedoresProductos_ProductoId",
                table: "ProveedoresProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProveedoresProductos_ProveedorId",
                table: "ProveedoresProductos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_SegurosMedicosDetalles_SeguroMedicoId",
                table: "SegurosMedicosDetalles",
                column: "SeguroMedicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentasPorPagar");

            migrationBuilder.DropTable(
                name: "d_Compra");

            migrationBuilder.DropTable(
                name: "FacturasDetalles");

            migrationBuilder.DropTable(
                name: "ProveedoresProductos");

            migrationBuilder.DropTable(
                name: "SegurosMedicosDetalles");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "SegurosMedicos");

            migrationBuilder.DropTable(
                name: "Laboratorios");

            migrationBuilder.DropTable(
                name: "Sucursales");
        }
    }
}
