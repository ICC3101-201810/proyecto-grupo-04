using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string rut { get; set; }
        public string cargo { get; set; }


        public string DisplayAlumno
        {
            get
            {
                return string.Format("{0} - {1}", nombre, rut);
            }
        }
    }
}
