using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
	public class Clientes
	{
		[Key]
		public int ClienteId { get; set; }

		[Required(ErrorMessage = "El nombre es obligatorio")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios")]
		public string? Nombre { get; set; }

		[Required(ErrorMessage = "La cedula es obligatoria")]
        [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "Escriba la cedula correctamente xxx-xxxxxxx-x")]
        public string? Cedula { get; set; }
        public int? SeguroMedicoId { get; set; }
		
		[RegularExpression(@"^\d{9}$", ErrorMessage = "El número de seguro médico debe tener 9 dígitos")]
		public string? NumSeguroMedico { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria")]
		public string? Dirección { get; set; }

		[Required(ErrorMessage = "El teléfono es obligatorio")]
		[RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Escriba el teléfono correctamente xxx-xxx-xxxx")]
		public string? Teléfono { get; set; }
		public decimal? Fidelidad { get; set; } = 0;

		public bool Eliminado { get; set; } = false;

        [ForeignKey("ClienteId")]
        public ICollection<Facturas> Facturas { get; set; } = new List<Facturas>();
    }
}
