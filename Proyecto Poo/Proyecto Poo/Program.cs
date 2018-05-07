using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Proyecto_Poo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            bool generateRandom()
            {
                if (rnd.Next(2) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            //Variables que se usan para el menu
            int idC, idE;//id sala
            bool esta = false;
            bool disponible, trueFalse;
            string acce;
            int k, j;
            Sala salaA = new Sala(0, 0, false);
            //lista de nombres para la simulacion
            List<string> nombres = new List<string>()
            {
                "Cristobal","Alejandra","Edurado","Maria"
            };

            //lista de apellidos para la simulacion
            List<string> apellidos = new List<string>()
            {
            "Gonzalez","Diaz","Lopez","Martinez","Sosa","Romero","Ruiz","Ramirez","Benitez","Suarez","Aguirre","Gutierrez",
            "Molina","Ortiz","Silva","Nuñez","Juarez","Rios","Morales","Vega","Carrizo","Castillo","Muñoz","Vera","Navarro",
            "Ramos","Arias","Coronel","Vargas","Farias","Paz","Miranda"
            };

            //creacion de lista de personas
            List<Persona> personas = new List<Persona>();

            //creacion de lista de personas
            List<string> facultades = new List<string>
            {
            "Medicina","Ingeniecia","Negocios","Arte","Filosofia","Gastronomia"
            };
            List<string> carreras = new List<string>
            {
            "Enfermeria","Kinesiologia","Odontologia","Ciencias de la Computacion","Ingenieria Electrica","Ingenieria Comercial","Expresion Artistica"
            ,"Antropologia","Ciencias Humanistas","Cocina1"
            };

            List<Ariendo> arriendos = new List<Ariendo>();

            List<Sala> salasDisponiblesReloj = new List<Sala>();
            List<Sala> salasDisponiblesBiblioteca = new List<Sala>();

            List<Sala> salasNoDisponiblesReloj = new List<Sala>();
            List<Sala> salasNoDisponiblesBiblioteca = new List<Sala>();

            List<Edificio> edificios = new List<Edificio>();

            List<Accesorio> accesorios = new List<Accesorio>();

            Edificio Reloj = new Edificio(salasDisponiblesReloj, "Reloj", salasNoDisponiblesReloj);
            Edificio Biblioteca = new Edificio(salasDisponiblesBiblioteca, "Biblioteca", salasNoDisponiblesBiblioteca);

            edificios.Add(Reloj);
            edificios.Add(Biblioteca);

            foreach (string nombreu in nombres)
            {
                if (apellidos.Count == 0)
                {
                    break;
                }
                trueFalse = generateRandom();
                if (trueFalse)       //Creacion de Persona(Profesor)
                {
                    j = rnd.Next(facultades.Count);
                    k = rnd.Next(apellidos.Count);
                    Persona usuario = new Professor(nombreu, apellidos[k], facultades[j]);
                    personas.Add(usuario);
                    apellidos.RemoveAt(k);
                }
                else            //Creacion de Persona(Estudiante)
                {
                    j = rnd.Next(carreras.Count);
                    k = rnd.Next(apellidos.Count);
                    Persona usuario = new Estudiante(nombreu, apellidos[k], carreras[j]);
                    personas.Add(usuario);
                    apellidos.RemoveAt(k);

                }
            } //Generacion Personas (Estudiantes Y Profesores)

            foreach (Edificio edificioo in edificios)
            {
                k = rnd.Next(20, 31);       //Cantidad De Salas Para cada Edificio
                if (edificioo.nombreEdificio == "Reloj") //Generacion Salas Edificio Reloj
                {
                    idE = 1001;                     //ID Propio Edificio Reloj
                    for (int i = 0; i < k; i++)    //Inicio Creacion Salas Edificio Reloj
                    {
                        disponible = generateRandom();  //Aleatorizacion Disponibilidad Sala Generada
                        if (disponible)
                        {
                            Sala a = new Sala(idE + i, rnd.Next(2, 13), disponible);
                            salasDisponiblesReloj.Add(a);
                        }
                        else
                        {
                            Sala a = new Sala(idE + i, rnd.Next(2, 13), disponible);
                            salasNoDisponiblesReloj.Add(a);
                        }
                    }
                }
                else
                {
                    idE = 2001;                 //ID propio edificio Biblioteca
                    for (int i = 0; i < k; i++)   //Generacion Salas Edificio Biblioteca
                    {
                        disponible = generateRandom();    //Aleatorizacion Disponibilidad Sala Generada
                        if (disponible)
                        {
                            Sala a = new Sala(idE + i, rnd.Next(2, 13), disponible);
                            salasDisponiblesBiblioteca.Add(a);
                        }
                        else
                        {
                            Sala a = new Sala(idE + i, rnd.Next(2, 13), disponible);
                            salasNoDisponiblesBiblioteca.Add(a);
                        }
                    }
                }
            }//Generacion De Salas En ambos edificios
            while (true) //Inicio Menu Simulacion
            {
                string opc1;
                Console.WriteLine("Bienvenido");
                Console.WriteLine("1.Ingresar como Alumno");
                Console.WriteLine("2.Ingresar como Profesor");
                Console.WriteLine("3.ingresar como Admin");
                opc1 = Console.ReadLine();
                if (opc1 != "1" && opc1 != "2" && opc1 != "3")
                {
                    Console.WriteLine("Opcion Ingresada NO es valida");
                    Console.Beep();
                }

                else if (opc1 == "1")//Opcion Estudiante
                {
                    Console.WriteLine("Bienvenido Alumno");
                    Console.WriteLine("Ingrese su apellido");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su carrera");
                    string carrera = Console.ReadLine();
                    Persona persona = new Estudiante(nombre, apellido, carrera);
                    while (true)
                    {
                        opc1 = "0";
                        Console.WriteLine("Bienvenido {0}", persona.nombre);
                        Console.WriteLine("1.Ver Salas Disponibles");
                        Console.WriteLine("2.Reservar Sala");
                        Console.WriteLine("3.Arrendar Sala");
                        Console.WriteLine("4.Desocupar Sala");
                        Console.WriteLine("5.Arrendar Accesorio");
                        Console.WriteLine("6.Pagar y Volver al menu");

                        opc1 = Console.ReadLine();
                        while (opc1 != "1" && opc1 != "2" && opc1 != "3" && opc1 != "4" && opc1 != "5" && opc1 != "6")
                        {
                            Console.WriteLine("Opcion Ingresada NO es Valida");
                            Console.Beep();
                            Console.WriteLine("Ingrese una opcion valida");
                            opc1 = Console.ReadLine();
                        }
                        if (opc1 == "1")//Ver salsa Disponibles
                        {
                            Reloj.MostrarSalas();
                            Biblioteca.MostrarSalas();
                        }
                        else if (opc1 == "2")//Reservar Salas
                        {
                            Console.WriteLine("1. Para arrendar en el Reloj");
                            Console.WriteLine("2. Para arrendar en biblioteca");
                            opc1 = Console.ReadLine();
                            while (opc1 != "1" && opc1 != "2")
                            {
                                Console.WriteLine("Error, Ingrese una opcion valida");
                                Console.WriteLine("1. Para arrendar en el Reloj");
                                Console.WriteLine("2. Para arrendar en biblioteca");
                                opc1 = Console.ReadLine();
                            }

                            if (opc1 == "1")//Arrendadndo en Reloj
                            {

                                while (true)
                                {
                                    Console.WriteLine("Ingrese el ID de la sala que quiera arredar");
                                    idC = Int32.Parse(Console.ReadLine());
                                    foreach (Sala s in Reloj.salasDisponibles)
                                    {
                                        if (s.ID == idC)
                                        {
                                            salaA = s;

                                            esta = true;

                                        }
                                    }

                                    if (esta)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Error, ingrese una sala disponible");
                                }
                            }

                            else //Arrendando en Biblioteca
                            {
                                while (true)
                                {
                                    Console.WriteLine("Ingrese el ID de la sa que quiera arredar");
                                    idC = Int32.Parse(Console.ReadLine());
                                    foreach (Sala s in Biblioteca.salasDisponibles)
                                    {
                                        if (s.ID == idC)
                                        {
                                            salaA = s;
                                            esta = true;

                                        }
                                    }
                                    persona.OcuparSala(salaA, Biblioteca);
                                    if (esta)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Error, ingrese una sala disponible");

                                }
                            }
                            opc1 = "0";


                        }
                        else if (opc1 == "4")//Desocupar Sala
                        {

                            while (true)
                            {
                                Console.WriteLine("Ingrese el ID de la sala que quiera retornar:");
                                idC = Int32.Parse(Console.ReadLine());
                                foreach (Sala s in Reloj.salasDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                persona.DesocuparSala(salaA, Reloj);
                                foreach (Sala s in Biblioteca.salasDisponibles)
                                {
                                    if (s.ID == idC && s.quienArrendo == persona)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                persona.DesocuparSala(salaA, Biblioteca);
                                if (esta)
                                {
                                    persona.Enviar(salaA);
                                    break;
                                }
                                Console.WriteLine("Error, ingrese su sala desocupada");
                            }

                        }
                        else if (opc1 == "5")//Arrendar Accesorio
                        {
                            Console.WriteLine("Estos son los accesorios que tenemos (al ser estudiante no todos se pueden arrendar)");
                            foreach (Accesorio a in accesorios)
                            {
                                Console.WriteLine("accesorio:{0} precio: {1}", a.GetType().Name, a.precio);
                            }
                            Console.WriteLine("Ingrese el accesorio que desea arrendar");
                            acce = Console.ReadLine();
                            while (true)
                            {
                                foreach (Accesorio a in accesorios)
                                {
                                    if (a.GetType().Name == acce)
                                    {
                                        persona.ArrendarAccesorio(a);
                                        esta = true;
                                    }
                                }
                                if (esta)
                                {
                                    break;
                                }
                                Console.WriteLine("Error");
                                Console.WriteLine("Ingrese el accesorio que desea arrendar");
                                acce = Console.ReadLine();
                            }

                        }
                        else if (opc1 == "6")
                        {
                            Console.WriteLine("su monto total es:{0}", persona.Pagar());
                            Console.WriteLine("Ingrese enter para pagar");
                            Console.ReadLine();
                            Console.WriteLine("Gracias");
                            break;
                        }

                    }

                }


                else if (opc1 == "2")//opcion Professor
                {
                    opc1 = "0";
                    Console.WriteLine("Bienvenido Professor");
                    Console.WriteLine("Ingrese su apellido");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su carrera");
                    string carrera = Console.ReadLine();
                    Persona persona = new Estudiante(nombre, apellido, carrera);
                    while (true)
                    {
                        opc1 = "0";
                        Console.WriteLine("Bienvenido {0}", persona.nombre);
                        Console.WriteLine("1.Ver Salas Disponibles");
                        Console.WriteLine("2.Reservar Sala");
                        Console.WriteLine("3.Arrendar Sala");
                        Console.WriteLine("4.Desocupar Sala");
                        Console.WriteLine("5.Arrendar Accesorio");
                        Console.WriteLine("6.Pagar y Volver al menu");

                        opc1 = Console.ReadLine();
                        while (opc1 != "1" && opc1 != "2" && opc1 != "3" && opc1 != "4" && opc1 != "5" && opc1 != "6")
                        {
                            Console.WriteLine("Opcion Ingresada NO es Valida");
                            Console.Beep();
                            Console.WriteLine("Ingrese una opcion valida");
                            opc1 = Console.ReadLine();
                        }
                        if (opc1 == "1")//Ver salsa Disponibles
                        {
                            Reloj.MostrarSalas();
                            Biblioteca.MostrarSalas();
                        }
                        else if (opc1 == "2")//Reservar Salas
                        {
                            Console.WriteLine("1. Para arrendar en el Reloj");
                            Console.WriteLine("2. Para arrendar en biblioteca");
                            opc1 = Console.ReadLine();
                            while (opc1 != "1" && opc1 != "2")
                            {
                                Console.WriteLine("Error, Ingrese una opcion valida");
                                Console.WriteLine("1. Para arrendar en el Reloj");
                                Console.WriteLine("2. Para arrendar en biblioteca");
                                opc1 = Console.ReadLine();
                            }

                            if (opc1 == "1")//Arrendadndo en Reloj
                            {

                                while (true)
                                {
                                    Console.WriteLine("Ingrese el ID de la sala que quiera arredar");
                                    idC = Int32.Parse(Console.ReadLine());
                                    foreach (Sala s in Reloj.salasDisponibles)
                                    {
                                        if (s.ID == idC)
                                        {
                                            persona.OcuparSala(s, Reloj);
                                            esta = true;

                                        }
                                    }
                                    if (esta)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Error, ingrese una sala disponible");
                                }
                            }

                            else //Arrendando en Biblioteca
                            {
                                while (true)
                                {
                                    Console.WriteLine("Ingrese el ID de la sa que quiera arredar");
                                    idC = Int32.Parse(Console.ReadLine());
                                    foreach (Sala s in Biblioteca.salasDisponibles)
                                    {
                                        if (s.ID == idC)
                                        {
                                            persona.OcuparSala(s, Biblioteca);
                                            esta = true;

                                        }
                                    }
                                    if (esta)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Error, ingrese una sala disponible");

                                }
                            }
                            opc1 = "0";


                        }
                        else if (opc1 == "4")//Desocupar Sala
                        {

                            while (true)
                            {
                                Console.WriteLine("Ingrese el ID de la sala que quiera retornar:");
                                idC = Int32.Parse(Console.ReadLine());
                                foreach (Sala s in Reloj.salasDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                persona.DesocuparSala(salaA, Reloj);
                                foreach (Sala s in Biblioteca.salasDisponibles)
                                {
                                    if (s.ID == idC && s.quienArrendo == persona)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                persona.DesocuparSala(salaA, Biblioteca);
                                if (esta)
                                {
                                    persona.Enviar(salaA);
                                    break;
                                }
                                Console.WriteLine("Error, ingrese su sala desocupada");
                            }

                        }
                        else if (opc1 == "5")//Arrendar Accesorio
                        {
                            Console.WriteLine("Estos son los accesorios que tenemos (al ser estudiante no todos se pueden arrendar)");
                            foreach (Accesorio a in accesorios)
                            {
                                Console.WriteLine("accesorio:{0} precio: {1}", a.GetType().Name, a.precio);
                            }
                            Console.WriteLine("Ingrese el accesorio que desea arrendar");
                            acce = Console.ReadLine();
                            while (true)
                            {
                                foreach (Accesorio a in accesorios)
                                {
                                    if (a.GetType().Name == acce)
                                    {
                                        persona.ArrendarAccesorio(a);
                                        esta = true;
                                    }
                                }
                                if (esta)
                                {
                                    break;
                                }
                                Console.WriteLine("Error");
                                Console.WriteLine("Ingrese el accesorio que desea arrendar");
                                acce = Console.ReadLine();
                            }

                        }
                        else if (opc1 == "6")
                        {
                            Console.WriteLine("su monto total es:{0}", persona.Pagar());
                            Console.WriteLine("Ingrese enter para pagar");
                            Console.ReadLine();
                            Console.WriteLine("Gracias");
                            break;
                        }

                    }

                }
                else if (opc1 == "3")//opcion Admin
                {
                    opc1 = "0";
                    Console.WriteLine("Bienvenido Administrador");
                    Console.WriteLine("Ingrese su apellido");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese su nombre");
                    string nombre = Console.ReadLine();
                    Admin persona = new Admin(nombre, apellido);
                    while (true)
                    {
                        Console.WriteLine("1.Ver Salas ");
                        Console.WriteLine("2.Crear Sala");
                        Console.WriteLine("3.Borrar Sala");
                        Console.WriteLine("4.Castigar Alumno");
                        Console.WriteLine("5.Desocupar una sala");
                        Console.WriteLine("6.Salir");
                        opc1 = Console.ReadLine();
                        while (opc1 != "1" && opc1 != "2" && opc1 != "3" && opc1 != "4" && opc1 != "5" && opc1 != "6")
                        {
                            Console.WriteLine("Opcion Ingresada NO es Valida");
                            Console.Beep();
                            Console.WriteLine("Ingrese una opcion valida");
                            opc1 = Console.ReadLine();
                        }
                        if (opc1 == "1")
                        {
                            Reloj.MostrarSalas();
                            Reloj.MostrarSalasNoDisponibles();
                            Biblioteca.MostrarSalas();
                            Biblioteca.MostrarSalasNoDisponibles();
                        }
                        if (opc1 == "2")
                        {
                            Console.WriteLine("1. Para agregar sala en Reloj");
                            Console.WriteLine("2. Para agregar sala en biblioteca");
                            opc1 = Console.ReadLine();
                            while (opc1 != "1" && opc1 != "2")
                            {
                                Console.WriteLine("Error, Ingrese una opcion valida");
                                Console.WriteLine("1. Para agregar en el Reloj");
                                Console.WriteLine("2. Para agregar en biblioteca");
                                opc1 = Console.ReadLine();
                            }
                            if (opc1 == "1")
                            {
                                persona.AgregarSala(Reloj);
                            }
                            if (opc1 == "2")
                            {
                                persona.AgregarSala(Biblioteca);
                            }
                        }
                        if (opc1 == "3")
                        {
                            Console.WriteLine("1. Para borrar sala en Reloj");
                            Console.WriteLine("2. Para borrar sala en biblioteca");
                            opc1 = Console.ReadLine();
                            while (opc1 != "1" && opc1 != "2")
                            {
                                Console.WriteLine("Error, Ingrese una opcion valida");
                                Console.WriteLine("1. Para borrar en el Reloj");
                                Console.WriteLine("2. Para borrar en biblioteca");
                                opc1 = Console.ReadLine();
                            }
                            while (true)
                            {
                                Console.WriteLine("Ingrese el ID de la sala que quiera Borrar:");
                                idC = Int32.Parse(Console.ReadLine());
                                foreach (Sala s in Reloj.salasDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                foreach (Sala s in Biblioteca.salasDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                foreach (Sala s in Reloj.salasNoDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                foreach (Sala s in Biblioteca.salasNoDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                if (esta)
                                {
                                    break;
                                }
                                Console.WriteLine("Error, ingrese una sala valida");
                            }
                            if (opc1 == "1")
                            {
                                persona.BorrarSala(Reloj, salaA);
                            }
                            if (opc1 == "2")
                            {
                                persona.BorrarSala(Biblioteca, salaA);
                            }
                        }
                        if (opc1 == "4")
                        {
                            Console.WriteLine("Ingrese su apellido");
                            string apellidoCas = Console.ReadLine();
                            Console.WriteLine("Ingrese su nombre");
                            string nombreCas = Console.ReadLine();
                            Console.WriteLine("Ingrese su carrera");
                            string carreraCas = Console.ReadLine();
                            Estudiante personaCas = new Estudiante(nombreCas, apellidoCas, carreraCas);
                            persona.AddRestriccion(personaCas);
                        }
                        if (opc1 == "5")
                        {
                            while (true)
                            {
                                Console.WriteLine("Ingrese el ID de la sala que quiera retornar:");
                                idC = Int32.Parse(Console.ReadLine());
                                foreach (Sala s in Reloj.salasDisponibles)
                                {
                                    if (s.ID == idC)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                persona.DesocuparSala(salaA, Reloj);
                                foreach (Sala s in Biblioteca.salasDisponibles)
                                {
                                    if (s.ID == idC && s.quienArrendo == persona)
                                    {
                                        salaA = s;
                                        esta = true;

                                    }
                                }
                                persona.DesocuparSala(salaA, Biblioteca);
                                if (esta)
                                {
                                    break;
                                }
                                Console.WriteLine("Error, ingrese su sala desocupada");
                            }
                        }
                        if (opc1 == "6")
                        {
                            break;
                        }
                    }
                }

            }

        }
    }
}
