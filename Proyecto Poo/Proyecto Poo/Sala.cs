using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Poo
{
    public class Sala
    {
        public int ID, capacidadGente;
        public bool disponibilidad;
        public Persona quienArrendo;

        public Sala(int miID, int miCapacidadGente, bool miDisponibilidad)
        {
            ID = miID;
            capacidadGente = miCapacidadGente;
            disponibilidad = miDisponibilidad;
        }
    }
}
