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
        public static List<ClassLibrary2.Credencial> credenciales = new List<ClassLibrary2.Credencial>();
        public List<ClassLibrary2.Persona> personas = new List<ClassLibrary2.Persona>();
        public InicialRun()
        {
            InitializeComponent();
            setupData();
        }

        private void openLogin()
        {
            Application.Run(new Login(credenciales, personas));
        }

        private void setupData()
        {
            credenciales.Add(new ClassLibrary2.Credencial("alumno", "pass", "ALUMNO", "112223334"));
            credenciales.Add(new ClassLibrary2.Credencial("admin", "pass", "ADMIN", "223334445"));

            personas.Add(new ClassLibrary2.Estudiante("Sebastian", "Gonzalez", "slgonzalez@miuandes.cl", "Ingenieria", "112223334"));
            personas.Add(new ClassLibrary2.Persona("Exequiel", "Vial", "ejvial@miuandes", "223334445"));
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
