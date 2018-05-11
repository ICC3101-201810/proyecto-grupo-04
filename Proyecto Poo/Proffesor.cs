using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Proyecto_Poo
{
    public class Professor : Persona
    {
        string facultad;
        public Professor(string miNombre, string miApellido, string mifacultad) : base(miNombre, miApellido)
        {
            facultad = mifacultad;
        }
        public override string GetMail()
        {
            email = nombre[0] + apellido + "@uandes.cl";
            return email;
        }
        public override void Enviar(Sala a)
        {
            string de, clave, para, asunto, cuerpo;

            Console.Clear();
            Console.WriteLine("Ahora ingrese sus datos para enviarle un mail para confirmar su arriendo");
            de = "salasuandes@gmail.com";
            clave = "salasuandes123";
            Console.WriteLine("Correo: ");
            para = Console.ReadLine();
            Console.Clear();
            asunto = "Arriendo de salas uandes";
            cuerpo = "Estimado profesor usted ha arrendado la sala de estudio" + a.ID + " le pedimos que deja la sala limpia y ordenada, gracias!. ";
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
        }
    }
}
