using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmCajas : Form
    {
        public frmCajas()
        {
            InitializeComponent();
            this.lstArticulos.Items.Add("Mesa");
            this.lstArticulos.Items.Add("Coche");
            this.lstArticulos.Items.Add("Libro");
            this.lstArticulos.Items.Add("Maceta");
            this.lstArticulos.Items.Add("Silla");
            this.lstArticulos.Items.Add("Estantería");
            this.lstArticulos.Items.Add("Lámpara");
            this.lstArticulos.Items.Add("Rotuladores");
        }

        private void lstArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ParentForm != null && lstArticulos.SelectedItem != null)
            {
                this.ParentForm.Text = "El elemento seleccionado es: " + lstArticulos.SelectedItem.ToString();
            }
        }

        private void rbSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSimple.Checked) { 
                rbMúltiple.Checked = false;
                rbExtendida.Checked = false;
            }
        }

        private void rbMúltiple_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMúltiple.Checked) {
                rbSimple.Checked = false;
                rbExtendida.Checked = false;
            }
        }

        private void rbExtendida_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExtendida.Checked) {
                rbSimple.Checked = false;
                rbMúltiple.Checked = false;
            }
        }
    }
}
