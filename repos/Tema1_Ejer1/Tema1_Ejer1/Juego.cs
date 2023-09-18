using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class Juego
    {
		private String titulo;
		private int anio;
		private String genero;

        public Juego(string? titulo, int anio, string? genero)
        {
            this.titulo = titulo;
            this.anio = anio;
            this.genero = genero;
        }

        public String Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		public int Anio
		{
			get { return anio; }
			set { anio = value; }
		}
		public String Genero
		{
			get { return genero; }
			set { genero = value; }
		}
	}
}
