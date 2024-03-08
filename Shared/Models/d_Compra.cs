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

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public int Cantidad { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public float Precio { get; set; }
        public int CompraId { get; set; }

        public int proveedorId { get; set; }

    }
}