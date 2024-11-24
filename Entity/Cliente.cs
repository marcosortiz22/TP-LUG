using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public int  IdCliente { get; set; }
        public int Dni { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Telefono { get; set; }
        public string TelefonoEmergencia { get; set; }

        public string Email { get; set; }

        public string Brevet { get; set; }

        public decimal SaldoHoras { get; set; }

        public bool Activo { get; set; }


        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }

    }
}
