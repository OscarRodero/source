using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class FormAlquileres : Form
    {
        public FormAlquileres()
        {
            InitializeComponent();
        }

        private void FormAlquileres_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.InfoAlquileres' Puede moverla o quitarla según sea necesario.
            this.infoAlquileresTableAdapter.FillTabla(this.dsBD.InfoAlquileres);

        }

        private void btnAbrirBuscador_Click(object sender, EventArgs e)
        {
            FormBuscar Buscar = new FormBuscar();
            if(Buscar.ShowDialog() == DialogResult.Cancel)
            {
                if (Buscar.idSocio != null) 
                {
                    this.txtCodCli.Text = Buscar.idSocio.ToString();
                    this.txtNombCli.Text = Buscar.nombreSocio.ToString();
                    this.txtApell1Cli.Text = Buscar.apell1Socio.ToString();
                    this.txtApell2Cli.Text = Buscar.apell2Socio.ToString();

                    cargarDGV();
                }
            }
        }

        private void cargarDGV()
        {
            this.infoAlquileresTableAdapter.FillByIdSocio(this.dsBD.InfoAlquileres, int.Parse(this.txtCodCli.Text));
        }
    }
}
