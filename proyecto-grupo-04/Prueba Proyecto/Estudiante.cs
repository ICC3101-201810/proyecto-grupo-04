using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Proyecto
{
    public class Estudiante : Persona
    {
        List<Accesorio> carroCompra;
        public string carrera;
        Accesorio noteb = new Notebook(0, 0);
        public Estudiante(string miNombre, string miApellido, string miCarrera) : base(miNombre, miApellido)
        {
            carrera = miCarrera;

        }
        public override void ArrendarAccesorio(Accesorio accesorio)
        {
            if (accesorio.GetType() == noteb.GetType())
            {
                Console.WriteLine("Estudiantes no pueden arrendar notebooks");
            }
            else
            {
                carroCompra.Add(accesorio);
            }

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
            cuerpo = "Estimado alumno usted ha arrendado la sala de estudio" + a.ID + " le recordamos que debe dejar la sala limpia y ordenada y debe devolverla luego de 1 hora y media, de lo contrario será multado. ";
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
