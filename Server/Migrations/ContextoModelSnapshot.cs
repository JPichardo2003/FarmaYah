﻿// <auto-generated />
using System;
using FarmaYah.Server.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmaYah.Server.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

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

                    b.Property<float>("Devolucion")
                        .HasColumnType("REAL");

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

                    b.Property<float>("Cantidad")
                        .HasColumnType("REAL");

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

            modelBuilder.Entity("FarmaYah.Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                            Existencia = 0,
                            LaboratorioId = 1,
                            Nombre = "Ibuprofeno",
                            Precio = 100f,
                            UnidadId = 0
                        });
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.SegurosMedicos", b =>
                {
                    b.Property<int>("SeguroMedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SeguroMedicoId");

                    b.ToTable("SegurosMedicos");

                    b.HasData(
                        new
                        {
                            SeguroMedicoId = 1,
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

                    b.ToTable("Unidad");
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

            modelBuilder.Entity("FarmaYah.Shared.Models.Productos", b =>
                {
                    b.HasOne("FarmaYah.Shared.Models.Laboratorios", null)
                        .WithMany("Productos")
                        .HasForeignKey("LaboratorioId")
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

            modelBuilder.Entity("FarmaYah.Shared.Models.Empleados", b =>
                {
                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Facturas", b =>
                {
                    b.Navigation("FacturasDetalles");
                });

            modelBuilder.Entity("FarmaYah.Shared.Models.Laboratorios", b =>
                {
                    b.Navigation("Productos");
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
