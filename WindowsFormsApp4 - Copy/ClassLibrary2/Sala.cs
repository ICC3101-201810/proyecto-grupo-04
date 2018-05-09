using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Sala
    {
        public int ID { get; set; }
     
        
        public string Display
        {
            get
            {
                return string.Format("{0} - {1}", ID, "Biblioteca");
            }
        }
    }
}
