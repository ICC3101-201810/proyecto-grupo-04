using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Estudiante : Persona
    {
        public string carrera{ get; set; }

        public Estudiante(string nombre, string apellido, string email, string carrera, string rut) : base(nombre, apellido, email, rut)
        {
            this.carrera = carrera;
        }
    }
}
