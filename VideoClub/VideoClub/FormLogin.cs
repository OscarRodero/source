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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dsBD ds = new dsBD();
            dsBDTableAdapters.sociosTableAdapter sta = new dsBDTableAdapters.sociosTableAdapter();
            //Se ejecuta la consulta sobre la tabla "socios" y se guardan los registros que devuelve en ds.socios
            
            sta.FillByLogin(ds.socios, txtLogin.Text);
            if (ds.socios.Count > 0)
            {
                sta.FillByLoginPW(ds.socios, txtLogin.Text, txtPW.Text);
                if (ds.socios.Count > 0)
                {
                    MessageBox.Show("Hola " + ds.socios[0].nombre);
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else {
                MessageBox.Show("Login incorrecto");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
