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
            Application.Run(new Login(credenciales, personas, edificio, currentUser));
        }

        private void setupData()
        {
            credenciales.Add(new Credencial("alumno", "pass", "ALUMNO", "112223334"));
            credenciales.Add(new Credencial("admin", "pass", "ADMIN", "223334445"));

            personas.Add(new Estudiante { nombre = "Sebastian", apellido = "Gonzalez", email = "slgonzalez@miuandes.cl", carrera = "Ingenieria", rut = "112223334" });
            personas.Add(new Persona { nombre = "Exequiel", apellido = "Vial", email = "ejvial@miuandes", rut = "223334445" });

            edificio.salas.Add(new Sala { ID = 2001 });
            edificio.salas.Add(new Sala { ID = 2002 });
            edificio.salas.Add(new Sala { ID = 2003 });
            edificio.salas.Add(new Sala { ID = 2004 });
            edificio.salas.Add(new Sala { ID = 2005 });
            edificio.salas.Add(new Sala { ID = 2006 });

            edificio.accesorios.Add(new Accesorio { nombre = "Computador", valor = 2000 });
            edificio.accesorios.Add(new Accesorio { nombre = "Plumon", valor = 1000 });
            edificio.accesorios.Add(new Accesorio { nombre = "Pizzara", valor = 500 });
            edificio.accesorios.Add(new Accesorio { nombre = "Pizza", valor = 10000 });

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
