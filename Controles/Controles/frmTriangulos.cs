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
    }
}
