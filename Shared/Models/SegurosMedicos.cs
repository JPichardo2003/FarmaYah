using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class SegurosMedicos
    {
        [Key]
        public int SeguroMedicoId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Nombre { get; set; }

        [ForeignKey("SeguroMedicoId")]
        public ICollection<SegurosMedicosDetalles> SegurosMedicosDetalles { get; set; } = new List<SegurosMedicosDetalles>();

        [ForeignKey("SeguroMedicoId")]
        public ICollection<Facturas> Facturas { get; set; } = new List<Facturas>();

    }
}
