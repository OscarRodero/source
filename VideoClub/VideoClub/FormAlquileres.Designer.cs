namespace VideoClub
{
    partial class FormAlquileres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Alquilar = new System.Windows.Forms.TabPage();
            this.Devolver = new System.Windows.Forms.TabPage();
            this.infoAlquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new VideoClub.dsBD();
            this.infoAlquileresTableAdapter = new VideoClub.dsBDTableAdapters.InfoAlquileresTableAdapter();
            this.tableAdapterManager = new VideoClub.dsBDTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAbrirBuscador = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apell1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apell2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAlquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Alquilar);
            this.tabControl1.Controls.Add(this.Devolver);
            this.tabControl1.Location = new System.Drawing.Point(1, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 200);
            this.tabControl1.TabIndex = 2;
            // 
            // Alquilar
            // 
            this.Alquilar.BackColor = System.Drawing.Color.Bisque;
            this.Alquilar.Location = new System.Drawing.Point(4, 22);
            this.Alquilar.Name = "Alquilar";
            this.Alquilar.Size = new System.Drawing.Size(792, 174);
            this.Alquilar.TabIndex = 0;
            this.Alquilar.Text = "Alquilar";
            // 
            // Devolver
            // 
            this.Devolver.Location = new System.Drawing.Point(4, 22);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(792, 174);
            this.Devolver.TabIndex = 1;
            this.Devolver.Text = "Devolver";
            this.Devolver.UseVisualStyleBackColor = true;
            // 
            // infoAlquileresBindingSource
            // 
            this.infoAlquileresBindingSource.DataMember = "InfoAlquileres";
            this.infoAlquileresBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoAlquileresTableAdapter
            // 
            this.infoAlquileresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alquileresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.estilosTableAdapter = null;
            this.tableAdapterManager.peliculasTableAdapter = null;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VideoClub.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(566, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 20);
            this.textBox4.TabIndex = 10;
            // 
            // btnAbrirBuscador
            // 
            this.btnAbrirBuscador.Location = new System.Drawing.Point(226, 7);
            this.btnAbrirBuscador.Name = "btnAbrirBuscador";
            this.btnAbrirBuscador.Size = new System.Drawing.Size(47, 23);
            this.btnAbrirBuscador.TabIndex = 11;
            this.btnAbrirBuscador.Text = "...";
            this.btnAbrirBuscador.UseVisualStyleBackColor = true;
            this.btnAbrirBuscador.Click += new System.EventHandler(this.btnAbrirBuscador_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlquilerDataGridViewTextBoxColumn,
            this.fechaAlquilerDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.codpeliDataGridViewTextBoxColumn,
            this.idSocioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apell1DataGridViewTextBoxColumn,
            this.apell2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoAlquileresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 265);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 184);
            this.dataGridView1.TabIndex = 12;
            // 
            // codAlquilerDataGridViewTextBoxColumn
            // 
            this.codAlquilerDataGridViewTextBoxColumn.DataPropertyName = "codAlquiler";
            this.codAlquilerDataGridViewTextBoxColumn.HeaderText = "codAlquiler";
            this.codAlquilerDataGridViewTextBoxColumn.Name = "codAlquilerDataGridViewTextBoxColumn";
            this.codAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAlquilerDataGridViewTextBoxColumn
            // 
            this.fechaAlquilerDataGridViewTextBoxColumn.DataPropertyName = "fechaAlquiler";
            this.fechaAlquilerDataGridViewTextBoxColumn.HeaderText = "fechaAlquiler";
            this.fechaAlquilerDataGridViewTextBoxColumn.Name = "fechaAlquilerDataGridViewTextBoxColumn";
            this.fechaAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "fechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "fechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codpeliDataGridViewTextBoxColumn
            // 
            this.codpeliDataGridViewTextBoxColumn.DataPropertyName = "codpeli";
            this.codpeliDataGridViewTextBoxColumn.HeaderText = "codpeli";
            this.codpeliDataGridViewTextBoxColumn.Name = "codpeliDataGridViewTextBoxColumn";
            this.codpeliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSocioDataGridViewTextBoxColumn
            // 
            this.idSocioDataGridViewTextBoxColumn.DataPropertyName = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.HeaderText = "idSocio";
            this.idSocioDataGridViewTextBoxColumn.Name = "idSocioDataGridViewTextBoxColumn";
            this.idSocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apell1DataGridViewTextBoxColumn
            // 
            this.apell1DataGridViewTextBoxColumn.DataPropertyName = "apell1";
            this.apell1DataGridViewTextBoxColumn.HeaderText = "apell1";
            this.apell1DataGridViewTextBoxColumn.Name = "apell1DataGridViewTextBoxColumn";
            this.apell1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apell2DataGridViewTextBoxColumn
            // 
            this.apell2DataGridViewTextBoxColumn.DataPropertyName = "apell2";
            this.apell2DataGridViewTextBoxColumn.HeaderText = "apell2";
            this.apell2DataGridViewTextBoxColumn.Name = "apell2DataGridViewTextBoxColumn";
            this.apell2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAbrirBuscador);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAlquileres";
            this.Text = "FormAlquileres";
            this.Load += new System.EventHandler(this.FormAlquileres_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoAlquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource infoAlquileresBindingSource;
        private dsBDTableAdapters.InfoAlquileresTableAdapter infoAlquileresTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Alquilar;
        private System.Windows.Forms.TabPage Devolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAbrirBuscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apell1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apell2DataGridViewTextBoxColumn;
    }
}