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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            personas.Add(new Estudiante { nombre = "Sebastian", apellido = "Gonzalez", email = "erriveros@miuandes.cl", carrera = "Ingenieria", rut = "112223334",cargo="ALUMNO"});
            personas.Add(new Persona { nombre = "Exequiel", apellido = "Vial", email = "ejvial@miuandes", rut = "223334445" });

            for (;contadorSala<6;contadorSala++)
            {
                edificio.salas.Add(new Sala { ID = contadorSala });
            }



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
            BinaryFormatter formatter = new BinaryFormatter();
            Stream mistream = new FileStream("Personas.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistream.Length != 0 )
            {
                personas = (List<Persona>)formatter.Deserialize(mistream);
            }
            mistream.Close();
            BinaryFormatter formatter1 = new BinaryFormatter();
            Stream mistreamc = new FileStream("Credenciales.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistreamc.Length != 0)
            {
                credenciales = (List<Credencial>)formatter1.Deserialize(mistreamc);
            }
            mistreamc.Close();

            BinaryFormatter formattere = new BinaryFormatter();
            Stream mistreame = new FileStream("Edificios.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistreame.Length != 0)
            {
                edificio = (Edificio)formatter1.Deserialize(mistreame);
            }
            mistreame.Close();


            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
