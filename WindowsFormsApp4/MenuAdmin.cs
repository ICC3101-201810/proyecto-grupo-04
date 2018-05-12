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

namespace WindowsFormsApp4
{
    public partial class MenuAdmin : Form
    {
        Thread th;
        public static List<ClassLibrary2.Credencial> credenciales = new List<ClassLibrary2.Credencial>();
        public List<ClassLibrary2.Persona> personas = new List<ClassLibrary2.Persona>();
        public MenuAdmin()
        {
            InitializeComponent();
            credenciales = new List<ClassLibrary2.Credencial>();
            personas= new List<ClassLibrary2.Persona>();
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new Login(credenciales,personas));
        }

        private void BCastigarAlumno_Click(object sender, EventArgs e)
        {
            if (!LBAlumnos.Visible)
            {
                LBAlumnos.Visible = true;
                LAlumnos.Visible = true;
                PB1.Visible = false;
            }
            if (LBAlumnos.Text != "")
            {
                th = new Thread(openCastigarAlumno);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                LBAlumnos.Visible = false;
                LAlumnos.Visible = false;
                PB1.Visible = true;
            }
        }

        private void openCastigarAlumno()
        {
            Application.Run(new CastigarAlumno());
        }
    }
}
