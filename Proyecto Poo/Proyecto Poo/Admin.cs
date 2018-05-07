using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Proyecto_Poo
{
    public class Admin : Persona
    {
        Random random = new Random();
        public int numID = 123456;
        Persona persona;
        List<Estudiante> restriciones = new List<Estudiante>();
        public Admin(string miNombre, string miApellido) : base(miNombre, miApellido)
        {
        }

        public void AgregarSala(Edificio edificio)
        {
            int capacidadSalas;
            capacidadSalas = random.Next(1, 13);
            Sala sala = new Sala(numID, capacidadSalas, true);
            edificio.salasDisponibles.Add(sala);
        }
        public void BorrarSala(Edificio edificio, Sala sala)
        {
            int ocurrio = 0;
            foreach (Sala s in edificio.salasDisponibles)
            {
                if (s == sala)
                {
                    ocurrio = 1;
                }
            }
            foreach (Sala s in edificio.salasNoDisponibles)
            {
                if (s == sala)
                {
                    ocurrio = 2;
                }
            }
            if (ocurrio == 1)
            {
                edificio.salasDisponibles.Remove(sala);
            }
            if (ocurrio == 2)
            {
                edificio.salasNoDisponibles.Remove(sala);
            }

        }
        public bool TieneRestriccion(Estudiante estudiante)
        {
            foreach (Estudiante e in restriciones)
            {
                if (e == estudiante)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddRestriccion(Estudiante estudiante)
        {
            restriciones.Add(estudiante);
        }


        public override void DesocuparSala(Sala sala, Edificio edificio)
        {
            edificio.salasNoDisponibles.Remove(sala);
            edificio.salasDisponibles.Add(sala);

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
            cuerpo = "Estimado administrador, han devuelto la sala de estudio" + a.ID + " recuerde ir a revisar que hayan dejado la sala lo más ordenada posible, de lo contrario multe al responsable ";
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
