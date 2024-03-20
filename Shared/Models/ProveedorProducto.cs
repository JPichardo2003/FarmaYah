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
        public int ProductoId { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="El precio de compra debe ser mayor a 0")]
        public decimal PrecioCompra { get; set; }
    }
}
