using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Edificio
    {
        public string Nombre { get; set; }
        public List<Sala> salas { get; set; }
        public List<Sala> salasNo { get; set; }
        public List<Accesorio> accesoriosAlumno { get; set; }
        public List<Accesorio> accesoriosProfessor { get; set; }


        public Edificio()
        {
            salas = new List<Sala>();
            salasNo = new List<Sala>();
            accesoriosAlumno = new List<Accesorio>();
            accesoriosProfessor = new List<Accesorio>();

        }
    }
}
