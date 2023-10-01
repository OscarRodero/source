namespace Controles
{
    partial class frmCajas
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
            this.lstArticulos = new System.Windows.Forms.ListBox();
            this.lblListaArticulos = new System.Windows.Forms.Label();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbMúltiple = new System.Windows.Forms.RadioButton();
            this.rbExtendida = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.lblTraspasados = new System.Windows.Forms.Label();
            this.lstTraspasados = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArticulos
            // 
            this.lstArticulos.FormattingEnabled = true;
            this.lstArticulos.ItemHeight = 15;
            this.lstArticulos.Location = new System.Drawing.Point(77, 91);
            this.lstArticulos.Name = "lstArticulos";
            this.lstArticulos.Size = new System.Drawing.Size(187, 184);
            this.lstArticulos.TabIndex = 0;
            this.lstArticulos.SelectedIndexChanged += new System.EventHandler(this.lstArticulos_SelectedIndexChanged);
            // 
            // lblListaArticulos
            // 
            this.lblListaArticulos.AutoSize = true;
            this.lblListaArticulos.Location = new System.Drawing.Point(77, 59);
            this.lblListaArticulos.Name = "lblListaArticulos";
            this.lblListaArticulos.Size = new System.Drawing.Size(84, 15);
            this.lblListaArticulos.TabIndex = 1;
            this.lblListaArticulos.Text = "Lista Artículos:";
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(28, 41);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(61, 19);
            this.rbSimple.TabIndex = 2;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.rbSimple_CheckedChanged);
            // 
            // rbMúltiple
            // 
            this.rbMúltiple.AutoSize = true;
            this.rbMúltiple.Location = new System.Drawing.Point(28, 79);
            this.rbMúltiple.Name = "rbMúltiple";
            this.rbMúltiple.Size = new System.Drawing.Size(69, 19);
            this.rbMúltiple.TabIndex = 3;
            this.rbMúltiple.TabStop = true;
            this.rbMúltiple.Text = "Múltiple";
            this.rbMúltiple.UseVisualStyleBackColor = true;
            this.rbMúltiple.CheckedChanged += new System.EventHandler(this.rbMúltiple_CheckedChanged);
            // 
            // rbExtendida
            // 
            this.rbExtendida.AutoSize = true;
            this.rbExtendida.Location = new System.Drawing.Point(28, 118);
            this.rbExtendida.Name = "rbExtendida";
            this.rbExtendida.Size = new System.Drawing.Size(77, 19);
            this.rbExtendida.TabIndex = 4;
            this.rbExtendida.TabStop = true;
            this.rbExtendida.Text = "Extendida";
            this.rbExtendida.UseVisualStyleBackColor = true;
            this.rbExtendida.CheckedChanged += new System.EventHandler(this.rbExtendida_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(84, 318);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.rbSimple);
            this.grpSeleccion.Controls.Add(this.rbMúltiple);
            this.grpSeleccion.Controls.Add(this.rbExtendida);
            this.grpSeleccion.Location = new System.Drawing.Point(300, 91);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Size = new System.Drawing.Size(151, 184);
            this.grpSeleccion.TabIndex = 7;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Tipo de Selección";
            // 
            // lblTraspasados
            // 
            this.lblTraspasados.AutoSize = true;
            this.lblTraspasados.Location = new System.Drawing.Point(480, 59);
            this.lblTraspasados.Name = "lblTraspasados";
            this.lblTraspasados.Size = new System.Drawing.Size(123, 15);
            this.lblTraspasados.TabIndex = 8;
            this.lblTraspasados.Text = "Artículos Traspasados:";
            // 
            // lstTraspasados
            // 
            this.lstTraspasados.FormattingEnabled = true;
            this.lstTraspasados.ItemHeight = 15;
            this.lstTraspasados.Location = new System.Drawing.Point(480, 91);
            this.lstTraspasados.Name = "lstTraspasados";
            this.lstTraspasados.Size = new System.Drawing.Size(187, 184);
            this.lstTraspasados.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(77, 343);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(189, 343);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(300, 289);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(151, 27);
            this.btnTraspasar.TabIndex = 12;
            this.btnTraspasar.Text = "TRASPASAR >>>";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(480, 289);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 27);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(300, 343);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(151, 56);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar elemento de la posición indicada";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 15;
            // 
            // frmCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstTraspasados);
            this.Controls.Add(this.lblTraspasados);
            this.Controls.Add(this.grpSeleccion);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblListaArticulos);
            this.Controls.Add(this.lstArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCajas";
            this.Text = "frmCajas";
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstArticulos;
        private Label lblListaArticulos;
        private RadioButton rbSimple;
        private RadioButton rbMúltiple;
        private RadioButton rbExtendida;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox grpSeleccion;
        private Label lblTraspasados;
        private ListBox lstTraspasados;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnTraspasar;
        private Button btnLimpiar;
        private Button btnSeleccionar;
        private TextBox textBox1;
    }
}