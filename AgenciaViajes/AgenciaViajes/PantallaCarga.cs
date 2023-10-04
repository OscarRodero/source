namespace AgenciaViajes
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void PantallaCarga_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            temporizador.Stop();
            frmPrincipal n = new frmPrincipal();
            n.Show();
            this.Hide();
        }
    }
}