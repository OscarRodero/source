namespace AgenciaViajes
{
    partial class frmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            acuerdoEmpresaToolStripMenuItem = new ToolStripMenuItem();
            preciosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pBox = new PictureBox();
            label1 = new Label();
            listaDestinos = new ListBox();
            imageList1 = new ImageList(components);
            label2 = new Label();
            chklstbox = new CheckedListBox();
            label3 = new Label();
            mcCalendario = new MonthCalendar();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnCalcular = new Button();
            txtResumen = new TextBox();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            btnValidar = new Button();
            cantPersonas = new NumericUpDown();
            cantEstrellas = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pb = new ToolStripProgressBar();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            reloj = new ToolStripStatusLabel();
            contador = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantEstrellas).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acuerdoEmpresaToolStripMenuItem, preciosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // acuerdoEmpresaToolStripMenuItem
            // 
            acuerdoEmpresaToolStripMenuItem.Name = "acuerdoEmpresaToolStripMenuItem";
            acuerdoEmpresaToolStripMenuItem.Size = new Size(112, 20);
            acuerdoEmpresaToolStripMenuItem.Text = "Acuerdo Empresa";
            acuerdoEmpresaToolStripMenuItem.Click += acuerdoEmpresaToolStripMenuItem_Click;
            // 
            // preciosToolStripMenuItem
            // 
            preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            preciosToolStripMenuItem.Size = new Size(57, 20);
            preciosToolStripMenuItem.Text = "Precios";
            preciosToolStripMenuItem.Click += preciosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pBox
            // 
            pBox.Location = new Point(30, 52);
            pBox.Name = "pBox";
            pBox.Size = new Size(242, 183);
            pBox.TabIndex = 1;
            pBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Location = new Point(294, 52);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Elige un destino:";
            // 
            // listaDestinos
            // 
            listaDestinos.FormattingEnabled = true;
            listaDestinos.ItemHeight = 15;
            listaDestinos.Location = new Point(294, 70);
            listaDestinos.Name = "listaDestinos";
            listaDestinos.Size = new Size(94, 109);
            listaDestinos.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ciudad.jpg");
            imageList1.Images.SetKeyName(1, "montaña.jpg");
            imageList1.Images.SetKeyName(2, "playa.jpg");
            imageList1.Images.SetKeyName(3, "tour.jpg");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Location = new Point(643, 52);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Actividades Extra:";
            // 
            // chklstbox
            // 
            chklstbox.FormattingEnabled = true;
            chklstbox.Items.AddRange(new object[] { "Cena y Espectáculo", "Excursiones", "Lavandería", "NaturAventura", "Spa" });
            chklstbox.Location = new Point(630, 70);
            chklstbox.Name = "chklstbox";
            chklstbox.Size = new Size(138, 112);
            chklstbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.Location = new Point(294, 187);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha:";
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(294, 211);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(77, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 132);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Estancia";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(10, 80);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(122, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Pensión Completa";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Media Pensión";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sólo Dormir";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(55, 379);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(182, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // txtResumen
            // 
            txtResumen.Enabled = false;
            txtResumen.Location = new Point(6, 6);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.Size = new Size(294, 95);
            txtResumen.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PaleTurquoise;
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(btnValidar);
            groupBox2.Controls.Add(txtResumen);
            groupBox2.Location = new Point(294, 379);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 134);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(225, 107);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 12;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // cantPersonas
            // 
            cantPersonas.Location = new Point(601, 224);
            cantPersonas.Name = "cantPersonas";
            cantPersonas.Size = new Size(36, 23);
            cantPersonas.TabIndex = 13;
            // 
            // cantEstrellas
            // 
            cantEstrellas.Location = new Point(601, 281);
            cantEstrellas.Name = "cantEstrellas";
            cantEstrellas.Size = new Size(36, 23);
            cantEstrellas.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Location = new Point(645, 232);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 15;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Location = new Point(645, 289);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 16;
            label5.Text = "Estrellas del hotel";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripStatusLabel1, pb, toolStripStatusLabel4, reloj });
            statusStrip1.Location = new Point(0, 525);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BackColor = Color.Transparent;
            toolStripStatusLabel2.Image = (Image)resources.GetObject("toolStripStatusLabel2.Image");
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.IsLink = true;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(165, 17);
            toolStripStatusLabel1.Text = "viajeconnosotros@gmail.com";
            // 
            // pb
            // 
            pb.Name = "pb";
            pb.Size = new Size(250, 16);
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BackColor = Color.Transparent;
            toolStripStatusLabel4.ForeColor = Color.Transparent;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(181, 17);
            toolStripStatusLabel4.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // reloj
            // 
            reloj.BackColor = Color.Transparent;
            reloj.Image = (Image)resources.GetObject("reloj.Image");
            reloj.Name = "reloj";
            reloj.Size = new Size(65, 17);
            reloj.Text = "00:00:00";
            // 
            // contador
            // 
            contador.Enabled = true;
            contador.Interval = 1000;
            contador.Tick += contador_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 547);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cantEstrellas);
            Controls.Add(cantPersonas);
            Controls.Add(groupBox2);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Controls.Add(mcCalendario);
            Controls.Add(label3);
            Controls.Add(chklstbox);
            Controls.Add(label2);
            Controls.Add(listaDestinos);
            Controls.Add(label1);
            Controls.Add(pBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantEstrellas).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acuerdoEmpresaToolStripMenuItem;
        private ToolStripMenuItem preciosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pBox;
        private Label label1;
        private ListBox listaDestinos;
        private ImageList imageList1;
        private Label label2;
        private CheckedListBox chklstbox;
        private Label label3;
        private MonthCalendar mcCalendario;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnCalcular;
        private TextBox txtResumen;
        private GroupBox groupBox2;
        private Button btnValidar;
        private NumericUpDown cantPersonas;
        private NumericUpDown cantEstrellas;
        private Label label4;
        private Label label5;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar pb;
        private ToolStripStatusLabel reloj;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer contador;
        private Label lblTotal;
    }
}