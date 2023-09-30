namespace Controles
{
    partial class frmColores
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnTipoLetra = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(64, 64);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(150, 34);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnTipoLetra
            // 
            this.btnTipoLetra.Location = new System.Drawing.Point(244, 64);
            this.btnTipoLetra.Name = "btnTipoLetra";
            this.btnTipoLetra.Size = new System.Drawing.Size(150, 34);
            this.btnTipoLetra.TabIndex = 1;
            this.btnTipoLetra.Text = "TIPO DE LETRA";
            this.btnTipoLetra.UseVisualStyleBackColor = true;
            this.btnTipoLetra.Click += new System.EventHandler(this.btnTipoLetra_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(64, 29);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(416, 15);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Elige el color de fondo de este formulario y el tipo de letra del cuadro de texto" +
    "";
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(64, 119);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(330, 23);
            this.txtPrueba.TabIndex = 3;
            this.txtPrueba.Text = "Probando...";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnTipoLetra);
            this.Controls.Add(this.btnColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmColores";
            this.Text = "frmColores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnColor;
        private Button btnTipoLetra;
        private Label lblTexto;
        private TextBox txtPrueba;
    }
}