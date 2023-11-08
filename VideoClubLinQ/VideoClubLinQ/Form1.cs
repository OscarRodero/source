using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClubLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using(videoclubEntities objBD = new videoclubEntities())
            {
                //Creamos el objeto categoría
                categorias objCat = new categorias();
                objCat.categoria = etxtCategoria.Text;
                objCat.precio = (decimal?)float.Parse(etxtPrecio.Text);
                //Se añade el nuevo objeto a la tabla
                objBD.categorias.Add(objCat);
                //Guardamos los cambios 
                objBD.SaveChanges();
                MessageBox.Show("Categoría insertada correctamente");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (videoclubEntities objBD = new videoclubEntities())
            {
                //Recuperamos el objeto de la BD, filtrando por el campo categoría
                categorias objCat = objBD.categorias.Find(etxtCategoria.Text);
                if (objCat != null)
                {
                    objCat.precio = (decimal?)float.Parse(etxtPrecio.Text);
                    //Se guardan los cambios
                    objBD.SaveChanges();
                    MessageBox.Show("Categoría modificada correctamente");
                }
                else {
                    MessageBox.Show("No se ha encontrado la categoría");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (videoclubEntities objBD = new videoclubEntities())
            {
                //Recuperamos el objeto de la BD, filtrando por el campo categoría
                categorias objCat = objBD.categorias.Find(etxtCategoria.Text);
                if (objCat != null)
                {
                    //Se elimina el objeto de la tabla
                    objBD.categorias.Remove(objCat);
                    //Se guardan los cambios
                    objBD.SaveChanges();
                    MessageBox.Show("Categoría eliminada correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la categoría");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {      
            
            using (videoclubEntities objBD = new videoclubEntities())
            {
                var resultado = from cat in objBD.categorias
                                where cat.categoria.ToUpper().StartsWith(etxtCampoCategoria.Text.Trim().ToUpper())
                                select new { cat.categoria, cat.precio };
                var lista = resultado.ToList();
                dgvFiltro1.DataSource = lista;
                dgvFiltro1.Refresh();
            }
        }

        private void btnBuscarXPrecio_Click(object sender, EventArgs e)
        {
            using (videoclubEntities objBD = new videoclubEntities())
            {
                if(!string.IsNullOrEmpty(etxtCampoPrecio.Text))
                {
                    if (decimal.TryParse(etxtCampoPrecio.Text, out decimal precio)) {
                        var resultado = from cat in objBD.categorias
                                        where cat.precio >= precio
                                        orderby cat.precio, cat.categoria
                                        select new { cat.categoria, cat.precio };

                        //Otra forma de hacerlo:
                        //var resultado = objDB.categorias.Where(c => c.precio >= precio).OrderBy(c=> c.precio).ThenBy(c=>c.categoria).Select(c=>new {c.categoria, c.precio});

                        var lista = resultado.ToList();
                        dgvFiltro1.DataSource = lista;
                        dgvFiltro1.Refresh();
                    }
                }                                
            }
        }

        private void btnBuscarXcat_Click(object sender, EventArgs e)
        {
            using (videoclubEntities objBD = new videoclubEntities())
            {
                if (!string.IsNullOrEmpty(etxtMultitablaCategoría.Text))
                {
                    var resultado = from cat in objBD.categorias
                                    join pel in objBD.peliculas on cat.categoria equals pel.categoria
                                    where cat.categoria.ToUpper().StartsWith(etxtMultitablaCategoría.Text.Trim().ToUpper())
                                    select new { 
                                        Titulo = pel.titulo,
                                        Año = pel.anio,
                                        Estilo = pel.estilo,
                                        Categoría = cat.categoria,
                                        Precio = cat.precio
                                    };
                    var lista = resultado.ToList();
                    dgvFiltro2.DataSource = lista;
                    dgvFiltro2.Refresh();

                }
            }
        }
    }
}
