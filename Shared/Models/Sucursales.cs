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
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Ingrese el RNC correctamente, Ejemplo: 101010101")]
        public string? RNC { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Escriba el teléfono correctamente xxx-xxx-xxxx")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public bool EstadoOperativo { get; set; } = true;

        [ForeignKey("SucursalId")]
        public ICollection<Facturas> Facturas { get; set; } = new List<Facturas>();

        [ForeignKey("SucursalId")]
        public ICollection<Empleados> Empleados { get; set; } = new List<Empleados>();
    }
}
