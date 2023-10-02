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
    public partial class frmTriangulos : Form
    {
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void btnComprobarTriangulo_Click(object sender, EventArgs e)
        {
            if(txtLado1==txtLado2 && txtLado2==txtLado3)
            {
                lblResultado.Text = "El triángulo es Equilátero.";
            }
            if (txtLado1 != txtLado2 && txtLado2 != txtLado3 && txtLado1!=txtLado3) {
                lblResultado.Text = "El triángulo es Escaleno.";
            }
            if (txtLado1 == txtLado2 || txtLado2 == txtLado3 || txtLado1 == txtLado3)
            {
                lblResultado.Text = "El triángulo es Isósceles.";
            }
        }

        private void chek1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chek2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chek3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

 
    }
}
