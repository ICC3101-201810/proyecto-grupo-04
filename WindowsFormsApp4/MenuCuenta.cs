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
    public partial class MenuCuenta : Form
    {
        Thread th;
        int cont = 0;
        public static List<Credencial> credenciales;
        public List<Persona> personas;
        public Edificio edificio;
        public Persona currentUser;
        public int contador;

        public MenuCuenta(List<Credencial> _credenciales, List<Persona> _personas, Edificio _edificio, Persona _currentUser, int _contador)
        {
            InitializeComponent();
            credenciales = _credenciales;
            personas = _personas;
            contador = _contador;
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
                        Estudiante b = new Estudiante {nombre=nombre,apellido= apellido,email= mail,carrera= multi,rut=rut,cargo="ALUMNO" };
                        personas.Add(b);
                    }
                    else if (cargo == "PROFESOR")//Crea La nueva cuenta como Profesor
                    {
                        Profesor b = new Profesor {nombre= nombre,apellido= apellido,email= mail,facultad= multi,rut= rut ,cargo="PROFESOR"};
                        personas.Add(b);
                    }
                    else if (cargo == "ADMIN")//Crea La nueva cuenta como Admin
                    {
                        Persona b = new Persona {nombre= nombre,apellido= apellido,email= mail,rut= rut,cargo="ADMIN" };
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
            Application.Run(new Login(credenciales,personas, edificio, currentUser,contador));
        }

        private void setupData()
        {
            credenciales.Add(new ClassLibrary2.Credencial("alumno", "pass", "ALUMNO", "112223334"));
            credenciales.Add(new ClassLibrary2.Credencial("admin", "pass", "ADMIN", "223334445"));

            personas.Add(new Estudiante { nombre="Sebastian", apellido="Gonzalez", email="slgonzalez@miuandes.cl", carrera="Ingenieria",rut= "112223334" });
            personas.Add(new Persona { nombre="Exequiel", apellido="Vial", email="ejvial@miuandes",rut= "223334445" });
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
