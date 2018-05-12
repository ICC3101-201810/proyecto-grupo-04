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

namespace WindowsFormsApp4
{
    public partial class CastigarAlumno : Form
    {
        Thread th;
        List<CheckBox> CheckBoxes = new List<CheckBox>();
        public CastigarAlumno()
        {
            InitializeComponent();

            CheckBoxes.Add(CBNoDevolvioSala);
            CheckBoxes.Add(CBNoDevolvioAccesorio);
            CheckBoxes.Add(CBSalaMalEstado);
            CheckBoxes.Add(CBDevolvioSalaSucia);
        }
        
        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (CBNoDevolvioSala.Checked || CBNoDevolvioAccesorio.Checked || CBSalaMalEstado.Checked || CBDevolvioSalaSucia.Checked)
            {
                MessageBox.Show("entra");
                Close();
                /*
                string de, clave, para, asunto, cuerpo;
                
                Console.WriteLine("Ahora ingrese sus datos para enviarle un mail para confirmar su arriendo");
                de = "salasuandes@gmail.com";
                clave = "salasuandes123";
                Console.WriteLine("Correo: ");
                para = Console.ReadLine();
                Console.Clear();
                asunto = "Multa por uso indebido de Sala";
                cuerpo = "Estimado alumno usted ha arrendado la sala de estudio le recordamos que debe dejar la sala limpia y ordenada y debe devolverla luego de 1 hora y media, de lo contrario será multado. ";
                Console.Clear();
                using (SmtpClient comprobar = new SmtpClient("Smtp.gmail.com", 25))
                {
                    MailMessage mensaje = new MailMessage(de, para, asunto, cuerpo);
                    comprobar.EnableSsl = true;
                    comprobar.Credentials = new NetworkCredential(de, clave);
                    try
                    {
                        comprobar.Send(mensaje);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enviado correctamente!");

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Error, mensaje: " + ex.Message);
                    }
                }
                */
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
            Application.Run(new MenuAdmin());
        }
    }
}
