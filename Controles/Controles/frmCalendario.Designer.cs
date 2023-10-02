namespace Controles
{
    partial class frmCalendario
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
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Location = new System.Drawing.Point(94, 62);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(200, 23);
            this.dtpCalendario.TabIndex = 0;
            this.dtpCalendario.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mcCalendario
            // 
            this.mcCalendario.Location = new System.Drawing.Point(94, 108);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 1;
            this.mcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mcCalendario);
            this.Controls.Add(this.dtpCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendario";
            this.Text = "frmCalendario";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtpCalendario;
        private MonthCalendar mcCalendario;
    }
}