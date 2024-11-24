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

        public void CalcularMonto(decimal cantidadHoras, decimal valorHora)
        {
            if (cantidadHoras < 0 || valorHora < 0)
            {
                throw new InvalidOperationException("Cantidad de horas y valor por hora no pueden ser negativos.");
            }

             MontoPago = cantidadHoras * valorHora;
        }
    }
}

