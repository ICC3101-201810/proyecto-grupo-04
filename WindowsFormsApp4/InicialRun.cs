using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ClassLibrary2;

namespace WindowsFormsApp4
{
    public partial class InicialRun : Form
    {
        Thread th;
        public static List<Credencial> credenciales;
        public static List<Persona> personas;
        public Edificio edificio;
        public Persona currentUser;
        public int contadorSala=0;
   
        public InicialRun()
        {
            InitializeComponent();
            credenciales = new List<Credencial>();
            personas = new List<Persona>();
            edificio = new Edificio();
            currentUser = new Persona();
            setupData();
        }

        private void openLogin()
        {
            Application.Run(new Login(credenciales, personas, edificio, currentUser,contadorSala));
        }

        private void setupData()
        {
            credenciales.Add(new Credencial("alumno", "pass", "ALUMNO", "112223334"));
            credenciales.Add(new Credencial("admin", "passs", "ADMIN", "223334445"));

            personas.Add(new Estudiante { nombre = "Sebastian", apellido = "Gonzalez", email = "slgonzalez@miuandes.cl", carrera = "Ingenieria", rut = "112223334",cargo="ALUMNO"});
            personas.Add(new Persona { nombre = "Exequiel", apellido = "Vial", email = "ejvial@miuandes", rut = "223334445" });

            for (;contadorSala<6;contadorSala++)
            {
                edificio.salas.Add(new Sala { ID = contadorSala });
            }

            edificio.salasNo.Add(new Sala { ID = 78 });
            edificio.salasNo.Add(new Sala { ID = 98 });
            edificio.salasNo.Add(new Sala { ID = 28 });
            edificio.salasNo.Add(new Sala { ID = 88 });



            edificio.accesoriosAlumno.Add(new Accesorio { nombre = "Computador", valor = 2000 });
            edificio.accesoriosAlumno.Add(new Accesorio { nombre = "Plumon", valor = 1000 });
            edificio.accesoriosAlumno.Add(new Accesorio { nombre = "Pizzara", valor = 500 });
            edificio.accesoriosAlumno.Add(new Accesorio { nombre = "Pizza", valor = 10000 });

            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Computador", valor = 1000 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Plumon", valor = 100 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Pizarra", valor = 500 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Pizza", valor = 9990 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Tele", valor = 500 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Redbull", valor = 990 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "Alexa", valor= 1000 });
            edificio.accesoriosProfessor.Add(new Accesorio { nombre = "PS4", valor = 1500 });
            edificio.Nombre = "Biblioteca";

            currentUser = new Persona();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
