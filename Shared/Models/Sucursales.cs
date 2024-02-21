using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Sucursales
    {
        [Key]
        public int SucursalId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el telefono correctamente, Ejemplo: 8094587412")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public bool EstadoOperativo { get; set; } = true;

        [ForeignKey("SucursalId")]
        public ICollection<Facturas> Facturas { get; set; } = new List<Facturas>();

        [ForeignKey("SucursalId")]
        public ICollection<Empleados> Empleados { get; set; } = new List<Empleados>();
    }
}
