using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class GestionJuegos
    {
        enum Generos
        { 
             Acción, Arcade, Estrategia, Aventura, Deportes , Simulación
        }
        Juego[] ListadoJuegos; 
        public void Menu()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine();
                Console.WriteLine("1.- Insertar juego");
                Console.WriteLine("2.- Ver listado de juegos");
                Console.WriteLine("3.- Modificar juego");
                Console.WriteLine("4.- Eliminar juego");
                Console.WriteLine("5.- Atrás");
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
                                InsertarJuego();
                                break;
                            case 2:
                                VerListado();
                                break;
                            case 3:
                                Modificar();
                                break;
                            case 4:
                                Borrar();
                                break;
                            case 5:
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
        private void InsertarJuego()
        {
            Console.WriteLine("Tílulo del juego:");
            String titulo = Console.ReadLine();
            Console.WriteLine("Año de lanzamiento");
            int anio;
            if (!int.TryParse(Console.ReadLine().ToString(), out anio)) {
                Console.WriteLine("Anio inválido");
                anio = 0;
            }
            Console.WriteLine("Género:");
            String genero = SeleccionarJuego();

            Juego n = new(titulo,anio,genero);
        }

        private string SeleccionarJuego()
        {
            bool salir = false;
            int res;
            do {
                Console.WriteLine("Selecciona un género:");
                int x = 0;
                foreach (Generos gen in Enum.GetValues(typeof(Generos)))
                {
                    x++;
                    Console.WriteLine(x + ".-" + gen);
                }
                String respuesta = Console.ReadLine();
                int.TryParse(respuesta, out res);
                if (res != null) { salir=true}
            } while (!salir);            
            
            return "hola";
        }

        private void VerListado()
        {
            throw new NotImplementedException();
        }
        private void Modificar()
        {
            throw new NotImplementedException();
        }
        private void Borrar()
        {
            throw new NotImplementedException();
        }
    }
}
