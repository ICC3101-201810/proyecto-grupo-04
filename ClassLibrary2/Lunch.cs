using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Lunch
    {
        public static List<Credencial> credenciales = new List<Credencial>();
        public static List<Persona> personas = new List<Persona>();

        Credencial credencial= new Credencial("slgonzalez@miuandes.cl", "pass", "ALUMNO","195672229");
        Persona usuario = new Estudiante("Sebastian", "Gonzalez", "slgonzalez@miuandes.cl", "Ingenieria", "195672229");

        

        public List<Credencial> GetListCredenciales()
        {
            return credenciales;
        }
        public List<Persona> GetListUsuarios()
        {
            return personas;
        }

    }
}
