using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
	public class Unidad
	{
		[Key]
		public int UnidadId { get; set; }
		[Required(ErrorMessage = "Este campo es Obligatorio")]
		public string? Descripcion { get; set; }

        [ForeignKey("UnidadId")]
        public ICollection<Productos> Productos { get; set; } = new List<Productos>();
    }
}
