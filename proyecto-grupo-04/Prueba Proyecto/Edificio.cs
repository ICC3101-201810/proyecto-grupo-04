using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Proyecto
{
    public class Edificio
    {
        public string nombreEdificio;
        public List<Sala> salasDisponibles = new List<Sala>();
        public List<Sala> salasNoDisponibles = new List<Sala>();
        public List<Accesorio> accesoriosEdificio = new List<Accesorio>();
        public Edificio(List<Sala> miSalasDisp, string miNombreEdificio, List<Sala> salasNoDisponibles)
        {
            nombreEdificio = miNombreEdificio;
            salasDisponibles = miSalasDisp;
            salasNoDisponibles = miSalasNoDisp;
        }
        public bool ConfirmarDisponibilidad(Sala salac)
        {
            return (salasDisponibles.Contains(salac));

        }
        public bool ConfirmarNoisponibilidad(Sala salac)
        {
            return (salasDisponibles.Contains(salac));

        }

        public void MostrarSalas()
        {
            Console.WriteLine("El ID de las salas disponibles de " + nombreEdificio + " son:");
            foreach (Sala ssala in salasDisponibles)
            {
                Console.WriteLine(ssala.ID);
            }
        }
        public void MostrarAccesorios()
        {
            Console.WriteLine("Los accesorios disponibles del " + nombreEdificio + " son:");
            foreach (Accesorio a in accesoriosEdificio)
            {
                Console.WriteLine(a.GetType().Name);
            }
        }

        public void MostrarSalasNoDisponibles()
        {
            Console.WriteLine("El ID de las salas no disponibles de " + nombreEdificio + " son:");
            foreach (Sala ssala in salasNoDisponibles)
            {
                Console.WriteLine(ssala.ID);
            }
        }
    }
}
