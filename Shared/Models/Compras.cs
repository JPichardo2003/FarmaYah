﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaYah.Shared.Models
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Tipo { get; set; }
        public float MontoTotal { get; set; }
        public DateTime FechaPedida { get; set; } = DateTime.Now;
        public DateTime FechaRecibida { get; set; }
        public bool Entregado { get; set; } = false;

        public bool Eliminado { get; set; } = false;
        [ForeignKey("CompraId")]
        public ICollection<d_Compra> d_Compra { get; set; } = new List<d_Compra>();

        [ForeignKey("CompraId")]
        public ICollection<CuentasPorPagar> CuentasPorPagar { get; set; } = new List<CuentasPorPagar>();
    }
}