using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class SegurosMedicosDetalles
    {
        [Key]   
        public int SeguroMedicoDetalleId { get; set; }

        public int ProductoId { get; set; }

        public int SeguroMedicoId { get; set; }

        public float Descuento { get; set; }
    }
}
