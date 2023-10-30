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
    public partial class FormDataGridView : Form
    {
        public FormDataGridView()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void FormDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);

        }
    }
}
