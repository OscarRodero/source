using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultasAvanzadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using(videoclubEntities objDB = new videoclubEntities())
            {
                var consulta1 = from alq in objDB.alquileres
                                from soc in objDB.socios
                                where soc.idSocio == alq.socio
                                orderby soc.apell1
                                select new
                                {
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2
                                };
                dgv.DataSource = consulta1.Distinct().ToList();
            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var consulta1 = from alq in objDB.alquileres
                                from soc in objDB.socios
                                where soc.idSocio == alq.socio &&
                                alq.fechaDevolucion == null
                                orderby soc.apell1
                                select new
                                {
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2
                                };
                dgv.DataSource = consulta1.Distinct().ToList();
            }
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var subconsulta = from alq in objDB.alquileres
                                  select alq.socio;
                var consulta = from soc in objDB.socios
                               where !subconsulta.Contains(soc.idSocio)
                               orderby soc.apell1
                               select new
                               {
                                   soc.idSocio,
                                   soc.nombre,
                                   soc.apell1,
                                   soc.apell2
                               };
                dgv.DataSource = consulta.Distinct().ToList();
            }
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var consultaAlqSociosAgrupada = from alq in objDB.alquileres
                                                group alq by alq.socio into grupo
                                                select new
                                                {
                                                    IdSocio = grupo.Key,
                                                    NumVeces = grupo.Count()
                                                };
                var maxValor = consultaAlqSociosAgrupada.Max(x => x.NumVeces);
                var subConsulta = consultaAlqSociosAgrupada.Where(x=> x.NumVeces == maxValor);
                var consulta4 = from socmaxcant in subConsulta
                                from soc in objDB.socios
                                where socmaxcant.IdSocio == soc.idSocio
                                select new
                                {
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2,
                                    socmaxcant.NumVeces
                                };
                dgv.DataSource = consulta4.Distinct().ToList();
                dgv.Refresh();
            }
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var consulta = from alq in objDB.alquileres
                               group alq by alq.pelicula into grupo
                               select new {
                                   IdPelicula = grupo.Key,
                                   NumVeces = grupo.Count()
                               };
                var peliMasAlquilada = consulta.Max(x => x.NumVeces);
                var subConsulta = consulta.Where(x => x.NumVeces == peliMasAlquilada);
                var pelicula = from peli in subConsulta.ToList()
                               from pel in objDB.peliculas
                               where peli.IdPelicula == pel.codpeli
                               select new { 
                                    pel.titulo,
                                    pel.argumento,
                                    pel.director,
                                    pel.categoria,
                                    peli.NumVeces
                               };
                dgv.DataSource = pelicula.Distinct().ToList();
                dgv.Refresh();
            }
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var consulta = from est in objDB.peliculas
                               group est by est.estilo into grupo
                               select new
                               {
                                   Estilo = grupo.Key,
                                   NumVeces = grupo.Count()
                               };
                var max = consulta.Max(x => x.NumVeces);
                var consulta6 = consulta.Where(x => x.NumVeces == max);
                dgv.DataSource = consulta6.ToList();
            }
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var consultaPelis = from pel in objDB.peliculas
                                    select
                                    new
                                    {
                                        pel.titulo,
                                        pel.anio,
                                        pel.estilo,
                                        pel.categoria
                                    };
                var minValor = consultaPelis.Min(x => x.anio);
                var consulta7 = consultaPelis.Where(x=>x.anio == minValor);

                dgv.DataSource = consulta7.ToList();
                dgv.Refresh();
            }
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            using (videoclubEntities objDB = new videoclubEntities())
            {
                var consultaAlqSociosAgrupada = from alq in objDB.alquileres
                                        group alq by alq.socio into grupo
                                        select new { 
                                            IdSocio = grupo.Key,
                                            NumVeces = grupo.Count()
                                        };
                var mediaValor = consultaAlqSociosAgrupada.Average(x=> x.NumVeces);
                var consulta8 = from socagrupelis in consultaAlqSociosAgrupada.ToList()
                                from soc in objDB.socios
                                where socagrupelis.NumVeces >= mediaValor &&
                                socagrupelis.IdSocio == soc.idSocio
                                select
                                new { 
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2,
                                    socagrupelis.NumVeces
                                };

                dgv.Refresh();
            }
        }
    }
}
