namespace Tema1_Ejer1
{
    using System;
    internal class Program
    {
        private static string x;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine();
            Console.WriteLine("1.- Manejar Fechas");
            Console.WriteLine("2.- Gestión Juegos");
            Console.WriteLine("3.- Alquiler Puertos");
            Console.WriteLine("4.- Salir");
            
            x = Console.ReadLine();
            switch (x) {
                case "1":
                    ManejarFechas.Menu();
                    break;
                case "2":
                    GestionJuegos();
                    break;
                case "3":
                    AlquilerPuertos();
                    break;
                case "4":
                    Salir();
                    break;
            }
            
        }

        private static void Salir()
        {
            throw new NotImplementedException();
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

        private static void DiaSemana()
        {
            Console.WriteLine("Introduce una fecha");
            try
            {
                x = Console.ReadLine();
                DateTime dateTime = DateTime.Parse(x);
                Console.WriteLine("Fecha Introducida: " + dateTime);
                Console.WriteLine("Dia: " + dateTime.DayOfWeek.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse the specified date");
            }
            Console.WriteLine(x);
        }

    }
}