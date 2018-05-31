using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [Serializable]
    public class Sala
    {
        public int ID { get; set; }
        public string Rut { get; set; }
     
        
        public string Display
        {
            get
            {
                return string.Format("{0} - {1}", ID, "Biblioteca");
            }
        }

        public string DisplayAdmin
        {
            get
            {
                return string.Format("{0} - {1}, Rut {2}", ID, "Biblioteca",Rut);
            }
        }
    }
}
