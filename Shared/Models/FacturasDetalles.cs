using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class FacturasDetalles
    {
        [Key]
        public int FacturaDetalleId { get; set; }

        public int FacturaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
    }
}
