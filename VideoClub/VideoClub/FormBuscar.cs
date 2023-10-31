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
        public string idSocio { get; set; }
        public string nombreSocio { get; set; }
        public string apell1Socio { get; set; }
        public string apell2Socio { get; set; }
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
            if (this.txtIDCliente.Text != string.Empty)
            {
                int codCliente = int.Parse(this.txtIDCliente.Text);
                this.sociosTableAdapter.FillByIDSOCIO(this.dsBD.socios, codCliente);
            }
            else 
            {
                
            }
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGV.SelectedRows.Count > 0)
            {
                this.idSocio = DGV.SelectedRows[0].Cells[0].Value.ToString();
                this.nombreSocio = DGV.SelectedRows[0].Cells[1].Value.ToString();
                this.apell1Socio = DGV.SelectedRows[0].Cells[2].Value.ToString();
                this.apell2Socio = DGV.SelectedRows[0].Cells[3].Value.ToString();                
            }
            this.Close();
        }
    }
}
