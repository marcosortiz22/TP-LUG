using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Instructor
    {
        public int IdInstructor { get; set; }
        public int Dni { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Brevet { get; set; }

        public bool Activo { get; set; }
    }
}
