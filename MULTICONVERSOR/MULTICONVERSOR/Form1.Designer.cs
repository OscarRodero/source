namespace MULTICONVERSOR
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            celsiusFarenheit = new TextBox();
            farenheitCelsius = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pasosKilometros = new TextBox();
            kilometrosPasos = new TextBox();
            millasKilometros = new TextBox();
            kilometrosMillas = new TextBox();
            pasosMillas = new TextBox();
            millasPasos = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            euroDolar = new TextBox();
            dolarEuro = new TextBox();
            euroBitcoin = new TextBox();
            bitcoinEuro = new TextBox();
            dolarBitcoin = new TextBox();
            bitcoinDolar = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(farenheitCelsius);
            groupBox1.Controls.Add(celsiusFarenheit);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temperatura";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(millasPasos);
            groupBox2.Controls.Add(pasosMillas);
            groupBox2.Controls.Add(kilometrosMillas);
            groupBox2.Controls.Add(millasKilometros);
            groupBox2.Controls.Add(kilometrosPasos);
            groupBox2.Controls.Add(pasosKilometros);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 222);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Longitud";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bitcoinDolar);
            groupBox3.Controls.Add(dolarBitcoin);
            groupBox3.Controls.Add(bitcoinEuro);
            groupBox3.Controls.Add(euroBitcoin);
            groupBox3.Controls.Add(dolarEuro);
            groupBox3.Controls.Add(euroDolar);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(466, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(322, 442);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monedas";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(346, 471);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(100, 23);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "ºC -> ºF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 119);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "ºF -> ºC";
            // 
            // celsiusFarenheit
            // 
            celsiusFarenheit.Location = new Point(133, 46);
            celsiusFarenheit.Name = "celsiusFarenheit";
            celsiusFarenheit.Size = new Size(100, 23);
            celsiusFarenheit.TabIndex = 2;
            // 
            // farenheitCelsius
            // 
            farenheitCelsius.Location = new Point(133, 116);
            farenheitCelsius.Name = "farenheitCelsius";
            farenheitCelsius.Size = new Size(100, 23);
            farenheitCelsius.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 34);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 0;
            label3.Text = "Pasos -> Kilómetros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 70);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 1;
            label4.Text = "Kilómetros -> Pasos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 101);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 2;
            label5.Text = "Millas -> Kilómetros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 130);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 3;
            label6.Text = "Kilómetros -> Millas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 159);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 4;
            label7.Text = "Pasos -> Millas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 188);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 5;
            label8.Text = "Millas -> Pasos";
            // 
            // pasosKilometros
            // 
            pasosKilometros.Location = new Point(228, 31);
            pasosKilometros.Name = "pasosKilometros";
            pasosKilometros.Size = new Size(100, 23);
            pasosKilometros.TabIndex = 6;
            // 
            // kilometrosPasos
            // 
            kilometrosPasos.Location = new Point(228, 67);
            kilometrosPasos.Name = "kilometrosPasos";
            kilometrosPasos.Size = new Size(100, 23);
            kilometrosPasos.TabIndex = 7;
            // 
            // millasKilometros
            // 
            millasKilometros.Location = new Point(228, 98);
            millasKilometros.Name = "millasKilometros";
            millasKilometros.Size = new Size(100, 23);
            millasKilometros.TabIndex = 8;
            // 
            // kilometrosMillas
            // 
            kilometrosMillas.Location = new Point(228, 127);
            kilometrosMillas.Name = "kilometrosMillas";
            kilometrosMillas.Size = new Size(100, 23);
            kilometrosMillas.TabIndex = 9;
            // 
            // pasosMillas
            // 
            pasosMillas.Location = new Point(228, 156);
            pasosMillas.Name = "pasosMillas";
            pasosMillas.Size = new Size(100, 23);
            pasosMillas.TabIndex = 10;
            // 
            // millasPasos
            // 
            millasPasos.Location = new Point(228, 185);
            millasPasos.Name = "millasPasos";
            millasPasos.Size = new Size(100, 23);
            millasPasos.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 46);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 1;
            label9.Text = "Euro -> Dólar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 107);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 2;
            label10.Text = "Dólar -> Euro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 163);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 3;
            label11.Text = "Euro -> Bitcoin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 220);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 4;
            label12.Text = "Bitcoin -> Euro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 287);
            label13.Name = "label13";
            label13.Size = new Size(91, 15);
            label13.TabIndex = 5;
            label13.Text = "Dólar -> Bitcoin";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(30, 347);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 6;
            label14.Text = "Bitcoin -> Dólar";
            // 
            // euroDolar
            // 
            euroDolar.Location = new Point(188, 43);
            euroDolar.Name = "euroDolar";
            euroDolar.Size = new Size(100, 23);
            euroDolar.TabIndex = 7;
            // 
            // dolarEuro
            // 
            dolarEuro.Location = new Point(188, 104);
            dolarEuro.Name = "dolarEuro";
            dolarEuro.Size = new Size(100, 23);
            dolarEuro.TabIndex = 8;
            // 
            // euroBitcoin
            // 
            euroBitcoin.Location = new Point(188, 160);
            euroBitcoin.Name = "euroBitcoin";
            euroBitcoin.Size = new Size(100, 23);
            euroBitcoin.TabIndex = 9;
            // 
            // bitcoinEuro
            // 
            bitcoinEuro.Location = new Point(188, 217);
            bitcoinEuro.Name = "bitcoinEuro";
            bitcoinEuro.Size = new Size(100, 23);
            bitcoinEuro.TabIndex = 10;
            // 
            // dolarBitcoin
            // 
            dolarBitcoin.Location = new Point(188, 284);
            dolarBitcoin.Name = "dolarBitcoin";
            dolarBitcoin.Size = new Size(100, 23);
            dolarBitcoin.TabIndex = 11;
            // 
            // bitcoinDolar
            // 
            bitcoinDolar.Location = new Point(188, 344);
            bitcoinDolar.Name = "bitcoinDolar";
            bitcoinDolar.Size = new Size(100, 23);
            bitcoinDolar.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(btnConvertir);
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
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnConvertir;
        private TextBox farenheitCelsius;
        private TextBox celsiusFarenheit;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox millasPasos;
        private TextBox pasosMillas;
        private TextBox kilometrosMillas;
        private TextBox millasKilometros;
        private TextBox kilometrosPasos;
        private TextBox pasosKilometros;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox bitcoinDolar;
        private TextBox dolarBitcoin;
        private TextBox bitcoinEuro;
        private TextBox euroBitcoin;
        private TextBox dolarEuro;
        private TextBox euroDolar;
    }
}