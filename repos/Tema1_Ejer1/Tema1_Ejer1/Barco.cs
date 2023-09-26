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
			Normal, Velero, Deportivo, Yate_de_lujo
		}
        private barquino tipoBarco;        
        private string matricula;
        private int metrosEslora;
        private int anioFabricacion;

		public string Matricula
		{
			get { return matricula; }
			set { matricula = value; }
		}
		public int MetrosEslora
		{
			get { return metrosEslora; }
			set { metrosEslora = value; }
		}
		public int AnioFabricacion
		{
			get { return anioFabricacion; }
			set { anioFabricacion = value; }
		}
        public barquino TipoBarco
		{
			get { return tipoBarco; }
			set { tipoBarco = value; }
		}

		public Barco(string matricula, int metrosEslora, int anioFabricacion, barquino tipoBarco)
		{
			Matricula = matricula;
			MetrosEslora = metrosEslora;
			AnioFabricacion = anioFabricacion;
			TipoBarco = tipoBarco;
		}
	}
}
