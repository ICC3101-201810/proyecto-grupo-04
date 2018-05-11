using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Poo
{
    public class Notebook : Accesorio
    {
        public Notebook(double precio, int cantidad) : base(precio, cantidad)
        {
        }
        public override void Fragil()
        {
            Console.WriteLine("El usuario ha arrendado un computador, preocuparse que lo trate con cuidado");
        }
    }
}
