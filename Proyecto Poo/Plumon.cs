using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Poo
{
    public class Plumon : Accesorio
    {
        string color;
        public Plumon(double precio, int cantidad, string miColor) : base(precio, cantidad)
        {
            color = miColor;
        }
        public override void Fragil()
        {
            Console.WriteLine("El usuario ha arrendado un plumón, vigilar que no lo pierda");
        }
    }
}
