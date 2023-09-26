using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class Alquiler
    {
		private String nombre;
		private String dni;
		private DateTime fechaIni;
		private DateTime fechaFin;
		private int posicion;
		private Barco embarcacion;
		private int cantidadMastiles;
		private int cv;
		private int numCamarotes;

		public Alquiler(string nombre, string dNI, DateTime fechaIni, DateTime fechaFin, int posicion, Barco embarcacion, int cantidadMastiles, int cV, int numCamarotes)
		{
			Nombre = nombre;
			DNI = dNI;
			FechaIni = fechaIni;
			FechaFin = fechaFin;
			Posicion = posicion;
			Embarcacion = embarcacion;
			CantidadMastiles = cantidadMastiles;
			CV = cV;
			NumCamarotes = numCamarotes;
		}

		public Barco Embarcacion
		{
			get { return embarcacion; }
			set { embarcacion = value; }
		}

		public int Posicion
		{
			get { return posicion; }
			set { posicion = value; }
		}

		public DateTime FechaFin
		{
			get { return fechaFin; }
			set { fechaFin = value; }
		}


		public DateTime FechaIni
		{
			get { return fechaIni; }
			set { fechaIni = value; }
		}

		public String DNI
		{
			get { return dni; }
			set { dni = value; }
		}


		public String Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
        public int NumCamarotes
        {
            get { return numCamarotes; }
            set { numCamarotes = value; }
        }


        public int CV
        {
            get { return cv; }
            set { cv = value; }
        }


        public int CantidadMastiles
        {
            get { return cantidadMastiles; }
            set { cantidadMastiles = value; }
        }
        public float calcularModulo() {
			float x = 0F;
			TimeSpan diff = fechaFin - FechaIni;
			float modulo = this.embarcacion.MetrosEslora * 10;			
			if (this.embarcacion.TipoBarco != Barco.barquino.Normal) {
				switch (this.embarcacion.TipoBarco) {
					case Barco.barquino.Velero:
						modulo = modulo + this.NumCamarotes;
						break;
					case Barco.barquino.Deportivo:
						modulo = modulo + this.CV;
						break;
					case Barco.barquino.Yate_de_lujo:
						modulo = modulo + this.NumCamarotes;
						break;
				}
			}
            float Total = diff.Days * modulo * 12F;
            return x;
		}
	}
}
