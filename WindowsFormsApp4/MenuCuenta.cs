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
    public partial class MenuCuenta : Form
    {
        Thread th;
        int cont = 0;

        public static List<ClassLibrary2.Credencial> credenciales = new List<ClassLibrary2.Credencial>();
        public List<ClassLibrary2.Persona> personas = new List<ClassLibrary2.Persona>();


        public MenuCuenta(List<ClassLibrary2.Credencial> _credencials, List<ClassLibrary2.Persona> _personas)
        {
            InitializeComponent();
            credenciales = _credencials;
            personas = _personas;
        }
        private void BAceptar_Click(object sender, EventArgs e)
        {
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            string mail = TBMail.Text;
            string password = TBContraseña.Text;
            string cargo = CBCargo.Text;
            string rut = TBRut.Text;
            string multi = TBMulti.Text;
            bool crear = true;

            if (nombre != "" && apellido != "" && mail != "" && password != "" && cargo != "" && rut != "") //Comprobando Que se llenen Todos los Datos Requeridos
            {
                // Almacenando Los Text Box en variables

                foreach (ClassLibrary2.Credencial c in credenciales)
                {
                    if (c.rut == rut || c.username == mail) //Ya Existe un Usuario Con esos Datos -->Error
                    {
                        MessageBox.Show("Imposible Crear Usuario");
                        crear = false;
                        break;
                    }
                }
                if (crear)
                {
                    ClassLibrary2.Credencial a = new ClassLibrary2.Credencial(mail, password, cargo, rut);
                    credenciales.Add(a); //Agrega la credencial de la nueva cuenta, asociada a la persona mediante el rut

                    if (cargo == "ALUMNO") //Crea La nueva cuenta como Estudiante
                    {
                        ClassLibrary2.Estudiante b = new ClassLibrary2.Estudiante(nombre, apellido, mail, multi, rut);
                        personas.Add(b);
                    }
                    else if (cargo == "PROFESOR")//Crea La nueva cuenta como Profesor
                    {
                        ClassLibrary2.Profesor b = new ClassLibrary2.Profesor(nombre, apellido, mail, multi, rut);
                        personas.Add(b);
                    }
                    else if (cargo == "ADMIN")//Crea La nueva cuenta como Admin
                    {
                        ClassLibrary2.Persona b = new ClassLibrary2.Persona(nombre, apellido, mail, rut);
                        personas.Add(b);
                    }
                }
                //Limpiando Los TextBox despues de recibir parametros
                TBNombre.Clear();
                TBApellido.Clear();
                TBContraseña.Clear();
                TBMail.Clear();
                TBRut.Clear();
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
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

        private void setupData()
        {
            credenciales.Add(new ClassLibrary2.Credencial("alumno", "pass", "ALUMNO", "112223334"));
            credenciales.Add(new ClassLibrary2.Credencial("admin", "pass", "ADMIN", "223334445"));

            personas.Add(new ClassLibrary2.Estudiante("Sebastian", "Gonzalez", "slgonzalez@miuandes.cl", "Ingenieria", "112223334"));
            personas.Add(new ClassLibrary2.Persona("Exequiel", "Vial", "ejvial@miuandes", "223334445"));
        }

        private void TBRut_Enter(object sender, EventArgs e)
        {
            if (cont==0)
            {
                TBRut.Text = "";
                TBRut.ForeColor = SystemColors.ActiveCaptionText;
                cont++;
            }
        }

        private void CBCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCargo.Text == "ALUMNO")
            {
                LMulti.Visible = true;
                LMulti.Text = "Carrera";
                TBMulti.Visible = true;
            }
            else if (CBCargo.Text == "PROFESOR")
            {
                LMulti.Visible = true;
                LMulti.Text = "Facultad";
                TBMulti.Visible = true;
            }
            else if (CBCargo.Text == "ADMIN")
            {
                LMulti.Visible = false;
                LMulti.Text = "Carrera";
                TBMulti.Visible = false;
            }
        }
    }
}
