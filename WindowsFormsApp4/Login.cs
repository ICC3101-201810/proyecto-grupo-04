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
    public partial class Login : Form
    {
        Thread th;
        public static List<ClassLibrary2.Credencial> credenciales = new List<ClassLibrary2.Credencial>();
        public List<ClassLibrary2.Persona> personas = new List<ClassLibrary2.Persona>();

        public Login(List<Credencial> _credenciales,List<Persona>_personas)
        {
            InitializeComponent();
            credenciales = _credenciales;
            personas = _personas;
        }

        #region Botones Login
        private void LLCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            th = new Thread(openMenuCuenta);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void BLogin_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text;
            foreach (Credencial c in credenciales)
            {
                if (username == c.username)
                {
                    string password = TBPassword.Text;
                    if (password == c.password)
                    {
                        if (c.acceso == "ADMIN")
                        {
                            this.Close();
                            th = new Thread(openMenuAdmin);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        else
                        {
                            this.Close();
                            th = new Thread(openMenuAlumnos);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password incorrecto :( ");
                        TBUsername.Clear();
                        TBPassword.Clear();
                        break;
                    }
                }
            }
            MessageBox.Show("No existe usuario :( ");
            TBUsername.Clear();
            TBPassword.Clear();
        }
        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Direccion Botones
        private void openMenuAlumnos()
        {
            {
                Application.Run(new Menu());
            }
        }//Abrira el Menu de alumnos y profesores
        private void openMenuCuenta()
                {
                    Application.Run(new MenuCuenta(credenciales,personas));
                }//Abrira el Menu Para crear una nueva cuenta
        private void openMenuAdmin()
        {
            Application.Run(new MenuAdmin());
        }

        #endregion

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
