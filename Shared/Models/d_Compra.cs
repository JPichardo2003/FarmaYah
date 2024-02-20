using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class d_Compra
    {
        [Key]
        public int d_CompraId { get; set; }
        public int ProductoId { get; set; }
        public int LaboratorioId { get; set; }
        public int Cantidad { get; set; }
        public int CompraId { get; set; }


    }
}
