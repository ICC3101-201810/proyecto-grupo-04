using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Accesorio
    {
        public string nombre { get; set; }
        public int valor { get; set; }

        public string DisplayA
        {
            get
            {
                return string.Format("{0} - ${1}", nombre, valor);
            }
        }
    }
}
