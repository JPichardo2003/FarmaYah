using FarmaYah.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmaYah.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<FacturasDetalles> FacturasDetalles { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Laboratorios> Laboratorios { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }
        public DbSet<SegurosMedicos> SegurosMedicos { get; set; }
        public DbSet<SegurosMedicosDetalles> SegurosMedicosDetalles { get; set; }
        public DbSet<Unidad> Unidad { get; set; }
        public DbSet<Proveedores> Preedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empleados>().HasData(new List<Empleados>()
            {
                new Empleados(){EmpleadoId=1, Nombre="Julio", SucursalId = 1}
            });

            modelBuilder.Entity<Laboratorios>().HasData(new List<Laboratorios>()
            {
                new Laboratorios(){LaboratorioId=1, Nombre="Pfizer", Direccion="Direccion 1"}
            });

            modelBuilder.Entity<Sucursales>().HasData(new List<Sucursales>()
            {
                new Sucursales(){SucursalId=1, Nombre="Sucursal 1", Direccion="Direccion 1", Telefono="8094587412", EstadoOperativo=true}
            });

            modelBuilder.Entity<SegurosMedicos>().HasData(new List<SegurosMedicos>()
            {
                new SegurosMedicos(){SeguroMedicoId=1, Nombre="ARS Humano"}
            });

            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                new Productos(){ProductoId=1, Nombre="Ibuprofeno", Precio=100, LaboratorioId=1, Existencia = 0, Descripcion = "Dolor de cabeza"}
            });

            modelBuilder.Entity<Proveedores>().HasData(new List<Proveedores>()
            {
                new Proveedores(){ProveedorId = 1, Nombre = "mamey", Email="Mamey@gmail.com", Categoria="Nacional", RNC="123456789", TipoContribuyente="Persona Juridica", Direccion="Direccion 1", Telefono="809-546-8915"},
                new Proveedores(){ProveedorId = 2, Nombre = "Pfizer", Email="Pfizer@gmail.com", Categoria="Internacional", RNC="123456798", TipoContribuyente="Persona Juridica", Direccion="Direccion 2", Telefono="809-546-8519"},
                new Proveedores(){ProveedorId = 3, Nombre = "Bayer", Email="Bayer@gmail.com", Categoria="Internacional", RNC="123456897", TipoContribuyente="Persona Juridica", Direccion="Direccion 3", Telefono="809-546-8195"},
            });
        }
    }
}
