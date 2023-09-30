namespace Controles
{
    partial class frmTriangulos
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
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComprobarTriangulo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(201, 68);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 23);
            this.txtLado1.TabIndex = 0;
            this.txtLado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chek1);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(201, 122);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 23);
            this.txtLado2.TabIndex = 1;
            this.txtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chek2);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(201, 183);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 23);
            this.txtLado3.TabIndex = 2;
            this.txtLado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chek3);
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(81, 66);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(42, 15);
            this.lblLado1.TabIndex = 3;
            this.lblLado1.Text = "Lado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado 3";
            // 
            // btnComprobarTriangulo
            // 
            this.btnComprobarTriangulo.Location = new System.Drawing.Point(81, 237);
            this.btnComprobarTriangulo.Name = "btnComprobarTriangulo";
            this.btnComprobarTriangulo.Size = new System.Drawing.Size(220, 23);
            this.btnComprobarTriangulo.TabIndex = 6;
            this.btnComprobarTriangulo.Text = "¿Será un triángulo?";
            this.btnComprobarTriangulo.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(176, 283);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 7;
            // 
            // frmTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(391, 347);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComprobarTriangulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTriangulos";
            this.Text = "frmTriangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLado1;
        private TextBox txtLado2;
        private TextBox txtLado3;
        private Label lblLado1;
        private Label label2;
        private Label label3;
        private Button btnComprobarTriangulo;
        private Label lblResultado;
    }
}