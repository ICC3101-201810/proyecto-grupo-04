using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Proyecto_Poo
{
    public abstract class Persona
    {
        public List<Accesorio> carroArriendo;
        public string nombre;
        public string apellido;
        public string email;

        public Persona(string miNombre, string miApellido)
        {
            nombre = miNombre;
            apellido = miApellido;

        }

        public virtual void OcuparSala(Sala sala, Edificio edificio)
        {
            edificio.salasDisponibles.Remove(sala);
            edificio.salasNoDisponibles.Add(sala);
        }

        public virtual void DesocuparSala(Sala sala, Edificio edificio)
        {
            edificio.salasNoDisponibles.Remove(sala);
            edificio.salasDisponibles.Add(sala);
        }


        public virtual string GetMail()
        {
            email = nombre[0] + apellido + "@miuandes.cl";
            return email;
        }

        public virtual void ArrendarAccesorio(Accesorio accesorio)
        {
            carroArriendo.Add(accesorio);
        }
        public double Pagar()
        {
            double precioTotal = 0;
            foreach (Accesorio a in carroArriendo)
            {
                precioTotal += a.precio;
            }
            return precioTotal;
        }
        public virtual void Enviar(Sala a)
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
