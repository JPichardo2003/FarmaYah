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
		[Range(1, int.MaxValue, ErrorMessage = "Este campo es Obligatorio")]
		public int LaboratorioId { get; set; }

        [Range(1, float.MaxValue, ErrorMessage = "El campo {0} debe ser mayor que 0")]
        public float Precio { get; set; }
        public bool Eliminado { get; set; } = false;
        public int Existencia { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Este campo es Obligatorio")]
		public int UnidadId { get; set; }
        [ForeignKey("ProductoId")]
        public ICollection<ProveedorProducto> ProveedorProducto { get; set; } = new List<ProveedorProducto>();
    }
}
