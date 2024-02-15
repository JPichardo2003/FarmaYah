using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class ProveedorProducto
    {
        [Key]
        public int ProveedorProductoId { get; set; }
        public int ProveedorId { get; set; }
        //public Proveedores? Proveedor { get; set; }
        public int ProductoId { get; set; }
        //public Productos? Producto { get; set; }
    }
}
