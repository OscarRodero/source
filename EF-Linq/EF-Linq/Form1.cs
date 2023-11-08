using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void btnCambiarCaratula_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    Caratula.Image = Image.FromFile(rutaImagen);
                }
            }
        }

        private void btnInsertarPelicula_Click(object sender, EventArgs e)
        {
            using (videoclubEntities objBD = new videoclubEntities())
            {
                peliculas objPel = new peliculas();
                objPel.titulo = etxtTitulo.Text;
                objPel.director = etxtDirector.Text;
                objPel.protagonista = etxtProta.Text;
                objPel.anio = int.Parse(etxtAnio.Text);
                objPel.stock = (int)nUpDownStock.Value;
                objPel.estilo = cboxEstilo.Text;
                objPel.categoria = cboxCategoria.Text;
                objPel.argumento = etxtArgumento.Text;
                if (Caratula.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Caratula.Image.Save(ms, ImageFormat.Jpeg);
                        objPel.caratula = ms.ToArray();
                    }
                }

                objBD.peliculas.Add(objPel);
                objBD.SaveChanges();
                MessageBox.Show("Película insertada con éxito");
            }
        }
        private void CargarCombos() {
            using (videoclubEntities objBD = new videoclubEntities()) {
                foreach (var cat in objBD.categorias.OrderBy(x => x.categoria))
                {
                    cboxCategoria.Items.Add(cat.categoria);
                }
                foreach (var est in objBD.estilos.OrderBy(x => x.estilo))
                {
                    cboxEstilo.Items.Add(est.estilo);
                }
            }            
        }
        
    }
}
