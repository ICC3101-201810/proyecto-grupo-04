using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Proyecto
{
    public class Ariendo
    {
        public Persona persona;
        public Sala sala;
        public DateTime tiempoFinal;
        public DateTime tiempoInicial;
        List<Accesorio> accesorios;
        public Ariendo(Persona miPersona, Sala miSala, DateTime miFinal, DateTime miTiempoInicial, List<Accesorio> miAccesorios)
        {
            persona = miPersona;
            sala = miSala;
            tiempoFinal = miFinal;
            tiempoInicial = miTiempoInicial;
            accesorios = miAccesorios;
        }

    }
}
