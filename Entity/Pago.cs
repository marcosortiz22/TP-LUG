using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pago
    {
        public int NroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public decimal CantidadHoras { get; set; }

        public decimal ValorHora { get; set; }

        public decimal MontoPago { get; set; }
    }
}
