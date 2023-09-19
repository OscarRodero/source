using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_Ejer1
{
    public class Barco
    {
		public enum barquino { 
		
		}
		private barquino tipoBarco;

		public barquino TipoBarco
		{
			get { return tipoBarco; }
			set { tipoBarco = value; }
		}


		private int metrosEslora;

		public int MetrosEslora
		{
			get { return metrosEslora; }
			set { metrosEslora = value; }
		}

	}
}
