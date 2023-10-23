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
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dsBD.socios);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            int idsocio = this.dsBD.socios[int.Parse(sociosBindingNavigator.PositionItem.Text) - 1].idSocio;
            dsBD ds = new dsBD();
            dr = MessageBox.Show("¿Estás seguro de borrar este registro?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                dsBDTableAdapters.alquileresTableAdapter sta = new dsBDTableAdapters.alquileresTableAdapter();
                sta.FillBySocio(ds.alquileres,idsocio);
                if (ds.alquileres.Count() == 0)
                {
                    this.sociosTableAdapter.Delete(idsocio);
                    this.sociosTableAdapter.Fill(this.dsBD.socios);
                    MessageBox.Show("Socio eliminado");
                }
                else {
                    dr = MessageBox.Show("Este socio contiene alquileres relacionados. ¿Quiere continuar?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.OK) {
                        this.alquileresTableAdapter1.DeleteQueryBySocio(idsocio);
                        this.alquileresTableAdapter1.Fill(this.dsBD.alquileres);
                        this.sociosTableAdapter.Delete(idsocio);
                        this.sociosTableAdapter.Fill(this.dsBD.socios);
                    }
                }    
            }
            else {
                MessageBox.Show("Cancelado");
            }
            this.sociosTableAdapter.Fill(this.dsBD.socios);
        }
    }
}
