﻿// <auto-generated />
using System;
using FarmaYah.Server.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240222203223_Agregando Unidad al OnMocreating")]
    partial class AgregandoUnidadalOnMocreating
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("FarmaYah.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Fidelidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Dirección = "Direccion 1",
                            Fidelidad = 7m,
                            Nombre = "Juan Perez",
                            Teléfono = "8094587412"
                        },
                        new
                        {
                            ClienteId = 2,
                            Dirección = "Direccion 2",
                            Fidelidad = 10m,
                            Nombre = "Maria Lopez",
                            Teléfono = "8091287602"
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Entregado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaPedida")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaRecibida")
                        .HasColumnType("TEXT");

                    b.Property<float>("MontoTotal")
                        .HasColumnType("REAL");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CompraId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.CuentasPorPagar", b =>
                {
                    b.Property<int>("CuentasPorPagarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .HasColumnType("TEXT");

                    b.Property<float>("Deuda")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("pago")
                        .HasColumnType("REAL");

                    b.HasKey("CuentasPorPagarId");

                    b.HasIndex("CompraId");

                    b.ToTable("CuentasPorPagar");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SucursalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            EmpleadoId = 1,
                            Nombre = "Julio",
                            SucursalId = 1
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Facturas", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientesClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Devolucion")
                        .HasColumnType("REAL");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("MontoTotal")
                        .HasColumnType("REAL");

                    b.Property<float>("Pago")
                        .HasColumnType("REAL");

                    b.Property<int?>("SeguroMedicoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SucursalId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacturaId");

                    b.HasIndex("ClientesClienteId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("SeguroMedicoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.FacturasDetalles", b =>
                {
                    b.Property<int>("FacturaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FacturaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacturaDetalleId");

                    b.HasIndex("FacturaId");

                    b.ToTable("FacturasDetalles");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Laboratorios", b =>
                {
                    b.Property<int>("LaboratorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LaboratorioId");

                    b.ToTable("Laboratorios");

                    b.HasData(
                        new
                        {
                            LaboratorioId = 1,
                            Direccion = "Direccion 1",
                            Nombre = "Pfizer"
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.PagosCuentasPorCobrar", b =>
                {
                    b.Property<int>("CuentasPorCobrarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .HasColumnType("TEXT");

                    b.Property<int>("FacturaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FormaDePago")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("CuentasPorCobrarId");

                    b.HasIndex("FacturaId");

                    b.ToTable("PagosCuentasPorCobrar");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LaboratorioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("UnidadId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.HasIndex("LaboratorioId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripcion = "Dolor de cabeza",
                            Eliminado = false,
                            Existencia = 0,
                            LaboratorioId = 1,
                            Nombre = "Ibuprofeno",
                            Precio = 100f,
                            UnidadId = 0
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.ProveedorProducto", b =>
                {
                    b.Property<int>("ProveedorProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProveedorProductoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("ProveedoresProductos");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Proveedores", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nota")
                        .HasColumnType("TEXT");

                    b.Property<string>("RNC")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoContribuyente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");

                    b.HasData(
                        new
                        {
                            ProveedorId = 1,
                            Categoria = "Nacional",
                            Direccion = "Direccion 1",
                            Eliminado = false,
                            Email = "Mamey@gmail.com",
                            Nombre = "mamey",
                            RNC = "123456789",
                            Telefono = "809-546-8915",
                            TipoContribuyente = "Persona Juridica"
                        },
                        new
                        {
                            ProveedorId = 2,
                            Categoria = "Internacional",
                            Direccion = "Direccion 2",
                            Eliminado = false,
                            Email = "Pfizer@gmail.com",
                            Nombre = "Pfizer",
                            RNC = "123456798",
                            Telefono = "809-546-8519",
                            TipoContribuyente = "Persona Juridica"
                        },
                        new
                        {
                            ProveedorId = 3,
                            Categoria = "Internacional",
                            Direccion = "Direccion 3",
                            Eliminado = false,
                            Email = "Bayer@gmail.com",
                            Nombre = "Bayer",
                            RNC = "123456897",
                            Telefono = "809-546-8195",
                            TipoContribuyente = "Persona Juridica"
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.SegurosMedicos", b =>
                {
                    b.Property<int>("SeguroMedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SeguroMedicoId");

                    b.ToTable("SegurosMedicos");

                    b.HasData(
                        new
                        {
                            SeguroMedicoId = 1,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 2, 22, 16, 32, 23, 589, DateTimeKind.Local).AddTicks(5795),
                            Nombre = "ARS Humano"
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.SegurosMedicosDetalles", b =>
                {
                    b.Property<int>("SeguroMedicoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Descuento")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeguroMedicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SeguroMedicoDetalleId");

                    b.HasIndex("SeguroMedicoId");

                    b.ToTable("SegurosMedicosDetalles");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Sucursales", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("EstadoOperativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SucursalId");

                    b.ToTable("Sucursales");

                    b.HasData(
                        new
                        {
                            SucursalId = 1,
                            Direccion = "Direccion 1",
                            EstadoOperativo = true,
                            Nombre = "Sucursal 1",
                            Telefono = "8094587412"
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Unidad", b =>
                {
                    b.Property<int>("UnidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UnidadId");

                    b.ToTable("Unidades");

                    b.HasData(
                        new
                        {
                            UnidadId = 1,
                            Descripcion = "Pastilla"
                        },
                        new
                        {
                            UnidadId = 2,
                            Descripcion = "Jarabe"
                        },
                        new
                        {
                            UnidadId = 3,
                            Descripcion = "Capsulas"
                        },
                        new
                        {
                            UnidadId = 4,
                            Descripcion = "Inyección"
                        },
                        new
                        {
                            UnidadId = 5,
                            Descripcion = "Crema"
                        },
                        new
                        {
                            UnidadId = 6,
                            Descripcion = "Supositorio"
                        },
                        new
                        {
                            UnidadId = 7,
                            Descripcion = "Gotas"
                        },
                        new
                        {
                            UnidadId = 8,
                            Descripcion = "Spray"
                        },
                        new
                        {
                            UnidadId = 9,
                            Descripcion = "Otros"
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.d_Compra", b =>
                {
                    b.Property<int>("d_CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LaboratorioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("d_CompraId");

                    b.HasIndex("CompraId");

                    b.ToTable("d_Compra");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.CuentasPorPagar", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Compras", null)
                        .WithMany("CuentasPorPagar")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Empleados", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Sucursales", null)
                        .WithMany("Empleados")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Facturas", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Clientes", null)
                        .WithMany("facturas")
                        .HasForeignKey("ClientesClienteId");

                    b.HasOne("FarmaYah.Shared.Models.Empleados", null)
                        .WithMany("Facturas")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmaYah.Shared.Models.SegurosMedicos", null)
                        .WithMany("Facturas")
                        .HasForeignKey("SeguroMedicoId");

                    b.HasOne("FarmaYah.Shared.Models.Sucursales", null)
                        .WithMany("Facturas")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.FacturasDetalles", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Facturas", null)
                        .WithMany("FacturasDetalles")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.PagosCuentasPorCobrar", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Facturas", null)
                        .WithMany("PagosCuentasPorCobrar")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Productos", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Laboratorios", null)
                        .WithMany("Productos")
                        .HasForeignKey("LaboratorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.ProveedorProducto", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Productos", null)
                        .WithMany("ProveedorProducto")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmaYah.Shared.Models.Proveedores", null)
                        .WithMany("ProveedorProducto")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.SegurosMedicosDetalles", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.SegurosMedicos", null)
                        .WithMany("SegurosMedicosDetalles")
                        .HasForeignKey("SeguroMedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.d_Compra", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Compras", null)
                        .WithMany("d_Compra")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Clientes", b =>
                {
                    b.Navigation("facturas");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Compras", b =>
                {
                    b.Navigation("CuentasPorPagar");

                    b.Navigation("d_Compra");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Empleados", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Facturas", b =>
                {
                    b.Navigation("FacturasDetalles");

                    b.Navigation("PagosCuentasPorCobrar");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Laboratorios", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Productos", b =>
                {
                    b.Navigation("ProveedorProducto");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Proveedores", b =>
                {
                    b.Navigation("ProveedorProducto");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.SegurosMedicos", b =>
                {
                    b.Navigation("Facturas");

                    b.Navigation("SegurosMedicosDetalles");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Sucursales", b =>
                {
                    b.Navigation("Empleados");

                    b.Navigation("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}
