using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Laboratorios
    {
        [Key]
        public int LaboratorioId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string? Direccion { get; set; }

        [ForeignKey("LaboratorioId")]
        public ICollection<Productos> Productos { get; set; } = new List<Productos>();
    }
}
