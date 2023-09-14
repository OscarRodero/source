using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class ManejarFechas
    {
        public void Menu() {            
            bool salir = false;
            while (!salir) {
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine();
                Console.WriteLine("1.- Ver el día de la semana");
                Console.WriteLine("2.- Incrementar una fecha");
                Console.WriteLine("3.- Ver diferencia entre fechas");
                Console.WriteLine("4.- Comparar fechas");
                Console.WriteLine("5.- Mostrar una fecha en formato largo");
                Console.WriteLine("6.- Atrás");
                try
                {
                    String a = Console.ReadLine();
                    int x = 0;
                    bool y = int.TryParse(a, out x);                    
                    if (y)
                    {
                        switch (x)
                        {
                            case 1:
                                DiaSemana();
                                break;
                            case 2:
                                IncrementarFecha();
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opción no reconocida, abortando...");
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            
        }

        private void IncrementarFecha()
        {
            try
            {
                Console.WriteLine("Introduce una fecha a incrementar");
                String fecha = Console.ReadLine();
                DateTime dateTime = DateTime.Parse(fecha);
                Console.WriteLine("Introduce el número de días a incrementar");
                String numero = Console.ReadLine();
                int NumeroCorrecto;
                bool esNumero = int.TryParse(numero, out NumeroCorrecto);
                if (esNumero) { 
                    dateTime = dateTime.AddDays(NumeroCorrecto);
                    Console.WriteLine(dateTime.ToString());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha introducido una fecha correcta. (dd/mm/yyyy)");
            }
        }

        private static void DiaSemana()
        {
            Console.WriteLine("Introduce una fecha");
            try
            {
                String x = Console.ReadLine();
                DateTime dateTime = DateTime.Parse(x);
                Console.WriteLine("Dia: " + dateTime.DayOfWeek.ToString());
                Console.WriteLine(x);
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha introducido una fecha correcta. (dd/mm/yyyy)");
            }
            
        }
    }
}
