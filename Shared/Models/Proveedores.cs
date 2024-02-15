using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Categoria { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Este campo solo acepta números")]
        public string? RNC { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? TipoContribuyente { get; set; }
        public string? Nota { get; set; }
        [ForeignKey("ProveedorId")]
        public ICollection<ProveedorProducto> ProveedorProducto { get; set; } = new List<ProveedorProducto>();
    }
}
