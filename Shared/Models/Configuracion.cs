using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Configuracion
    {
        [Key]
        public int ConfiguracionId { get; set; }

        public bool ReOrden { get; set; } = false;
    }
}
