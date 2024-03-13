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
        public DbSet<Compras> Compras { get; set; }
        public DbSet<d_Compra> d_Compra { get; set; }
        public DbSet<CuentasPorPagar> CuentasPorPagar { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<ProveedorProducto> ProveedoresProductos { get; set; }
        public DbSet<PagosCuentasPorCobrar> PagosCuentasPorCobrar { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Mermas> Mermas { get; set; }
        public DbSet<Averias> Averias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empleados>().HasData(new List<Empleados>()
            {
                new Empleados(){EmpleadoId=1, Nombre="Julio", SucursalId = 1, Telefono="829-487-1203", Direccion="Yaguiza"},
                new Empleados(){EmpleadoId=2, Nombre="Alexander", SucursalId = 2, Telefono="827-478-3917", Direccion ="Los Cocos"}
            });

            modelBuilder.Entity<Clientes>().HasData(new List<Clientes>()
            {
                new Clientes(){ClienteId=1, Nombre="Juan Perez", Cedula="402-3257845-9", Dirección="Direccion 1", Teléfono="8094587412", Fidelidad=7, SeguroMedicoId =1, NumSeguroMedico="123456789"},
                new Clientes(){ClienteId=2, Nombre="Maria Lopez", Cedula="055-0004578-9", Dirección="Direccion 2", Teléfono="8091287602", Fidelidad=10, SeguroMedicoId = 3, NumSeguroMedico = "012345678"}

            });

            modelBuilder.Entity<Laboratorios>().HasData(new List<Laboratorios>()
            {
                new Laboratorios(){LaboratorioId=1, Nombre="Pfizer", Direccion="Direccion 1"},
                new Laboratorios(){LaboratorioId=2, Nombre="Bayer", Direccion="Direccion 2"}
            });

            modelBuilder.Entity<Sucursales>().HasData(new List<Sucursales>()
            {
                new Sucursales(){SucursalId=1, Nombre="McCaffe", Direccion="Libertad", Telefono="8094587412", EstadoOperativo=true, RNC="402456782"},
                new Sucursales(){SucursalId=2, Nombre="Pharma King", Direccion="New York", Telefono="8094587413", EstadoOperativo=true, RNC= "402456783"}
            });

            modelBuilder.Entity<SegurosMedicos>().HasData(new List<SegurosMedicos>()
            {
                new SegurosMedicos(){SeguroMedicoId=1, Nombre="ARS Humano"},
                new SegurosMedicos(){SeguroMedicoId=2, Nombre="ARS Palic"},
                new SegurosMedicos(){SeguroMedicoId=3, Nombre="ARS Universal"}
            });

            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                new Productos(){ProductoId=1, Nombre="Ibuprofeno", Precio=100, LaboratorioId=1, Existencia = 0, Descripcion = "TBA", UnidadId=3, Reordenable = true},
                new Productos(){ProductoId=2, Nombre="Paracetamol", Precio=120, LaboratorioId=1, Existencia = 0, Descripcion = "TBA", UnidadId=4, Reordenable = false},
                new Productos(){ProductoId=3, Nombre="Amoxicilina", Precio=150, LaboratorioId=1, Existencia = 0, Descripcion = "TBA", UnidadId = 3, Reordenable = true}
            });

            modelBuilder.Entity<Proveedores>().HasData(new List<Proveedores>()
            {
                new Proveedores(){ProveedorId = 1, Nombre = "mamey", Email="Mamey@gmail.com", Categoria="Nacional", RNC="123456789", TipoContribuyente="Persona Juridica", Direccion="Direccion 1", Telefono="809-546-8915"},
                new Proveedores(){ProveedorId = 2, Nombre = "Pfizer", Email="Pfizer@gmail.com", Categoria="Internacional", RNC="123456798", TipoContribuyente="Persona Juridica", Direccion="Direccion 2", Telefono="809-546-8519"},
                new Proveedores(){ProveedorId = 3, Nombre = "Bayer", Email="Bayer@gmail.com", Categoria="Internacional", RNC="123456897", TipoContribuyente="Persona Juridica", Direccion="Direccion 3", Telefono="809-546-8195"},
            });
            modelBuilder.Entity<Unidad>().HasData(new List<Unidad>()
             {
                 new Unidad(){UnidadId = 1, Descripcion="Pastilla" },
                 new Unidad(){UnidadId = 2, Descripcion="Jarabe" },
                 new Unidad(){UnidadId = 3, Descripcion="Capsulas" },
                 new Unidad(){UnidadId = 4, Descripcion="Inyección" },
                 new Unidad(){UnidadId = 5, Descripcion="Crema" },
                 new Unidad(){UnidadId = 6, Descripcion="Supositorio" },
                 new Unidad(){UnidadId = 7, Descripcion="Gotas" },
                 new Unidad(){UnidadId = 8, Descripcion="Spray" },
                 new Unidad(){UnidadId = 9, Descripcion="Otros" }
             });

            modelBuilder.Entity<Configuracion>().HasData(new List<Configuracion>()
            {
                new Configuracion(){ConfiguracionId = 1, ReOrden = false}

            });

        }
    }
}
