namespace Controles
{
    partial class frmCombobox
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
            this.lblEstiloDropDown = new System.Windows.Forms.Label();
            this.lblEstiloDropDownList = new System.Windows.Forms.Label();
            this.lblEstiloSimple = new System.Windows.Forms.Label();
            this.lblMuestra = new System.Windows.Forms.Label();
            this.txtElegido = new System.Windows.Forms.TextBox();
            this.txtAddTexto = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEstiloDropDown
            // 
            this.lblEstiloDropDown.AutoSize = true;
            this.lblEstiloDropDown.Location = new System.Drawing.Point(130, 97);
            this.lblEstiloDropDown.Name = "lblEstiloDropDown";
            this.lblEstiloDropDown.Size = new System.Drawing.Size(95, 15);
            this.lblEstiloDropDown.TabIndex = 0;
            this.lblEstiloDropDown.Text = "Estilo DropDown";
            // 
            // lblEstiloDropDownList
            // 
            this.lblEstiloDropDownList.AutoSize = true;
            this.lblEstiloDropDownList.Location = new System.Drawing.Point(303, 94);
            this.lblEstiloDropDownList.Name = "lblEstiloDropDownList";
            this.lblEstiloDropDownList.Size = new System.Drawing.Size(113, 15);
            this.lblEstiloDropDownList.TabIndex = 1;
            this.lblEstiloDropDownList.Text = "Estilo DropDownList";
            // 
            // lblEstiloSimple
            // 
            this.lblEstiloSimple.AutoSize = true;
            this.lblEstiloSimple.Location = new System.Drawing.Point(487, 95);
            this.lblEstiloSimple.Name = "lblEstiloSimple";
            this.lblEstiloSimple.Size = new System.Drawing.Size(73, 15);
            this.lblEstiloSimple.TabIndex = 2;
            this.lblEstiloSimple.Text = "Estilo simple";
            // 
            // lblMuestra
            // 
            this.lblMuestra.AutoSize = true;
            this.lblMuestra.Location = new System.Drawing.Point(138, 188);
            this.lblMuestra.Name = "lblMuestra";
            this.lblMuestra.Size = new System.Drawing.Size(175, 15);
            this.lblMuestra.TabIndex = 3;
            this.lblMuestra.Text = "Muestra el último color elegido:";
            // 
            // txtElegido
            // 
            this.txtElegido.Enabled = false;
            this.txtElegido.Location = new System.Drawing.Point(354, 185);
            this.txtElegido.Name = "txtElegido";
            this.txtElegido.Size = new System.Drawing.Size(100, 23);
            this.txtElegido.TabIndex = 4;
            // 
            // txtAddTexto
            // 
            this.txtAddTexto.Location = new System.Drawing.Point(144, 241);
            this.txtAddTexto.Name = "txtAddTexto";
            this.txtAddTexto.Size = new System.Drawing.Size(100, 23);
            this.txtAddTexto.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Añadir al DropDownList";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(123, 115);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 23);
            this.cb1.TabIndex = 7;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(303, 115);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 23);
            this.cb2.TabIndex = 8;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // cb3
            // 
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(487, 115);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(121, 90);
            this.cb3.TabIndex = 9;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            // 
            // frmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddTexto);
            this.Controls.Add(this.txtElegido);
            this.Controls.Add(this.lblMuestra);
            this.Controls.Add(this.lblEstiloSimple);
            this.Controls.Add(this.lblEstiloDropDownList);
            this.Controls.Add(this.lblEstiloDropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCombobox";
            this.Text = "frmCombobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEstiloDropDown;
        private Label lblEstiloDropDownList;
        private Label lblEstiloSimple;
        private Label lblMuestra;
        private TextBox txtElegido;
        private TextBox txtAddTexto;
        private Button btnAdd;
        private ComboBox cb1;
        private ComboBox cb2;
        private ComboBox cb3;
    }
}