using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]

        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Escriba el teléfono correctamente xxx-xxx-xxxx")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int SucursalId { get; set; }
        public bool Eliminado { get; set; } = false;

        [ForeignKey("EmpleadoId")]
        public ICollection<Facturas> Facturas { get; set; } = new List<Facturas>();
    }
}
