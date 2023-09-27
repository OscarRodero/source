namespace Controles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnImagenes = new Button();
            btnGama = new Button();
            btnTemporizador = new Button();
            btnCalendarios = new Button();
            btnComboBox = new Button();
            btnCajas = new Button();
            btnListas = new Button();
            btnColores = new Button();
            btnTriangulos = new Button();
            btnTextBox = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnImagenes);
            panel1.Controls.Add(btnGama);
            panel1.Controls.Add(btnTemporizador);
            panel1.Controls.Add(btnCalendarios);
            panel1.Controls.Add(btnComboBox);
            panel1.Controls.Add(btnCajas);
            panel1.Controls.Add(btnListas);
            panel1.Controls.Add(btnColores);
            panel1.Controls.Add(btnTriangulos);
            panel1.Controls.Add(btnTextBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btnImagenes
            // 
            btnImagenes.Location = new Point(33, 380);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(125, 32);
            btnImagenes.TabIndex = 9;
            btnImagenes.Text = "10 Imágenes";
            btnImagenes.UseVisualStyleBackColor = true;
            btnImagenes.Click += btnImagenes_Click;
            // 
            // btnGama
            // 
            btnGama.Location = new Point(33, 342);
            btnGama.Name = "btnGama";
            btnGama.Size = new Size(125, 32);
            btnGama.TabIndex = 8;
            btnGama.Text = "09 Gama Colores";
            btnGama.UseVisualStyleBackColor = true;
            btnGama.Click += btnGama_Click;
            // 
            // btnTemporizador
            // 
            btnTemporizador.Location = new Point(33, 304);
            btnTemporizador.Name = "btnTemporizador";
            btnTemporizador.Size = new Size(125, 32);
            btnTemporizador.TabIndex = 7;
            btnTemporizador.Text = "08 Temporizador";
            btnTemporizador.UseVisualStyleBackColor = true;
            btnTemporizador.Click += btnTemporizador_Click;
            // 
            // btnCalendarios
            // 
            btnCalendarios.Location = new Point(33, 266);
            btnCalendarios.Name = "btnCalendarios";
            btnCalendarios.Size = new Size(125, 32);
            btnCalendarios.TabIndex = 6;
            btnCalendarios.Text = "07 Calendarios";
            btnCalendarios.UseVisualStyleBackColor = true;
            btnCalendarios.Click += btnCalendarios_Click;
            // 
            // btnComboBox
            // 
            btnComboBox.Location = new Point(33, 228);
            btnComboBox.Name = "btnComboBox";
            btnComboBox.Size = new Size(125, 32);
            btnComboBox.TabIndex = 5;
            btnComboBox.Text = "06 ComboBox";
            btnComboBox.UseVisualStyleBackColor = true;
            btnComboBox.Click += btnComboBox_Click;
            // 
            // btnCajas
            // 
            btnCajas.Location = new Point(33, 190);
            btnCajas.Name = "btnCajas";
            btnCajas.Size = new Size(125, 32);
            btnCajas.TabIndex = 4;
            btnCajas.Text = "05 Cajas";
            btnCajas.UseVisualStyleBackColor = true;
            btnCajas.Click += btnCajas_Click;
            // 
            // btnListas
            // 
            btnListas.Location = new Point(33, 152);
            btnListas.Name = "btnListas";
            btnListas.Size = new Size(125, 32);
            btnListas.TabIndex = 3;
            btnListas.Text = "04 Listas";
            btnListas.UseVisualStyleBackColor = true;
            btnListas.Click += btnListas_Click;
            // 
            // btnColores
            // 
            btnColores.Location = new Point(33, 114);
            btnColores.Name = "btnColores";
            btnColores.Size = new Size(125, 32);
            btnColores.TabIndex = 2;
            btnColores.Text = "03 Colores";
            btnColores.UseVisualStyleBackColor = true;
            btnColores.Click += btnColores_Click;
            // 
            // btnTriangulos
            // 
            btnTriangulos.Location = new Point(33, 76);
            btnTriangulos.Name = "btnTriangulos";
            btnTriangulos.Size = new Size(125, 32);
            btnTriangulos.TabIndex = 1;
            btnTriangulos.Text = "02 Triángulos";
            btnTriangulos.UseVisualStyleBackColor = true;
            btnTriangulos.Click += btnTriangulos_Click;
            // 
            // btnTextBox
            // 
            btnTextBox.Location = new Point(33, 38);
            btnTextBox.Name = "btnTextBox";
            btnTextBox.Size = new Size(125, 32);
            btnTextBox.TabIndex = 0;
            btnTextBox.Text = "01 TextBox";
            btnTextBox.UseVisualStyleBackColor = true;
            btnTextBox.Click += btnTextBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnImagenes;
        private Button btnGama;
        private Button btnTemporizador;
        private Button btnCalendarios;
        private Button btnComboBox;
        private Button btnCajas;
        private Button btnListas;
        private Button btnColores;
        private Button btnTriangulos;
        private Button btnTextBox;
    }
}