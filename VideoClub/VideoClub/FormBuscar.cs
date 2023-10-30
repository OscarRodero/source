using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dsBD.socios);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.InfoAlquileres' Puede moverla o quitarla según sea necesario.
            this.infoAlquileresTableAdapter.FillTabla(this.dsBD.InfoAlquileres);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtIDCliente.Text != "") { 
                
            }
        }
    }
}
