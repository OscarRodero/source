using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgenciaViajes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            listaDestinos.Items.Add("Ciudad");
            listaDestinos.Items.Add("Montaña");
            listaDestinos.Items.Add("Playa");
            listaDestinos.Items.Add("Tour");
            pBox.Image = imageList1.Images[0];
            DateTime horaActual = DateTime.Now;
            reloj.Text = horaActual.ToString("HH:mm:ss");
        }
        private void acuerdoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcuerdoEmpresa n = new frmAcuerdoEmpresa();
            n.ShowDialog();
        }
        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Está a punto de salir de la aplicación. ¿Desea continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void listaDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int destino = listaDestinos.SelectedIndex;
            if (destino >= 0 && destino < imageList1.Images.Count)
            {
                pBox.Image = imageList1.Images[destino];
            }
            else
            {
                pBox.Image = null;
            }
            string elementoSeleccionado = listaDestinos.SelectedItem.ToString();
            string textoActual = txtResumen.Text;
            txtResumen.Text = elementoSeleccionado + Environment.NewLine + textoActual;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            pb.Value = 0;
            pb.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                pb.Value = i;
                System.Threading.Thread.Sleep(50);
                Application.DoEvents();
            }
        }

        private void contador_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            reloj.Text = horaActual.ToString("HH:mm:ss");
        }
    }
}
