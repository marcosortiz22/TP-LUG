using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Aeronave
    {
        public string Matricula { get; set; }
       

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public decimal Revision100Hs { get; set; }
        public DateTime FechaRevisionAnual { get; set; }
        public bool Activo { get; set; }
    }
}
