using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;
using ClassLibrary2;

namespace WindowsFormsApp4
{
    public partial class CastigarAlumno : Form
    {
        Thread th;
        List<CheckBox> CheckBoxes = new List<CheckBox>();
        public static List<Credencial> credenciales;
        public List<Persona> personas;
        public Edificio edificio;
        public Persona currentUser;
        public Persona alumnoCastigado;
        public int contador;
        public CastigarAlumno(List<Credencial> _credenciales, List<Persona> _personas, Edificio _edificio, Persona _currentUser, Persona _alumnoCastigado, int _contador)
        {
            InitializeComponent();

            CheckBoxes.Add(CBNoDevolvioSala);
            CheckBoxes.Add(CBNoDevolvioAccesorio);
            CheckBoxes.Add(CBSalaMalEstado);
            CheckBoxes.Add(CBDevolvioSalaSucia);

            credenciales = _credenciales;
            personas = _personas;
            edificio = _edificio;
            currentUser = _currentUser;
            alumnoCastigado = _alumnoCastigado;

            LNombreAlumno.Text = alumnoCastigado.nombre;
            LRutAlumno.Text = alumnoCastigado.rut;
            LMailAlumno.Text = alumnoCastigado.email;
            contador = _contador;
        }
        
        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (CBNoDevolvioSala.Checked || CBNoDevolvioAccesorio.Checked || CBSalaMalEstado.Checked || CBDevolvioSalaSucia.Checked)
            {
                string de, clave, para, asunto, cuerpo;
                de = "salasuandes@gmail.com";
                clave = "salasuandes123";
                Console.WriteLine("Correo: ");
                para = alumnoCastigado.email;
                asunto = "Multa por uso indebido de Sala";
                cuerpo = "Estimado Alumno Usted ha sido multado bajo los siguientes criterios /n";
                if (CBNoDevolvioSala.Checked)
                {
                    cuerpo = cuerpo + "No Devolvio sala\n";

                }
                if (CBNoDevolvioAccesorio.Checked)
                {
                    cuerpo = cuerpo + "No Devolvio Accesorio\n";

                }
                if (CBSalaMalEstado.Checked)
                {
                    cuerpo = cuerpo + "Devolvio Sala En mal estado\n";

                }
                if (CBDevolvioSalaSucia.Checked)
                {
                    cuerpo = cuerpo + "Devolvio Sala Sucia\n";

                }
                using (SmtpClient comprobar = new SmtpClient("Smtp.gmail.com", 25))
                {
                    MailMessage mensaje = new MailMessage(de, para, asunto, cuerpo);
                    comprobar.EnableSsl = true;
                    comprobar.Credentials = new NetworkCredential(de, clave);
                    try
                    {
                        comprobar.Send(mensaje);
                        MessageBox.Show("Mail enviado con exito");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.Close();
                th = new Thread(openMenuAdmin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMenuAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMenuAdmin()
        {
            Application.Run(new MenuAdmin(credenciales, personas, edificio, currentUser,contador));
        }
    }
}
