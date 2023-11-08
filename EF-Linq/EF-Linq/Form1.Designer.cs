namespace EF_Linq
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.etxtTitulo = new System.Windows.Forms.TextBox();
            this.etxtDirector = new System.Windows.Forms.TextBox();
            this.etxtProta = new System.Windows.Forms.TextBox();
            this.etxtAnio = new System.Windows.Forms.TextBox();
            this.cboxEstilo = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.nUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.Caratula = new System.Windows.Forms.PictureBox();
            this.etxtArgumento = new System.Windows.Forms.TextBox();
            this.btnCambiarCaratula = new System.Windows.Forms.Button();
            this.btnInsertarPelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caratula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estilo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Argumento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Protagonista:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Año:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoría:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Carátula:";
            // 
            // etxtTitulo
            // 
            this.etxtTitulo.Location = new System.Drawing.Point(92, 33);
            this.etxtTitulo.Name = "etxtTitulo";
            this.etxtTitulo.Size = new System.Drawing.Size(100, 20);
            this.etxtTitulo.TabIndex = 9;
            // 
            // etxtDirector
            // 
            this.etxtDirector.Location = new System.Drawing.Point(92, 78);
            this.etxtDirector.Name = "etxtDirector";
            this.etxtDirector.Size = new System.Drawing.Size(100, 20);
            this.etxtDirector.TabIndex = 10;
            // 
            // etxtProta
            // 
            this.etxtProta.Location = new System.Drawing.Point(390, 33);
            this.etxtProta.Name = "etxtProta";
            this.etxtProta.Size = new System.Drawing.Size(129, 20);
            this.etxtProta.TabIndex = 11;
            // 
            // etxtAnio
            // 
            this.etxtAnio.Location = new System.Drawing.Point(390, 78);
            this.etxtAnio.Name = "etxtAnio";
            this.etxtAnio.Size = new System.Drawing.Size(129, 20);
            this.etxtAnio.TabIndex = 12;
            // 
            // cboxEstilo
            // 
            this.cboxEstilo.FormattingEnabled = true;
            this.cboxEstilo.Location = new System.Drawing.Point(92, 119);
            this.cboxEstilo.Name = "cboxEstilo";
            this.cboxEstilo.Size = new System.Drawing.Size(100, 21);
            this.cboxEstilo.TabIndex = 13;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(390, 119);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(129, 21);
            this.cboxCategoria.TabIndex = 14;
            // 
            // nUpDownStock
            // 
            this.nUpDownStock.Location = new System.Drawing.Point(92, 163);
            this.nUpDownStock.Name = "nUpDownStock";
            this.nUpDownStock.Size = new System.Drawing.Size(51, 20);
            this.nUpDownStock.TabIndex = 15;
            // 
            // Caratula
            // 
            this.Caratula.Location = new System.Drawing.Point(390, 165);
            this.Caratula.Name = "Caratula";
            this.Caratula.Size = new System.Drawing.Size(129, 149);
            this.Caratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Caratula.TabIndex = 16;
            this.Caratula.TabStop = false;
            // 
            // etxtArgumento
            // 
            this.etxtArgumento.Location = new System.Drawing.Point(117, 218);
            this.etxtArgumento.Multiline = true;
            this.etxtArgumento.Name = "etxtArgumento";
            this.etxtArgumento.Size = new System.Drawing.Size(238, 96);
            this.etxtArgumento.TabIndex = 17;
            // 
            // btnCambiarCaratula
            // 
            this.btnCambiarCaratula.Location = new System.Drawing.Point(420, 320);
            this.btnCambiarCaratula.Name = "btnCambiarCaratula";
            this.btnCambiarCaratula.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarCaratula.TabIndex = 18;
            this.btnCambiarCaratula.Text = "Cambiar";
            this.btnCambiarCaratula.UseVisualStyleBackColor = true;
            this.btnCambiarCaratula.Click += new System.EventHandler(this.btnCambiarCaratula_Click);
            // 
            // btnInsertarPelicula
            // 
            this.btnInsertarPelicula.Location = new System.Drawing.Point(167, 364);
            this.btnInsertarPelicula.Name = "btnInsertarPelicula";
            this.btnInsertarPelicula.Size = new System.Drawing.Size(262, 38);
            this.btnInsertarPelicula.TabIndex = 19;
            this.btnInsertarPelicula.Text = "INSERTAR";
            this.btnInsertarPelicula.UseVisualStyleBackColor = true;
            this.btnInsertarPelicula.Click += new System.EventHandler(this.btnInsertarPelicula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 420);
            this.Controls.Add(this.btnInsertarPelicula);
            this.Controls.Add(this.btnCambiarCaratula);
            this.Controls.Add(this.etxtArgumento);
            this.Controls.Add(this.Caratula);
            this.Controls.Add(this.nUpDownStock);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxEstilo);
            this.Controls.Add(this.etxtAnio);
            this.Controls.Add(this.etxtProta);
            this.Controls.Add(this.etxtDirector);
            this.Controls.Add(this.etxtTitulo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caratula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox etxtTitulo;
        private System.Windows.Forms.TextBox etxtDirector;
        private System.Windows.Forms.TextBox etxtProta;
        private System.Windows.Forms.TextBox etxtAnio;
        private System.Windows.Forms.ComboBox cboxEstilo;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.NumericUpDown nUpDownStock;
        private System.Windows.Forms.PictureBox Caratula;
        private System.Windows.Forms.TextBox etxtArgumento;
        private System.Windows.Forms.Button btnCambiarCaratula;
        private System.Windows.Forms.Button btnInsertarPelicula;
    }
}

