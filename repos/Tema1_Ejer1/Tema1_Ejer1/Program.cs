namespace Tema1_Ejer1
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Net.Mime.MediaTypeNames;

    internal class Program
    {
        private static string x;

        static void Main(string[] args)
        {
            do {
                imprimirMenu();
                x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        ManejarFechas x = new();
                        x.Menu();
                        break;
                    case "2":
                        GestionJuegos y = new();
                        y.Menu();
                        break;
                    case "3":
                        AlquilerPuertos z = new();
                        z.Menu();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            } while (x != null);           
            
        }
        private static void imprimirMenu() {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine();
            Console.WriteLine("1.- Manejar Fechas");
            Console.WriteLine("2.- Gestión Juegos");
            Console.WriteLine("3.- Alquiler Puertos");
            Console.WriteLine("4.- Salir");
        }
        private static void AlquilerPuertos()
        {
            throw new NotImplementedException();
        }

        private static void GestionJuegos()
        {
            throw new NotImplementedException();
        }

        private static void ManejarFechas()
        {
            throw new NotImplementedException();
        }

        

    }
}