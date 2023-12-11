using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador
{
    /// <summary>
    /// Formulario que contiene los controles para el saludo
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método asociado al evento click del botón "Saludame"
        /// </summary>
        /// <param name="sender">Objeto que lanza el evento</param>
        /// <param name="e">Parámetros asociados al evento</param>
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOOOOOOOOOOOOOOOLAAAAAAAAAAAAA!!!!!!!!!");
        }

        /// <summary>
        /// Método que convierte una cadena con la edad a un tipo entero.
        /// </summary>
        /// <param name="strEdad">Cadena con el valor de la edad</param>
        /// <returns>Número entero con el valor de la edad</returns>
        private int calcularEdad(string strEdad) 
        {
            int result = int.Parse(strEdad);
            return result;
        }
    }
}
