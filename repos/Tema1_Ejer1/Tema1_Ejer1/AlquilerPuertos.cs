using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class AlquilerPuertos
    {
        static List<Alquiler> alquileres = new List<Alquiler>();
        public void Menu()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú de Alquileres:");
                Console.WriteLine("1. Crear Alquiler");
                Console.WriteLine("2. Ver Alquileres");
                Console.WriteLine("3. Modificar Alquiler");
                Console.WriteLine("4. Borrar Alquiler");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearAlquiler();
                        break;
                    case "2":
                        VerAlquileres();
                        break;
                    case "3":
                        ModificarAlquiler();
                        break;
                    case "4":
                        BorrarAlquiler();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        public static void CrearAlquiler()
        {
            
        }

        public static void VerAlquileres()
        {
            Console.WriteLine("Lista de Alquileres:");
            foreach (var alquiler in alquileres)
            {
                // Aquí puedes mostrar los detalles de cada alquiler en la lista.
            }
        }

        public static void ModificarAlquiler()
        {
            // Aquí puedes solicitar al usuario que ingrese un identificador o información para identificar el alquiler que desea modificar
            // Luego, busca el alquiler en la lista y permite al usuario modificar sus datos.
        }

        public static void BorrarAlquiler()
        {
            // Aquí puedes solicitar al usuario que ingrese un identificador o información para identificar el alquiler que desea borrar
            // Luego, busca el alquiler en la lista y elimínalo.
        }
    }
    }
}
