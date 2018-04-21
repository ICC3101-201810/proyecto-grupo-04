using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Proyecto
{
    public static void Main(string[] args)
    {
        //Variables que se usan para el menu
        int idC;//id sala
        bool esta = false;
        string acce;
        Sala salaA;

        //lista de nombres para la simulacion
        List<string> nombres = new List<string>();
        nombres.Add("Cristobal");
        nombres.Add("Alejandra");
        nombres.Add("Eduardo");
        nombres.Add("Maria");
        nombres.Add("Matias");
        nombres.Add("Pedro");
        nombres.Add("Javiera");
        nombres.Add("Sofia");
        nombres.Add("Ernesto");
        nombres.Add("Claudio");
        nombres.Add("Cristian");
        nombres.Add("Felipe");
        nombres.Add("Catalina");
        nombres.Add("Valentina");
        nombres.Add("Francisca");
        nombres.Add("Patricio");
        nombres.Add("Guillermo");
        nombres.Add("Rodrigo");
        nombres.Add("Mateo");
        nombres.Add("Margarita");
        nombres.Add("Roberto");
        nombres.Add("Fernanda");
        nombres.Add("Antonia");
        nombres.Add("Agustin");
        nombres.Add("Osvaldo");
        nombres.Add("Clemente");
        nombres.Add("Vicente");
        nombres.Add("Carmen");
        nombres.Add("Isabel");
        nombres.Add("Teresa");
        nombres.Add("Julio");
        nombres.Add("Martin");
        nombres.Add("Francisco");
        nombres.Add("Leonora");
        nombres.Add("Joaquin");
        nombres.Add("David");

        //lista de apellidos para la simulacion
        List<string> apellidos = new List<string>();
        apellidos.Add("Gonzalez");
        apellidos.Add("Diaz");
        apellidos.Add("Lopez");
        apellidos.Add("Martinez");
        apellidos.Add("Sosa");
        apellidos.Add("Romero");
        apellidos.Add("Ruiz");
        apellidos.Add("Ramirez");
        apellidos.Add("Benitez");
        apellidos.Add("Suarez");
        apellidos.Add("Aguirre");
        apellidos.Add("Gutierrez");
        apellidos.Add("Molina");
        apellidos.Add("Ortiz");
        apellidos.Add("Silva");
        apellidos.Add("Nuñez");
        apellidos.Add("Juarez");
        apellidos.Add("Rios");
        apellidos.Add("Morales");
        apellidos.Add("Vega");
        apellidos.Add("Carrizo");
        apellidos.Add("Castillo");
        apellidos.Add("Muñoz");
        apellidos.Add("Vera");
        apellidos.Add("Navarro");
        apellidos.Add("Ramos");
        apellidos.Add("Arias");
        apellidos.Add("Coronel");
        apellidos.Add("Vargas");
        apellidos.Add("Farias");
        apellidos.Add("Paz");
        apellidos.Add("Miranda");

        //creacion de lista de personas
        List<Persona> personas = new List<Persona>();
        bool trueFalse;
        int k, j;
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

        List<Reserva> reservas = new List<Reserva>();

        List<Sala> salasDisponibles = new List<Sala>();

        List<Sala> salasNoDisponibles = new List<Sala>();

        List<Edificio> edificios = new List<Edificio>();
        Random rnd = new Random();

        List<Accesorio> accesorios = new List<Accesorio>();

        Edificio Reloj = new Edificio(salasDisponibles, "Reloj", salasNoDisponibles);
        Edificio Biblioteca = new Edificio(salasDisponibles, "Biblioteca", salasNoDisponibles);

        foreach (string nombreu in nombres)
        {
            trueFalse = generateRandom();
            if (trueFalse)       //Creacion de Persona(Profesor)
            {
                j = rnd.Next(facultades.Count + 1);
                k = rnd.Next(0, apellidos.Count + 1);
                Persona usuario = new Professor(nombreu, apellidos[k], facultades[j]);
                personas.Add(usuario);
                apellidos.RemoveAt(k);
            }
            else            //Creacion de Persona(Estudiante)
            {
                j = rnd.Next(carreras.Count + 1);
                k = rnd.Next(0, apellidos.Count + 1);
                Persona usuario = new Estudiante(nombreu, apellidos[k], carreras[j]);
                personas.Add(usuario);
                apellidos.RemoveAt(k);

            }
        }

        k = rnd.Next(20, 31);
        for (int i = 0; i < k; i++)
        {

            int disponibilidad = rnd.Next(2);
            int tipo = rnd.Next(2);
            bool disponible;
            if (disponibilidad == 1)
            {
                disponible = true;
            }
            else
            {
                disponible = false;
            }
            if (disponible)
            {
                Persona p = personas[rnd.Next(personas.Count)];

                Sala a = new Sala(1001 + i, rnd.Next(2, 13), disponible);

                salasDisponibles.Add(a);

                a.quienArrendo = p;
            }
            else
            {
                Sala a = new Sala(1001 + i, rnd.Next(2, 13), disponible);
                salasNoDisponibles.Add(a);
            }
        }
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
                            persona.DesocuparSala(s, Biblioteca);
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

 


