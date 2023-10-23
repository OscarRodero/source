﻿namespace VideoClub
{
    partial class FormSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSocios));
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label pwdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apell1Label;
            System.Windows.Forms.Label apell2Label;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            this.sociosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sociosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apell1TextBox = new System.Windows.Forms.TextBox();
            this.apell2TextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new VideoClub.dsBD();
            this.sociosTableAdapter = new VideoClub.dsBDTableAdapters.sociosTableAdapter();
            this.tableAdapterManager = new VideoClub.dsBDTableAdapters.TableAdapterManager();
            this.alquileresTableAdapter1 = new VideoClub.dsBDTableAdapters.alquileresTableAdapter();
            loginLabel = new System.Windows.Forms.Label();
            pwdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apell1Label = new System.Windows.Forms.Label();
            apell2Label = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingNavigator)).BeginInit();
            this.sociosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            this.SuspendLayout();
            // 
            // sociosBindingNavigator
            // 
            this.sociosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sociosBindingNavigator.BindingSource = this.sociosBindingSource;
            this.sociosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sociosBindingNavigator.DeleteItem = null;
            this.sociosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sociosBindingNavigatorSaveItem});
            this.sociosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sociosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sociosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sociosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sociosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sociosBindingNavigator.Name = "sociosBindingNavigator";
            this.sociosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sociosBindingNavigator.Size = new System.Drawing.Size(337, 25);
            this.sociosBindingNavigator.TabIndex = 0;
            this.sociosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // sociosBindingNavigatorSaveItem
            // 
            this.sociosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sociosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sociosBindingNavigatorSaveItem.Image")));
            this.sociosBindingNavigatorSaveItem.Name = "sociosBindingNavigatorSaveItem";
            this.sociosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sociosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.sociosBindingNavigatorSaveItem.Click += new System.EventHandler(this.sociosBindingNavigatorSaveItem_Click);
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(52, 46);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(111, 43);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 2;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new System.Drawing.Point(52, 72);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new System.Drawing.Size(30, 13);
            pwdLabel.TabIndex = 3;
            pwdLabel.Text = "pwd:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "pwd", true));
            this.pwdTextBox.Location = new System.Drawing.Point(111, 69);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(100, 20);
            this.pwdTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(52, 98);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(111, 95);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apell1Label
            // 
            apell1Label.AutoSize = true;
            apell1Label.Location = new System.Drawing.Point(52, 124);
            apell1Label.Name = "apell1Label";
            apell1Label.Size = new System.Drawing.Size(38, 13);
            apell1Label.TabIndex = 7;
            apell1Label.Text = "apell1:";
            // 
            // apell1TextBox
            // 
            this.apell1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "apell1", true));
            this.apell1TextBox.Location = new System.Drawing.Point(111, 121);
            this.apell1TextBox.Name = "apell1TextBox";
            this.apell1TextBox.Size = new System.Drawing.Size(100, 20);
            this.apell1TextBox.TabIndex = 8;
            // 
            // apell2Label
            // 
            apell2Label.AutoSize = true;
            apell2Label.Location = new System.Drawing.Point(52, 150);
            apell2Label.Name = "apell2Label";
            apell2Label.Size = new System.Drawing.Size(38, 13);
            apell2Label.TabIndex = 9;
            apell2Label.Text = "apell2:";
            // 
            // apell2TextBox
            // 
            this.apell2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "apell2", true));
            this.apell2TextBox.Location = new System.Drawing.Point(111, 147);
            this.apell2TextBox.Name = "apell2TextBox";
            this.apell2TextBox.Size = new System.Drawing.Size(100, 20);
            this.apell2TextBox.TabIndex = 10;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(52, 176);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(53, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(111, 173);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(52, 202);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(52, 13);
            localidadLabel.TabIndex = 13;
            localidadLabel.Text = "localidad:";
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "localidad", true));
            this.localidadTextBox.Location = new System.Drawing.Point(111, 199);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.localidadTextBox.TabIndex = 14;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(52, 228);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 15;
            telefonoLabel.Text = "telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(111, 225);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(52, 254);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sociosBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(111, 251);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 18;
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
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alquileresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.estilosTableAdapter = null;
            this.tableAdapterManager.peliculasTableAdapter = null;
            this.tableAdapterManager.sociosTableAdapter = this.sociosTableAdapter;
            this.tableAdapterManager.UpdateOrder = VideoClub.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alquileresTableAdapter1
            // 
            this.alquileresTableAdapter1.ClearBeforeFill = true;
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 322);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(pwdLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apell1Label);
            this.Controls.Add(this.apell1TextBox);
            this.Controls.Add(apell2Label);
            this.Controls.Add(this.apell2TextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(localidadLabel);
            this.Controls.Add(this.localidadTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.sociosBindingNavigator);
            this.Name = "FormSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSocios";
            this.Load += new System.EventHandler(this.FormSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingNavigator)).EndInit();
            this.sociosBindingNavigator.ResumeLayout(false);
            this.sociosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private dsBDTableAdapters.sociosTableAdapter sociosTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sociosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sociosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apell1TextBox;
        private System.Windows.Forms.TextBox apell2TextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private dsBDTableAdapters.alquileresTableAdapter alquileresTableAdapter1;
    }
}