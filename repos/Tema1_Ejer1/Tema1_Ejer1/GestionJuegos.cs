using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class GestionJuegos
    {
        enum Generos{ Acción, Arcade, Estrategia, Aventura, Deportes , Simulación }
        enum Plataformas { PC, PlayStation, XBox, Nintendo}
        List<Juego> ListadoJuegos = new List<Juego>();
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
            //Título
            Console.WriteLine("Tílulo del juego:");
            String titulo = Console.ReadLine();
            while (titulo == "" || titulo == null) {
                Console.WriteLine("Introduce un título por favor.");
                titulo = Console.ReadLine();
            }
            //Lanzamiento
            Console.WriteLine("Año de lanzamiento");
            int primerAnioVideojuego = 1958;
            int anioActual = DateTime.Now.Year;
            int anio;
            bool anioCorrecto = true;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out anio) || anio < primerAnioVideojuego || anio > anioActual)
                {
                    Console.WriteLine($"Año inválido, por favor, introduce un año válido entre {primerAnioVideojuego} y {anioActual}");
                    anioCorrecto = false;
                }
                else
                {
                    anioCorrecto = true;
                }
            } while (!anioCorrecto);
            //Género
            Console.WriteLine("Género:");
            String genero = SeleccionarGenero();
            while (genero == "" || genero == null)
            {
                Console.WriteLine("Introduce un género por favor.");
                genero = Console.ReadLine();
            }
            //Plataforma
            String plataforma = SeleccionarPlataforma();
            
            Juego n = new(titulo,anio,genero,plataforma);
            ListadoJuegos.Add(n);
        }

        private string SeleccionarPlataforma()
        {
            string plataforma = "";

            do
            {
                Console.WriteLine("Selecciona una plataforma por favor:");
                int x = 0;
                foreach (Plataformas plat in Enum.GetValues(typeof(Plataformas)))
                {
                    x++;
                    Console.WriteLine(x + ".-" + plat);
                }

                string plataformaElegida = Console.ReadLine();

                if (int.TryParse(plataformaElegida, out int res) && res >= 1 && res <= Enum.GetValues(typeof(Plataformas)).Length)
                {
                    plataforma = Enum.GetValues(typeof(Plataformas)).GetValue(res - 1).ToString();
                    break;
                }

                Console.WriteLine("Opción no válida, selecciona una plataforma válida.");
            } while (true);

            return plataforma;
        }


        private string SeleccionarGenero()
        {
            bool salir = false;
            int res;
            String respuesta;
            do {
                Console.WriteLine("Selecciona un género:");
                int x = 0;
                foreach (Generos gen in Enum.GetValues(typeof(Generos)))
                {
                    x++;
                    Console.WriteLine(x + ".-" + gen);
                }
                respuesta = Console.ReadLine();
                if (int.TryParse(respuesta, out res))
                {
                    if (res >= 1 && res <= Enum.GetValues(typeof(Generos)).Length)
                    {
                        respuesta = Enum.GetValues(typeof(Generos)).GetValue(res - 1).ToString();
                        Console.WriteLine("Seleccionado: "+respuesta);
                        break; 
                    }
                }
                if (res != null) { salir = true; }
            } while (!salir);                        
            return respuesta;
        }

        private void VerListado()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("                Juegos                 ");
            Console.WriteLine("=======================================");
            foreach (Juego juego in ListadoJuegos) {
                Console.WriteLine(juego.Titulo+ "||" +juego.Anio + "||" + juego.Genero+ "||" +juego.Plataforma);
                Console.WriteLine("=======================================");
            }
        }
        private void Modificar()
        {
            Console.WriteLine("Seleccione el número del juego que desea modificar:");
            int i = 1;
            foreach (Juego juego in ListadoJuegos)
            {
                Console.WriteLine(i+".-"+juego.Titulo);
                i++;
            }

            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {
                if (seleccion >= 1 && seleccion <= ListadoJuegos.Count)
                {
                    Juego juegoSeleccionado = ListadoJuegos[seleccion - 1]; // Obtiene el juego seleccionado

                    Console.WriteLine("¿Qué atributo desea modificar?");
                    Console.WriteLine("1.- Título");
                    Console.WriteLine("2.- Año de lanzamiento");
                    Console.WriteLine("3.- Género");
                    Console.WriteLine("4.- Plataforma");

                    if (int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Nuevo título:");
                                juegoSeleccionado.Titulo = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Nuevo año de lanzamiento:");
                                int nuevoAnio;
                                if (int.TryParse(Console.ReadLine(), out nuevoAnio))
                                {
                                    juegoSeleccionado.Anio = nuevoAnio;
                                }
                                else
                                {
                                    Console.WriteLine("Año inválido.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Nuevo género:");
                                juegoSeleccionado.Genero = SeleccionarGenero();
                                break;
                            case 4:
                                Console.WriteLine("Nueva plataforma:");
                                juegoSeleccionado.Plataforma = SeleccionarPlataforma();
                                break;
                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Número de juego no válido.");
                }
            }
            else
            {
                Console.WriteLine("Número de juego no válido.");
            }
        }

        private void Borrar()
        {
            Console.WriteLine("Seleccione el número del juego que desea borrar:");
            int i = 1;
            foreach (Juego juego in ListadoJuegos)
            {
                Console.WriteLine($"{i}. {juego.Titulo}");
                i++;
            }

            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {
                if (seleccion >= 1 && seleccion <= ListadoJuegos.Count)
                {
                    Juego juegoSeleccionado = ListadoJuegos[seleccion - 1]; // Obtiene el juego seleccionado

                    Console.WriteLine($"¿Está seguro de que desea eliminar el juego: {juegoSeleccionado.Titulo}? (S/N)");
                    string respuesta = Console.ReadLine().Trim().ToLower();

                    if (respuesta == "s")
                    {
                        ListadoJuegos.RemoveAt(seleccion - 1); // Elimina el juego de la lista
                        Console.WriteLine("Juego eliminado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Operación de eliminación cancelada.");
                    }
                }
                else
                {
                    Console.WriteLine("Número de juego no válido.");
                }
            }
            else
            {
                Console.WriteLine("Número de juego no válido.");
            }
        }

    }
}
