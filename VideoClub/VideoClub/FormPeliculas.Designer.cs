namespace VideoClub
{
    partial class FormPeliculas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label protagonistaLabel;
            System.Windows.Forms.Label argumentoLabel;
            System.Windows.Forms.Label estiloLabel;
            System.Windows.Forms.Label anioLabel;
            System.Windows.Forms.Label caratulaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeliculas));
            this.dsBD = new VideoClub.dsBD();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new VideoClub.dsBDTableAdapters.peliculasTableAdapter();
            this.tableAdapterManager = new VideoClub.dsBDTableAdapters.TableAdapterManager();
            this.categoriasTableAdapter = new VideoClub.dsBDTableAdapters.categoriasTableAdapter();
            this.estilosTableAdapter = new VideoClub.dsBDTableAdapters.estilosTableAdapter();
            this.peliculasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.peliculasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cbMostrarPeli = new System.Windows.Forms.ToolStripComboBox();
            this.btnMostrarTodas = new System.Windows.Forms.ToolStripButton();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.protagonistaTextBox = new System.Windows.Forms.TextBox();
            this.argumentoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.estiloComboBox = new System.Windows.Forms.ComboBox();
            this.estilosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anioTextBox = new System.Windows.Forms.TextBox();
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnNuevaCaratula = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            tituloLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            protagonistaLabel = new System.Windows.Forms.Label();
            argumentoLabel = new System.Windows.Forms.Label();
            estiloLabel = new System.Windows.Forms.Label();
            anioLabel = new System.Windows.Forms.Label();
            caratulaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).BeginInit();
            this.peliculasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estilosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(42, 52);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(32, 13);
            tituloLabel.TabIndex = 1;
            tituloLabel.Text = "titulo:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(42, 78);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(45, 13);
            directorLabel.TabIndex = 3;
            directorLabel.Text = "director:";
            // 
            // protagonistaLabel
            // 
            protagonistaLabel.AutoSize = true;
            protagonistaLabel.Location = new System.Drawing.Point(42, 104);
            protagonistaLabel.Name = "protagonistaLabel";
            protagonistaLabel.Size = new System.Drawing.Size(68, 13);
            protagonistaLabel.TabIndex = 5;
            protagonistaLabel.Text = "protagonista:";
            // 
            // argumentoLabel
            // 
            argumentoLabel.AutoSize = true;
            argumentoLabel.Location = new System.Drawing.Point(42, 130);
            argumentoLabel.Name = "argumentoLabel";
            argumentoLabel.Size = new System.Drawing.Size(60, 13);
            argumentoLabel.TabIndex = 7;
            argumentoLabel.Text = "argumento:";
            // 
            // estiloLabel
            // 
            estiloLabel.AutoSize = true;
            estiloLabel.Location = new System.Drawing.Point(42, 236);
            estiloLabel.Name = "estiloLabel";
            estiloLabel.Size = new System.Drawing.Size(34, 13);
            estiloLabel.TabIndex = 9;
            estiloLabel.Text = "estilo:";
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Location = new System.Drawing.Point(322, 52);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(30, 13);
            anioLabel.TabIndex = 11;
            anioLabel.Text = "anio:";
            // 
            // caratulaLabel
            // 
            caratulaLabel.AutoSize = true;
            caratulaLabel.Location = new System.Drawing.Point(322, 78);
            caratulaLabel.Name = "caratulaLabel";
            caratulaLabel.Size = new System.Drawing.Size(48, 13);
            caratulaLabel.TabIndex = 13;
            caratulaLabel.Text = "caratula:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(42, 264);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 15;
            categoriaLabel.Text = "categoria:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(322, 264);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 17;
            stockLabel.Text = "stock:";
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.dsBD;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alquileresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.estilosTableAdapter = this.estilosTableAdapter;
            this.tableAdapterManager.peliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VideoClub.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // estilosTableAdapter
            // 
            this.estilosTableAdapter.ClearBeforeFill = true;
            // 
            // peliculasBindingNavigator
            // 
            this.peliculasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peliculasBindingNavigator.BindingSource = this.peliculasBindingSource;
            this.peliculasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peliculasBindingNavigator.DeleteItem = null;
            this.peliculasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.peliculasBindingNavigatorSaveItem,
            this.cbMostrarPeli,
            this.btnMostrarTodas});
            this.peliculasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peliculasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peliculasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peliculasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peliculasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peliculasBindingNavigator.Name = "peliculasBindingNavigator";
            this.peliculasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peliculasBindingNavigator.Size = new System.Drawing.Size(509, 25);
            this.peliculasBindingNavigator.TabIndex = 0;
            this.peliculasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // peliculasBindingNavigatorSaveItem
            // 
            this.peliculasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peliculasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peliculasBindingNavigatorSaveItem.Image")));
            this.peliculasBindingNavigatorSaveItem.Name = "peliculasBindingNavigatorSaveItem";
            this.peliculasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.peliculasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.peliculasBindingNavigatorSaveItem.Click += new System.EventHandler(this.peliculasBindingNavigatorSaveItem_Click_3);
            // 
            // cbMostrarPeli
            // 
            this.cbMostrarPeli.Name = "cbMostrarPeli";
            this.cbMostrarPeli.Size = new System.Drawing.Size(121, 25);
            this.cbMostrarPeli.SelectedIndexChanged += new System.EventHandler(this.cbMostrarPeli_SelectedIndexChanged);
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrarTodas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(85, 22);
            this.btnMostrarTodas.Text = "Mostrar Todas";
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(116, 49);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(121, 20);
            this.tituloTextBox.TabIndex = 2;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(116, 75);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(121, 20);
            this.directorTextBox.TabIndex = 4;
            // 
            // protagonistaTextBox
            // 
            this.protagonistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "protagonista", true));
            this.protagonistaTextBox.Location = new System.Drawing.Point(116, 101);
            this.protagonistaTextBox.Name = "protagonistaTextBox";
            this.protagonistaTextBox.Size = new System.Drawing.Size(121, 20);
            this.protagonistaTextBox.TabIndex = 6;
            // 
            // argumentoRichTextBox
            // 
            this.argumentoRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "argumento", true));
            this.argumentoRichTextBox.Location = new System.Drawing.Point(116, 127);
            this.argumentoRichTextBox.Name = "argumentoRichTextBox";
            this.argumentoRichTextBox.Size = new System.Drawing.Size(121, 96);
            this.argumentoRichTextBox.TabIndex = 8;
            this.argumentoRichTextBox.Text = "";
            // 
            // estiloComboBox
            // 
            this.estiloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "estilo", true));
            this.estiloComboBox.DataSource = this.estilosBindingSource;
            this.estiloComboBox.DisplayMember = "estilo";
            this.estiloComboBox.FormattingEnabled = true;
            this.estiloComboBox.Location = new System.Drawing.Point(116, 233);
            this.estiloComboBox.Name = "estiloComboBox";
            this.estiloComboBox.Size = new System.Drawing.Size(121, 21);
            this.estiloComboBox.TabIndex = 10;
            this.estiloComboBox.ValueMember = "estilo";
            // 
            // estilosBindingSource
            // 
            this.estilosBindingSource.DataMember = "estilos";
            this.estilosBindingSource.DataSource = this.dsBD;
            // 
            // anioTextBox
            // 
            this.anioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "anio", true));
            this.anioTextBox.Location = new System.Drawing.Point(358, 49);
            this.anioTextBox.Name = "anioTextBox";
            this.anioTextBox.Size = new System.Drawing.Size(88, 20);
            this.anioTextBox.TabIndex = 12;
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.peliculasBindingSource, "caratula", true));
            this.caratulaPictureBox.Location = new System.Drawing.Point(325, 101);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(121, 122);
            this.caratulaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caratulaPictureBox.TabIndex = 14;
            this.caratulaPictureBox.TabStop = false;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "categoria", true));
            this.categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.categoriaComboBox.DisplayMember = "categoria";
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(116, 261);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaComboBox.TabIndex = 16;
            this.categoriaComboBox.ValueMember = "categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.dsBD;
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(383, 262);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.stockNumericUpDown.TabIndex = 18;
            // 
            // btnNuevaCaratula
            // 
            this.btnNuevaCaratula.Location = new System.Drawing.Point(325, 233);
            this.btnNuevaCaratula.Name = "btnNuevaCaratula";
            this.btnNuevaCaratula.Size = new System.Drawing.Size(121, 23);
            this.btnNuevaCaratula.TabIndex = 19;
            this.btnNuevaCaratula.Text = "Nueva Carátula";
            this.btnNuevaCaratula.UseVisualStyleBackColor = true;
            this.btnNuevaCaratula.Click += new System.EventHandler(this.btnNuevaCaratula_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "\"Archivos de imagen\" | *.jpg;*.jpeg;*.png";
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 333);
            this.Controls.Add(this.btnNuevaCaratula);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(protagonistaLabel);
            this.Controls.Add(this.protagonistaTextBox);
            this.Controls.Add(argumentoLabel);
            this.Controls.Add(this.argumentoRichTextBox);
            this.Controls.Add(estiloLabel);
            this.Controls.Add(this.estiloComboBox);
            this.Controls.Add(anioLabel);
            this.Controls.Add(this.anioTextBox);
            this.Controls.Add(caratulaLabel);
            this.Controls.Add(this.caratulaPictureBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockNumericUpDown);
            this.Controls.Add(this.peliculasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPeliculas";
            this.Text = "Películas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingNavigator)).EndInit();
            this.peliculasBindingNavigator.ResumeLayout(false);
            this.peliculasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estilosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private dsBDTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peliculasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton peliculasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox protagonistaTextBox;
        private System.Windows.Forms.RichTextBox argumentoRichTextBox;
        private System.Windows.Forms.ComboBox estiloComboBox;
        private System.Windows.Forms.TextBox anioTextBox;
        private System.Windows.Forms.PictureBox caratulaPictureBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.Button btnNuevaCaratula;
        private dsBDTableAdapters.estilosTableAdapter estilosTableAdapter;
        private System.Windows.Forms.BindingSource estilosBindingSource;
        private dsBDTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripComboBox cbMostrarPeli;
        private System.Windows.Forms.ToolStripButton btnMostrarTodas;
    }
}

