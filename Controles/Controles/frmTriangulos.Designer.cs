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
            txtLado1 = new TextBox();
            txtLado2 = new TextBox();
            txtLado3 = new TextBox();
            lblLado1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnComprobarTriangulo = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(201, 68);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(100, 23);
            txtLado1.TabIndex = 0;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(201, 122);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(100, 23);
            txtLado2.TabIndex = 1;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(201, 183);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(100, 23);
            txtLado3.TabIndex = 2;
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Location = new Point(81, 66);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(42, 15);
            lblLado1.TabIndex = 3;
            lblLado1.Text = "Lado 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 125);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Lado 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 183);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Lado 3";
            // 
            // btnComprobarTriangulo
            // 
            btnComprobarTriangulo.Location = new Point(81, 237);
            btnComprobarTriangulo.Name = "btnComprobarTriangulo";
            btnComprobarTriangulo.Size = new Size(220, 23);
            btnComprobarTriangulo.TabIndex = 6;
            btnComprobarTriangulo.Text = "¿Será un triángulo?";
            btnComprobarTriangulo.UseVisualStyleBackColor = true;
            btnComprobarTriangulo.Click += btnComprobarTriangulo_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(176, 283);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 7;
            // 
            // frmTriangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(391, 347);
            Controls.Add(lblResultado);
            Controls.Add(btnComprobarTriangulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblLado1);
            Controls.Add(txtLado3);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTriangulos";
            Text = "frmTriangulos";
            ResumeLayout(false);
            PerformLayout();
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