namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void OpenChildForm(Form childForm)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != childForm.Name)
                {
                    DialogResult result = MessageBox.Show("�Desea cerrar el formulario actual?", "�Atenci�n!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        childForm.MdiParent = this;
                        childForm.Dock = DockStyle.Fill;
                        childForm.Show();
                    }
                }
            }
            else
            {
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }

        private void OpenFormAndCheck(Form childForm)
        {
            OpenChildForm(childForm);
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTextBox());
        }

        private void btnTriangulos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTriangulos());
        }

        private void btnColores_Click(object sender, EventArgs e)
        {

        }

        private void btnListas_Click(object sender, EventArgs e)
        {

        }

        private void btnCajas_Click(object sender, EventArgs e)
        {

        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {

        }

        private void btnCalendarios_Click(object sender, EventArgs e)
        {

        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {

        }

        private void btnGama_Click(object sender, EventArgs e)
        {

        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {

        }
    }
}