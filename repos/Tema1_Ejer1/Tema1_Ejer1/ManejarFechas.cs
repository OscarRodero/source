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
                                DiferenciaFechas();
                                break;
                            case 4:
                                CompararFechas();
                                break;
                            case 5:
                                FormatoLargo();
                                break;
                            case 6:
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opción no reconocida, inténtelo de nuevo.");
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
                Console.WriteLine("No se ha introducido una fecha correcta. (dd-MM-yyyy)");
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
                if (esNumero)
                {
                    dateTime = dateTime.AddDays(NumeroCorrecto);
                    Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha introducido una fecha correcta. (dd-MM-yyyy)");
            }
        }
        private void DiferenciaFechas()
        {
            Console.WriteLine("Introduce la primera fecha (dd-MM-yyyy):");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la segunda fecha (dd-MM-yyyy):");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan diferencia = fecha2 - fecha1;

            int años = diferencia.Days / 365;
            int meses = (diferencia.Days % 365) / 30;
            int dias = (diferencia.Days % 365) % 30;

            Console.WriteLine($"Han pasado {dias} dias, {meses} meses y {años} años días entre las dos fechas.");
        }
        private void CompararFechas()
        {
            Console.WriteLine("Introduce la primera fecha (dd-MM-yyyy):");
            string Fecha1 = Console.ReadLine();

            Console.WriteLine("Introduce la segunda fecha (dd-MM-yyyy):");
            string Fecha2 = Console.ReadLine();

            DateTime F1, F2;
            F1 = DateTime.Parse(Fecha1);
            F2 = DateTime.Parse(Fecha2);
            int comparacion = DateTime.Compare(F1, F2);
            if (comparacion == 0)
            {
                Console.WriteLine("Las fechas son iguales");
            }
            else if (comparacion > 0)
            {
                Console.WriteLine("La fecha es mayor");
            }
            else
            {
                Console.WriteLine("La fecha es menor");
            }
        }
        private void FormatoLargo()
        {
            Console.WriteLine("Introduce una fecha (dd-MM-yyyy):");
            string fechaTexto = Console.ReadLine();

            DateTime fecha;
            fecha = DateTime.Parse(fechaTexto);
            Console.WriteLine("Fecha formateada: " + fecha.ToString("dddd, MMM dd, yyyy"));
        }

        

        

        

        
    }
}
