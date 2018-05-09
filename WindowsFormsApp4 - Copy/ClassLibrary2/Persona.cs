using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public Credencial credencial {get; set;}

        public Persona(string nombre, string apellido, string email, Credencial credencial)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.credencial = credencial;
        }
    }
}
