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
            System.Windows.Forms.Label codpeliLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label protagonistaLabel;
            System.Windows.Forms.Label argumentoLabel;
            System.Windows.Forms.Label estiloLabel;
            System.Windows.Forms.Label anioLabel;
            System.Windows.Forms.Label caratulaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label stockLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Alquilar = new System.Windows.Forms.TabPage();
            this.Devolver = new System.Windows.Forms.TabPage();
            this.infoAlquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new VideoClub.dsBD();
            this.infoAlquileresTableAdapter = new VideoClub.dsBDTableAdapters.InfoAlquileresTableAdapter();
            this.tableAdapterManager = new VideoClub.dsBDTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtNombCli = new System.Windows.Forms.TextBox();
            this.txtApell1Cli = new System.Windows.Forms.TextBox();
            this.txtApell2Cli = new System.Windows.Forms.TextBox();
            this.btnAbrirBuscador = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new VideoClub.dsBDTableAdapters.peliculasTableAdapter();
            this.codpeliLabel1 = new System.Windows.Forms.Label();
            this.tituloComboBox = new System.Windows.Forms.ComboBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.protagonistaTextBox = new System.Windows.Forms.TextBox();
            this.argumentoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caratulaTextBox = new System.Windows.Forms.TextBox();
            this.btnCogerPrestada = new System.Windows.Forms.Button();
            codpeliLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            protagonistaLabel = new System.Windows.Forms.Label();
            argumentoLabel = new System.Windows.Forms.Label();
            estiloLabel = new System.Windows.Forms.Label();
            anioLabel = new System.Windows.Forms.Label();
            caratulaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Alquilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAlquileresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Alquilar);
            this.tabControl1.Controls.Add(this.Devolver);
            this.tabControl1.Location = new System.Drawing.Point(1, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 291);
            this.tabControl1.TabIndex = 2;
            // 
            // Alquilar
            // 
            this.Alquilar.AutoScroll = true;
            this.Alquilar.BackColor = System.Drawing.Color.Bisque;
            this.Alquilar.Controls.Add(this.btnCogerPrestada);
            this.Alquilar.Controls.Add(this.caratulaTextBox);
            this.Alquilar.Controls.Add(codpeliLabel);
            this.Alquilar.Controls.Add(this.codpeliLabel1);
            this.Alquilar.Controls.Add(tituloLabel);
            this.Alquilar.Controls.Add(this.tituloComboBox);
            this.Alquilar.Controls.Add(directorLabel);
            this.Alquilar.Controls.Add(this.directorTextBox);
            this.Alquilar.Controls.Add(protagonistaLabel);
            this.Alquilar.Controls.Add(this.protagonistaTextBox);
            this.Alquilar.Controls.Add(argumentoLabel);
            this.Alquilar.Controls.Add(this.argumentoRichTextBox);
            this.Alquilar.Controls.Add(estiloLabel);
            this.Alquilar.Controls.Add(this.estiloComboBox);
            this.Alquilar.Controls.Add(anioLabel);
            this.Alquilar.Controls.Add(this.anioTextBox);
            this.Alquilar.Controls.Add(caratulaLabel);
            this.Alquilar.Controls.Add(this.caratulaPictureBox);
            this.Alquilar.Controls.Add(categoriaLabel);
            this.Alquilar.Controls.Add(this.categoriaComboBox);
            this.Alquilar.Controls.Add(stockLabel);
            this.Alquilar.Controls.Add(this.stockNumericUpDown);
            this.Alquilar.Location = new System.Drawing.Point(4, 22);
            this.Alquilar.Name = "Alquilar";
            this.Alquilar.Size = new System.Drawing.Size(792, 265);
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
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(120, 9);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 7;
            // 
            // txtNombCli
            // 
            this.txtNombCli.Location = new System.Drawing.Point(403, 11);
            this.txtNombCli.Name = "txtNombCli";
            this.txtNombCli.Size = new System.Drawing.Size(98, 20);
            this.txtNombCli.TabIndex = 8;
            // 
            // txtApell1Cli
            // 
            this.txtApell1Cli.Location = new System.Drawing.Point(403, 37);
            this.txtApell1Cli.Name = "txtApell1Cli";
            this.txtApell1Cli.Size = new System.Drawing.Size(157, 20);
            this.txtApell1Cli.TabIndex = 9;
            // 
            // txtApell2Cli
            // 
            this.txtApell2Cli.Location = new System.Drawing.Point(566, 37);
            this.txtApell2Cli.Name = "txtApell2Cli";
            this.txtApell2Cli.Size = new System.Drawing.Size(157, 20);
            this.txtApell2Cli.TabIndex = 10;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlquilerDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaAlquilerDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoAlquileresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 352);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 97);
            this.dataGridView1.TabIndex = 12;
            // 
            // codAlquilerDataGridViewTextBoxColumn
            // 
            this.codAlquilerDataGridViewTextBoxColumn.DataPropertyName = "codAlquiler";
            this.codAlquilerDataGridViewTextBoxColumn.HeaderText = "codAlquiler";
            this.codAlquilerDataGridViewTextBoxColumn.Name = "codAlquilerDataGridViewTextBoxColumn";
            this.codAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
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
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.dsBD;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // codpeliLabel
            // 
            codpeliLabel.AutoSize = true;
            codpeliLabel.Location = new System.Drawing.Point(7, 11);
            codpeliLabel.Name = "codpeliLabel";
            codpeliLabel.Size = new System.Drawing.Size(44, 13);
            codpeliLabel.TabIndex = 0;
            codpeliLabel.Text = "codpeli:";
            // 
            // codpeliLabel1
            // 
            this.codpeliLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "codpeli", true));
            this.codpeliLabel1.Location = new System.Drawing.Point(96, 11);
            this.codpeliLabel1.Name = "codpeliLabel1";
            this.codpeliLabel1.Size = new System.Drawing.Size(57, 17);
            this.codpeliLabel1.TabIndex = 1;
            this.codpeliLabel1.Text = "label3";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(7, 42);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(32, 13);
            tituloLabel.TabIndex = 2;
            tituloLabel.Text = "titulo:";
            // 
            // tituloComboBox
            // 
            this.tituloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloComboBox.FormattingEnabled = true;
            this.tituloComboBox.Location = new System.Drawing.Point(99, 42);
            this.tituloComboBox.Name = "tituloComboBox";
            this.tituloComboBox.Size = new System.Drawing.Size(397, 21);
            this.tituloComboBox.TabIndex = 3;
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(7, 71);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(45, 13);
            directorLabel.TabIndex = 4;
            directorLabel.Text = "director:";
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(99, 71);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(456, 20);
            this.directorTextBox.TabIndex = 5;
            // 
            // protagonistaLabel
            // 
            protagonistaLabel.AutoSize = true;
            protagonistaLabel.Location = new System.Drawing.Point(7, 100);
            protagonistaLabel.Name = "protagonistaLabel";
            protagonistaLabel.Size = new System.Drawing.Size(68, 13);
            protagonistaLabel.TabIndex = 6;
            protagonistaLabel.Text = "protagonista:";
            // 
            // protagonistaTextBox
            // 
            this.protagonistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "protagonista", true));
            this.protagonistaTextBox.Location = new System.Drawing.Point(99, 97);
            this.protagonistaTextBox.Name = "protagonistaTextBox";
            this.protagonistaTextBox.Size = new System.Drawing.Size(456, 20);
            this.protagonistaTextBox.TabIndex = 7;
            // 
            // argumentoLabel
            // 
            argumentoLabel.AutoSize = true;
            argumentoLabel.Location = new System.Drawing.Point(7, 153);
            argumentoLabel.Name = "argumentoLabel";
            argumentoLabel.Size = new System.Drawing.Size(60, 13);
            argumentoLabel.TabIndex = 8;
            argumentoLabel.Text = "argumento:";
            // 
            // argumentoRichTextBox
            // 
            this.argumentoRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "argumento", true));
            this.argumentoRichTextBox.Location = new System.Drawing.Point(99, 153);
            this.argumentoRichTextBox.Name = "argumentoRichTextBox";
            this.argumentoRichTextBox.Size = new System.Drawing.Size(456, 64);
            this.argumentoRichTextBox.TabIndex = 9;
            this.argumentoRichTextBox.Text = "";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.Location = new System.Drawing.Point(7, 126);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(34, 13);
            estiloLabel.TabIndex = 10;
            estiloLabel.Text = "estilo:";
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "estilo", true));
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(99, 126);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(157, 21);
            this.estiloComboBox.TabIndex = 11;
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Location = new System.Drawing.Point(185, 11);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(30, 13);
            anioLabel.TabIndex = 12;
            anioLabel.Text = "anio:";
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(221, 9);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(121, 20);
            this.anioTextBox.TabIndex = 13;
            // 
            // caratulaLabel
            // 
            caratulaLabel.AutoSize = true;
            caratulaLabel.Location = new System.Drawing.Point(650, 12);
            caratulaLabel.Name = "caratulaLabel";
            caratulaLabel.Size = new System.Drawing.Size(48, 13);
            caratulaLabel.TabIndex = 14;
            caratulaLabel.Text = "caratula:";
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.peliculasBindingSource, "caratula", true));
            this.caratulaPictureBox.Location = new System.Drawing.Point(618, 71);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(121, 132);
            this.caratulaPictureBox.TabIndex = 15;
            this.caratulaPictureBox.TabStop = false;
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(335, 129);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 16;
            categoriaLabel.Text = "categoria:";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(398, 126);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(157, 21);
            this.categoriaComboBox.TabIndex = 17;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(407, 11);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 18;
            stockLabel.Text = "stock:";
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(449, 9);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.stockNumericUpDown.TabIndex = 19;
            this.stockNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // caratulaTextBox
            // 
            this.caratulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "caratula", true));
            this.caratulaTextBox.Location = new System.Drawing.Point(599, 39);
            this.caratulaTextBox.Name = "caratulaTextBox";
            this.caratulaTextBox.Size = new System.Drawing.Size(158, 20);
            this.caratulaTextBox.TabIndex = 21;
            // 
            // btnCogerPrestada
            // 
            this.btnCogerPrestada.Location = new System.Drawing.Point(162, 223);
            this.btnCogerPrestada.Name = "btnCogerPrestada";
            this.btnCogerPrestada.Size = new System.Drawing.Size(334, 38);
            this.btnCogerPrestada.TabIndex = 22;
            this.btnCogerPrestada.Text = "Coger Prestada";
            this.btnCogerPrestada.UseVisualStyleBackColor = true;
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAbrirBuscador);
            this.Controls.Add(this.txtApell2Cli);
            this.Controls.Add(this.txtApell1Cli);
            this.Controls.Add(this.txtNombCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAlquileres";
            this.Text = "FormAlquileres";
            this.Load += new System.EventHandler(this.FormAlquileres_Load);
            this.tabControl1.ResumeLayout(false);
            this.Alquilar.ResumeLayout(false);
            this.Alquilar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAlquileresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtNombCli;
        private System.Windows.Forms.TextBox txtApell1Cli;
        private System.Windows.Forms.TextBox txtApell2Cli;
        private System.Windows.Forms.Button btnAbrirBuscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private dsBDTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private System.Windows.Forms.Label codpeliLabel1;
        private System.Windows.Forms.ComboBox tituloComboBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox protagonistaTextBox;
        private System.Windows.Forms.RichTextBox argumentoRichTextBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.PictureBox caratulaPictureBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.TextBox caratulaTextBox;
        private System.Windows.Forms.Button btnCogerPrestada;
    }
}