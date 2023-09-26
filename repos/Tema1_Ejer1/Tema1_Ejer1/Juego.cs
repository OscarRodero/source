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
		private String plataforma;

		


		public Juego(string titulo, int anio, string genero, string plataforma)
        {
            this.titulo = titulo;
            this.anio = anio;
            this.genero = genero;
			this.plataforma = plataforma;
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
        public String Plataforma
        {
            get { return plataforma; }
            set { plataforma = value; }
        }
    }
}
