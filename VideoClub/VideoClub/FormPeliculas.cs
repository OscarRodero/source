﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.dsBDTableAdapters;

namespace VideoClub
{
    public partial class FormPeliculas : Form
    {
        //ArrayList lst_listaPelis = new ArrayList();
        public FormPeliculas()
        {
            InitializeComponent();
        }       

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.dsBD.categorias);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.estilos' Puede moverla o quitarla según sea necesario.
            this.estilosTableAdapter.Fill(this.dsBD.estilos);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);

            //foreach (var pelicula in dsBD.peliculas)
            //{
            //    cbMostrarPeli.Items.Add(pelicula.titulo);
            //}

            cargarComboPeliculasBueno();

        }

        private void btnNuevaCaratula_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                caratulaPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            int codigopeli = this.dsBD.peliculas[int.Parse(peliculasBindingNavigator.PositionItem.Text) - 1].codpeli;
            dsBD ds = new dsBD();
            dr = MessageBox.Show("¿Estás seguro de borrar este registro?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                dsBDTableAdapters.alquileresTableAdapter sta = new dsBDTableAdapters.alquileresTableAdapter();
                sta.FillByPelicula(ds.alquileres, codigopeli);
                if (ds.peliculas.Count() == 0)
                {
                    this.peliculasTableAdapter.DeleteByPelicula(codigopeli);
                    this.peliculasTableAdapter.Fill(this.dsBD.peliculas);
                    MessageBox.Show("Película eliminada");
                }
                else { 
                   if(MessageBox.Show("Si eliminas la película se eliminarán también sus alquileres, ¿Deseas continuar?", 
                       "Confirmación Necesaria", 
                       MessageBoxButtons.OKCancel, 
                       MessageBoxIcon.Information) == DialogResult.OK) { 
                        sta.DeleteByPelis(codigopeli);
                        this.peliculasTableAdapter.DeleteByPelicula(codigopeli);
                        this.peliculasTableAdapter.Fill(this.dsBD.peliculas);
                    }
                }

            }
            //cargarComboPeliculasMalo();
            cargarComboPeliculasBueno();
        }

        private void cargarComboPeliculasBueno()
        {
            cbMostrarPeli.Items.Clear();
            foreach(var peli in this.dsBD.peliculas)
            {
                ComboItem item = new ComboItem(peli.titulo, peli.codpeli);
                cbMostrarPeli.Items.Add(item);
            }
            
        }

        private void cbMostrarPeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Método chapuza:
            //string titulo = cbMostrarPeli.SelectedItem.ToString();
            //dsBDTableAdapters.peliculasTableAdapter ListadoPelis = new dsBDTableAdapters.peliculasTableAdapter();
            //ListadoPelis.FillByTitulo(this.dsBD.peliculas, titulo);

            //Método regulinchi:
            //int intIdPelicula = (int)lst_listaPelis[cbMostrarPeli.SelectedIndex];
            //this.peliculasTableAdapter.FillByCodPeli(this.dsBD.peliculas, intIdPelicula);

            //Método good:
            int intIdPelicula = (int)((ComboItem)cbMostrarPeli.SelectedItem).Value;
            this.peliculasTableAdapter.FillByCodPeli(this.dsBD.peliculas, intIdPelicula);
        }

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            dsBDTableAdapters.peliculasTableAdapter ListadoPelis = new dsBDTableAdapters.peliculasTableAdapter();
            ListadoPelis.Fill(this.dsBD.peliculas);
            cbMostrarPeli.Text = string.Empty;
            //cargarComboPeliculasMalo();
            cargarComboPeliculasBueno();
        }
        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);
            //cargarComboPeliculasMalo();
            cargarComboPeliculasBueno();
        }
        //private void cargarComboPeliculasMalo() { 
        //    cbMostrarPeli.Items.Clear();
        //    foreach (var peli in this.dsBD.peliculas) { 
        //        cbMostrarPeli.Items.Add(peli.titulo);
        //    }
        //}
    }
}
