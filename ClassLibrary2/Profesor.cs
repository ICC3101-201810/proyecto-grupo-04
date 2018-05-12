using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Profesor : Persona
    {
        public string facultad { get; set; }

        public Profesor(string nombre, string apellido, string email, string facultad, string rut) : base(nombre, apellido, email, rut)
        {
            this.facultad = facultad;
        }
    }
}
