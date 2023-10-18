namespace PruebasVarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.peepo;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}