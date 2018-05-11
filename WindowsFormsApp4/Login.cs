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
        public static List<Credencial> credenciales;
        public List<Persona> personas;
        public Edificio edificio;
        public Persona currentUser;

        public Login(List<Credencial> _credenciales,List<Persona>_personas, Edificio _edificio, Persona _currentUser)
        {
            InitializeComponent();
            credenciales = _credenciales;
            personas = _personas;
            edificio = _edificio;
            currentUser = new Persona("", "", "", "");
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
                            foreach (Credencial crec in credenciales)
                            {
                                if (password == crec.password)
                                {
                                    foreach (Persona p in personas)
                                    {
                                        if (p.rut == crec.rut)
                                        {
                                            currentUser = p;
                                        }
                                    }
                                }
                            }
                            this.Close();
                            th = new Thread(openMenuAdmin); //Definir el currentUser para enviar al menuadmin TODO
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        else
                        {
                            foreach (Credencial crec in credenciales)
                            {
                                if (password == crec.password)
                                {
                                    foreach (Persona p in personas)
                                    {
                                        if (p.rut == crec.rut)
                                        {
                                            currentUser = p;
                                        }
                                    }
                                }
                            }
                            this.Close();
                            th = new Thread(openMenuAlumnos); //Definir el currentUser para enviar al menualumnos TODO
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
                Application.Run(new Menu(credenciales,personas,edificio,currentUser));
            }
        }//Abrira el Menu de alumnos y profesores
        private void openMenuCuenta()
                {
                    Application.Run(new MenuCuenta(credenciales,personas,edificio, currentUser));
                }//Abrira el Menu Para crear una nueva cuenta
        private void openMenuAdmin()
        {
            Application.Run(new MenuAdmin(credenciales,personas,edificio,currentUser));
        }//Abrir el Menu exclusivamente de admin

        #endregion
    }
}
