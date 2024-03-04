namespace PruebasUnitarias
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
            groupBox1 = new GroupBox();
            txtFarenheit = new TextBox();
            txtCelsius = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnConvertirTemperatura = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMillas = new TextBox();
            txtKilometros = new TextBox();
            txtPasos = new TextBox();
            btnConvertirDistancia = new Button();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            Euros = new Label();
            txtBitcoin = new TextBox();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            btnConvertirMoneda = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFarenheit);
            groupBox1.Controls.Add(txtCelsius);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnConvertirTemperatura);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 264);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temperaturas";
            // 
            // txtFarenheit
            // 
            txtFarenheit.Location = new Point(129, 126);
            txtFarenheit.Name = "txtFarenheit";
            txtFarenheit.Size = new Size(100, 23);
            txtFarenheit.TabIndex = 4;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(129, 57);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 129);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Farenheit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 60);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Celsius";
            // 
            // btnConvertirTemperatura
            // 
            btnConvertirTemperatura.Location = new Point(97, 210);
            btnConvertirTemperatura.Name = "btnConvertirTemperatura";
            btnConvertirTemperatura.Size = new Size(75, 23);
            btnConvertirTemperatura.TabIndex = 0;
            btnConvertirTemperatura.Text = "Convertir";
            btnConvertirTemperatura.UseVisualStyleBackColor = true;
            btnConvertirTemperatura.Click += btnConvertirTemperatura_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMillas);
            groupBox2.Controls.Add(txtKilometros);
            groupBox2.Controls.Add(txtPasos);
            groupBox2.Controls.Add(btnConvertirDistancia);
            groupBox2.Location = new Point(314, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 264);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Distancias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 161);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "Millas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 110);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 15;
            label7.Text = "Kilómetros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 60);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 14;
            label8.Text = "Pasos";
            // 
            // txtMillas
            // 
            txtMillas.Location = new Point(139, 153);
            txtMillas.Name = "txtMillas";
            txtMillas.Size = new Size(100, 23);
            txtMillas.TabIndex = 13;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(139, 102);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(100, 23);
            txtKilometros.TabIndex = 12;
            // 
            // txtPasos
            // 
            txtPasos.Location = new Point(139, 52);
            txtPasos.Name = "txtPasos";
            txtPasos.Size = new Size(100, 23);
            txtPasos.TabIndex = 11;
            // 
            // btnConvertirDistancia
            // 
            btnConvertirDistancia.Location = new Point(109, 210);
            btnConvertirDistancia.Name = "btnConvertirDistancia";
            btnConvertirDistancia.Size = new Size(75, 23);
            btnConvertirDistancia.TabIndex = 1;
            btnConvertirDistancia.Text = "Convertir";
            btnConvertirDistancia.UseVisualStyleBackColor = true;
            btnConvertirDistancia.Click += btnConvertirDistancia_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(Euros);
            groupBox3.Controls.Add(txtBitcoin);
            groupBox3.Controls.Add(txtDolar);
            groupBox3.Controls.Add(txtEuro);
            groupBox3.Controls.Add(btnConvertirMoneda);
            groupBox3.Location = new Point(12, 282);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(284, 268);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monedas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 158);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "Bitcoins";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 107);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Dólares";
            // 
            // Euros
            // 
            Euros.AutoSize = true;
            Euros.Location = new Point(32, 57);
            Euros.Name = "Euros";
            Euros.Size = new Size(36, 15);
            Euros.TabIndex = 8;
            Euros.Text = "Euros";
            // 
            // txtBitcoin
            // 
            txtBitcoin.Location = new Point(129, 150);
            txtBitcoin.Name = "txtBitcoin";
            txtBitcoin.Size = new Size(100, 23);
            txtBitcoin.TabIndex = 7;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(129, 99);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 6;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(129, 49);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 5;
            // 
            // btnConvertirMoneda
            // 
            btnConvertirMoneda.Location = new Point(97, 239);
            btnConvertirMoneda.Name = "btnConvertirMoneda";
            btnConvertirMoneda.Size = new Size(75, 23);
            btnConvertirMoneda.TabIndex = 1;
            btnConvertirMoneda.Text = "Convertir";
            btnConvertirMoneda.UseVisualStyleBackColor = true;
            btnConvertirMoneda.Click += btnConvertirMoneda_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 558);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnConvertirTemperatura;
        private GroupBox groupBox2;
        private Button btnConvertirDistancia;
        private GroupBox groupBox3;
        private Button btnConvertirMoneda;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label Euros;
        public TextBox txtFarenheit;
        public TextBox txtCelsius;
        public TextBox txtMillas;
        public TextBox txtKilometros;
        public TextBox txtPasos;
        public TextBox txtBitcoin;
        public TextBox txtDolar;
        public TextBox txtEuro;
    }
}
