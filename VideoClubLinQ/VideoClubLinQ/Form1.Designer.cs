namespace VideoClubLinQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.etxtCategoria = new System.Windows.Forms.TextBox();
            this.etxtPrecio = new System.Windows.Forms.TextBox();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.etxtCampoCategoria = new System.Windows.Forms.TextBox();
            this.etxtCampoPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarXPrecio = new System.Windows.Forms.Button();
            this.dgvFiltro1 = new System.Windows.Forms.DataGridView();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.dgvFiltro2 = new System.Windows.Forms.DataGridView();
            this.btnBuscarXcat = new System.Windows.Forms.Button();
            this.etxtMultitablaCategoría = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro1)).BeginInit();
            this.gbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // etxtCategoria
            // 
            this.etxtCategoria.Location = new System.Drawing.Point(142, 34);
            this.etxtCategoria.Name = "etxtCategoria";
            this.etxtCategoria.Size = new System.Drawing.Size(100, 20);
            this.etxtCategoria.TabIndex = 2;
            // 
            // etxtPrecio
            // 
            this.etxtPrecio.Location = new System.Drawing.Point(142, 74);
            this.etxtPrecio.Name = "etxtPrecio";
            this.etxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.etxtPrecio.TabIndex = 3;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.btnDelete);
            this.gbox.Controls.Add(this.btnUpdate);
            this.gbox.Controls.Add(this.btnInsert);
            this.gbox.Location = new System.Drawing.Point(65, 123);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(177, 144);
            this.gbox.TabIndex = 4;
            this.gbox.TabStop = false;
            this.gbox.Text = "Operaciones Simples";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(60, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(60, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Campo Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // etxtCampoCategoria
            // 
            this.etxtCampoCategoria.Location = new System.Drawing.Point(164, 283);
            this.etxtCampoCategoria.Name = "etxtCampoCategoria";
            this.etxtCampoCategoria.Size = new System.Drawing.Size(100, 20);
            this.etxtCampoCategoria.TabIndex = 7;
            // 
            // etxtCampoPrecio
            // 
            this.etxtCampoPrecio.Location = new System.Drawing.Point(164, 309);
            this.etxtCampoPrecio.Name = "etxtCampoPrecio";
            this.etxtCampoPrecio.Size = new System.Drawing.Size(100, 20);
            this.etxtCampoPrecio.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 280);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarXPrecio
            // 
            this.btnBuscarXPrecio.Location = new System.Drawing.Point(293, 309);
            this.btnBuscarXPrecio.Name = "btnBuscarXPrecio";
            this.btnBuscarXPrecio.Size = new System.Drawing.Size(127, 23);
            this.btnBuscarXPrecio.TabIndex = 10;
            this.btnBuscarXPrecio.Text = "BUSCAR X PRECIO";
            this.btnBuscarXPrecio.UseVisualStyleBackColor = true;
            this.btnBuscarXPrecio.Click += new System.EventHandler(this.btnBuscarXPrecio_Click);
            // 
            // dgvFiltro1
            // 
            this.dgvFiltro1.AllowUserToAddRows = false;
            this.dgvFiltro1.AllowUserToDeleteRows = false;
            this.dgvFiltro1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiltro1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro1.Location = new System.Drawing.Point(68, 338);
            this.dgvFiltro1.MultiSelect = false;
            this.dgvFiltro1.Name = "dgvFiltro1";
            this.dgvFiltro1.ReadOnly = true;
            this.dgvFiltro1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro1.Size = new System.Drawing.Size(352, 84);
            this.dgvFiltro1.TabIndex = 11;
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.dgvFiltro2);
            this.gbox2.Controls.Add(this.btnBuscarXcat);
            this.gbox2.Controls.Add(this.etxtMultitablaCategoría);
            this.gbox2.Controls.Add(this.label5);
            this.gbox2.Location = new System.Drawing.Point(452, 167);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(336, 271);
            this.gbox2.TabIndex = 12;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "Consulta Multitabla";
            // 
            // dgvFiltro2
            // 
            this.dgvFiltro2.AllowUserToAddRows = false;
            this.dgvFiltro2.AllowUserToDeleteRows = false;
            this.dgvFiltro2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiltro2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro2.Location = new System.Drawing.Point(21, 65);
            this.dgvFiltro2.Name = "dgvFiltro2";
            this.dgvFiltro2.ReadOnly = true;
            this.dgvFiltro2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro2.Size = new System.Drawing.Size(300, 193);
            this.dgvFiltro2.TabIndex = 15;
            // 
            // btnBuscarXcat
            // 
            this.btnBuscarXcat.Location = new System.Drawing.Point(213, 16);
            this.btnBuscarXcat.Name = "btnBuscarXcat";
            this.btnBuscarXcat.Size = new System.Drawing.Size(108, 23);
            this.btnBuscarXcat.TabIndex = 14;
            this.btnBuscarXcat.Text = "BUSCAR X CAT";
            this.btnBuscarXcat.UseVisualStyleBackColor = true;
            this.btnBuscarXcat.Click += new System.EventHandler(this.btnBuscarXcat_Click);
            // 
            // etxtMultitablaCategoría
            // 
            this.etxtMultitablaCategoría.Location = new System.Drawing.Point(81, 19);
            this.etxtMultitablaCategoría.Name = "etxtMultitablaCategoría";
            this.etxtMultitablaCategoría.Size = new System.Drawing.Size(100, 20);
            this.etxtMultitablaCategoría.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoría:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.dgvFiltro1);
            this.Controls.Add(this.btnBuscarXPrecio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.etxtCampoPrecio);
            this.Controls.Add(this.etxtCampoCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.etxtPrecio);
            this.Controls.Add(this.etxtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro1)).EndInit();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etxtCategoria;
        private System.Windows.Forms.TextBox etxtPrecio;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox etxtCampoCategoria;
        private System.Windows.Forms.TextBox etxtCampoPrecio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarXPrecio;
        private System.Windows.Forms.DataGridView dgvFiltro1;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.DataGridView dgvFiltro2;
        private System.Windows.Forms.Button btnBuscarXcat;
        private System.Windows.Forms.TextBox etxtMultitablaCategoría;
        private System.Windows.Forms.Label label5;
    }
}

