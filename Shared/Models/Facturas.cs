using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int? SeguroMedicoId { get; set; }

        public int EmpleadoId { get; set; }

        public int SucursalId { get; set; }

        public string? Estado { get; set; }

        public float Devolucion { get; set; }

        public float? CoberturaSeguro { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "El pago no puede ser negativo")]
        public float Pago { get; set; }
        public float MontoTotal { get; set; }

        [ForeignKey("FacturaId")]
        public ICollection<FacturasDetalles> FacturasDetalles { get; set; } = new List<FacturasDetalles>();

    }
}
