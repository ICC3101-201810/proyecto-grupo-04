using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Proyecto
{
    public abstract class Accesorio
    {

        public double precio;
        public int cantidad;

        public Accesorio(double miPrecio, int miCantidad)
        {
            precio = miPrecio;
            cantidad = miCantidad;
        }
        public virtual void Fragil()
        {

        }
    }
}
