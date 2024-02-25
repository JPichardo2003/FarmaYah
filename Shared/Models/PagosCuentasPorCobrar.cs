using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class PagosCuentasPorCobrar
    {
        [Key]
        public int CuentasPorCobrarId { get; set; }
        [Required(ErrorMessage = "La forma de pago es requerida")]
        public string? FormaDePago { get; set; }
        public string? Concepto { get; set; }
        [Range(1, float.MaxValue, ErrorMessage = "El pago no puede ser negativo")]
        public decimal Monto { get; set; }
        public int FacturaId;
    }
}
