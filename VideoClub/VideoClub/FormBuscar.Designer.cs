namespace VideoClub
{
    partial class FormBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApell1 = new System.Windows.Forms.TextBox();
            this.txtApell2 = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idSocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apell1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apell2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new VideoClub.dsBD();
            this.infoAlquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoAlquileresTableAdapter = new VideoClub.dsBDTableAdapters.InfoAlquileresTableAdapter();
            this.sociosTableAdapter = new VideoClub.dsBDTableAdapters.sociosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAlquileresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(95, 12);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(162, 20);
            this.txtIDCliente.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApell1
            // 
            this.txtApell1.Location = new System.Drawing.Point(95, 64);
            this.txtApell1.Name = "txtApell1";
            this.txtApell1.Size = new System.Drawing.Size(162, 20);
            this.txtApell1.TabIndex = 6;
            // 
            // txtApell2
            // 
            this.txtApell2.Location = new System.Drawing.Point(263, 64);
            this.txtApell2.Name = "txtApell2";
            this.txtApell2.Size = new System.Drawing.Size(165, 20);
            this.txtApell2.TabIndex = 7;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apell1DataGridViewTextBoxColumn,
            this.apell2DataGridViewTextBoxColumn});
            this.DGV.DataSource = this.sociosBindingSource;
            this.DGV.Location = new System.Drawing.Point(12, 132);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(416, 166);
            this.DGV.TabIndex = 8;
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(27, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(189, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Mostrar Todos";
            this.button2.UseVisualStyleBackColor = true;
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
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "socios";
            this.sociosBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoAlquileresBindingSource
            // 
            this.infoAlquileresBindingSource.DataMember = "InfoAlquileres";
            this.infoAlquileresBindingSource.DataSource = this.dsBD;
            // 
            // infoAlquileresTableAdapter
            // 
            this.infoAlquileresTableAdapter.ClearBeforeFill = true;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 310);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.txtApell2);
            this.Controls.Add(this.txtApell1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAlquileresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApell1;
        private System.Windows.Forms.TextBox txtApell2;
        private System.Windows.Forms.DataGridView DGV;
        private dsBD dsBD;
        private System.Windows.Forms.BindingSource infoAlquileresBindingSource;
        private dsBDTableAdapters.InfoAlquileresTableAdapter infoAlquileresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apell1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apell2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private dsBDTableAdapters.sociosTableAdapter sociosTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
    }
}