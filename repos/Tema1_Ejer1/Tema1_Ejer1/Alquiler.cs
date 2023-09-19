using System;
using System.Collections.Generic;
using System.Linq;
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

	}
}
