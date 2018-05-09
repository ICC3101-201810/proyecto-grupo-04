using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Estudiante : Persona
    {
      
        public string nombre { get; set; }
        public string appellido { get; set; }
        public string carrera{ get; set; }

        public Estudiante(string nombre, string apellido, string email, string carrera, Credencial credencial) : base(nombre, apellido, email, credencial)
        {
            this.carrera = carrera;

        }
    }
}
