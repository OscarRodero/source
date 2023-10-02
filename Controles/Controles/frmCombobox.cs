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

namespace Controles
{
    public partial class frmCombobox : Form
    {
        public frmCombobox()
        {
            InitializeComponent();
            this.MdiParent = Form1.ActiveForm;
            string[] colores = { "Azul", "Negro", "Rojo", "Verde" };
            cb1.Items.AddRange(colores);
            cb2.Items.AddRange(colores);
            cb3.Items.AddRange(colores);

            cb1.SelectedIndex = 0;
            cb2.SelectedIndex = 0;
            cb3.SelectedIndex = 0;

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cb1.Items.Add(txtAddTexto.Text);
            cb2.Items.Add(txtAddTexto.Text);
            cb3.Items.Add(txtAddTexto.Text);
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtElegido.Text = cb1.SelectedText;
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtElegido.Text = cb2.SelectedText;
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtElegido.Text = cb3.SelectedText;
        }
    }
}
