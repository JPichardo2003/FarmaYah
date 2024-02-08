using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string? Descripcion { get; set; }

        public int LaboratorioId { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "El campo {0} debe ser mayor que 0")]
        public float Precio { get; set; }
        public int Existencia { get; set; }
		[Required(ErrorMessage = "Este campo es Obligatorio")]
		public string? Unidad { get; set; }
    }
}
