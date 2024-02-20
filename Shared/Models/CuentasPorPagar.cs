using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class CuentasPorPagar
    {
        [Key]   
        public int CuentasPorPagarId { get; set; }

        [Range(1, float.MaxValue, ErrorMessage = "El pago no puede ser negativo")]
        public float pago { get; set; }
        public float Deuda { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string? Concepto { get; set; }

        public int CompraId { get; set; }
    }
}
