using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Averias
    {
        [Key]
        public int AveriaId { get; set; }
        [ForeignKey("ProductoId")]
        public int ProductoId { get; set; }
        [ForeignKey("MermaId")]
        public int MermaId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string? Motivo { get; set; }
        public string? Observaciones { get; set; }

        public bool Activo { get; set; } = true;
        public bool huboRembolso { get; set; } = false;
    }
}
