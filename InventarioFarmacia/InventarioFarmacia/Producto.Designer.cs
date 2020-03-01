namespace InventarioFarmacia
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label productoActivoLabel;
            System.Windows.Forms.Label productoDescripcionLabel;
            System.Windows.Forms.Label productoNombreLabel;
            System.Windows.Forms.Label productoNombreComercialLabel;
            System.Windows.Forms.Label productoUMLabel;
            this.listaProductoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.listaProductoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.productoActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.productoDescripcionTextBox = new System.Windows.Forms.TextBox();
            this.productoNombreTextBox = new System.Windows.Forms.TextBox();
            this.productoNombreComercialTextBox = new System.Windows.Forms.TextBox();
            this.productoUMTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            productoActivoLabel = new System.Windows.Forms.Label();
            productoDescripcionLabel = new System.Windows.Forms.Label();
            productoNombreLabel = new System.Windows.Forms.Label();
            productoNombreComercialLabel = new System.Windows.Forms.Label();
            productoUMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductoBindingNavigator)).BeginInit();
            this.listaProductoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listaProductoBindingNavigator
            // 
            this.listaProductoBindingNavigator.AddNewItem = null;
            this.listaProductoBindingNavigator.BindingSource = this.listaProductoBindingSource;
            this.listaProductoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProductoBindingNavigator.DeleteItem = null;
            this.listaProductoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaProductoBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaProductoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaProductoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProductoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProductoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProductoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProductoBindingNavigator.Name = "listaProductoBindingNavigator";
            this.listaProductoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProductoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.listaProductoBindingNavigator.TabIndex = 0;
            this.listaProductoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaProductoBindingSource
            // 
            this.listaProductoBindingSource.DataSource = typeof(BL.InventarioFarmacia.Producto);
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
            // listaProductoBindingNavigatorSaveItem
            // 
            this.listaProductoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaProductoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProductoBindingNavigatorSaveItem.Image")));
            this.listaProductoBindingNavigatorSaveItem.Name = "listaProductoBindingNavigatorSaveItem";
            this.listaProductoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaProductoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaProductoBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProductoBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(92, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(240, 66);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(515, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // productoActivoLabel
            // 
            productoActivoLabel.AutoSize = true;
            productoActivoLabel.Location = new System.Drawing.Point(92, 224);
            productoActivoLabel.Name = "productoActivoLabel";
            productoActivoLabel.Size = new System.Drawing.Size(86, 13);
            productoActivoLabel.TabIndex = 3;
            productoActivoLabel.Text = "Producto Activo:";
            // 
            // productoActivoCheckBox
            // 
            this.productoActivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductoBindingSource, "ProductoActivo", true));
            this.productoActivoCheckBox.Location = new System.Drawing.Point(240, 219);
            this.productoActivoCheckBox.Name = "productoActivoCheckBox";
            this.productoActivoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.productoActivoCheckBox.TabIndex = 4;
            this.productoActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // productoDescripcionLabel
            // 
            productoDescripcionLabel.AutoSize = true;
            productoDescripcionLabel.Location = new System.Drawing.Point(92, 131);
            productoDescripcionLabel.Name = "productoDescripcionLabel";
            productoDescripcionLabel.Size = new System.Drawing.Size(112, 13);
            productoDescripcionLabel.TabIndex = 5;
            productoDescripcionLabel.Text = "Producto Descripcion:";
            // 
            // productoDescripcionTextBox
            // 
            this.productoDescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductoBindingSource, "ProductoDescripcion", true));
            this.productoDescripcionTextBox.Location = new System.Drawing.Point(240, 128);
            this.productoDescripcionTextBox.Name = "productoDescripcionTextBox";
            this.productoDescripcionTextBox.Size = new System.Drawing.Size(515, 20);
            this.productoDescripcionTextBox.TabIndex = 6;
            // 
            // productoNombreLabel
            // 
            productoNombreLabel.AutoSize = true;
            productoNombreLabel.Location = new System.Drawing.Point(92, 100);
            productoNombreLabel.Name = "productoNombreLabel";
            productoNombreLabel.Size = new System.Drawing.Size(93, 13);
            productoNombreLabel.TabIndex = 7;
            productoNombreLabel.Text = "Producto Nombre:";
            // 
            // productoNombreTextBox
            // 
            this.productoNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductoBindingSource, "ProductoNombre", true));
            this.productoNombreTextBox.Location = new System.Drawing.Point(240, 97);
            this.productoNombreTextBox.Name = "productoNombreTextBox";
            this.productoNombreTextBox.Size = new System.Drawing.Size(515, 20);
            this.productoNombreTextBox.TabIndex = 8;
            // 
            // productoNombreComercialLabel
            // 
            productoNombreComercialLabel.AutoSize = true;
            productoNombreComercialLabel.Location = new System.Drawing.Point(92, 161);
            productoNombreComercialLabel.Name = "productoNombreComercialLabel";
            productoNombreComercialLabel.Size = new System.Drawing.Size(142, 13);
            productoNombreComercialLabel.TabIndex = 9;
            productoNombreComercialLabel.Text = "Producto Nombre Comercial:";
            // 
            // productoNombreComercialTextBox
            // 
            this.productoNombreComercialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductoBindingSource, "ProductoNombreComercial", true));
            this.productoNombreComercialTextBox.Location = new System.Drawing.Point(240, 158);
            this.productoNombreComercialTextBox.Name = "productoNombreComercialTextBox";
            this.productoNombreComercialTextBox.Size = new System.Drawing.Size(515, 20);
            this.productoNombreComercialTextBox.TabIndex = 10;
            // 
            // productoUMLabel
            // 
            productoUMLabel.AutoSize = true;
            productoUMLabel.Location = new System.Drawing.Point(92, 191);
            productoUMLabel.Name = "productoUMLabel";
            productoUMLabel.Size = new System.Drawing.Size(73, 13);
            productoUMLabel.TabIndex = 11;
            productoUMLabel.Text = "Producto UM:";
            // 
            // productoUMTextBox
            // 
            this.productoUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductoBindingSource, "ProductoUM", true));
            this.productoUMTextBox.Location = new System.Drawing.Point(240, 188);
            this.productoUMTextBox.Name = "productoUMTextBox";
            this.productoUMTextBox.Size = new System.Drawing.Size(515, 20);
            this.productoUMTextBox.TabIndex = 12;
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(productoActivoLabel);
            this.Controls.Add(this.productoActivoCheckBox);
            this.Controls.Add(productoDescripcionLabel);
            this.Controls.Add(this.productoDescripcionTextBox);
            this.Controls.Add(productoNombreLabel);
            this.Controls.Add(this.productoNombreTextBox);
            this.Controls.Add(productoNombreComercialLabel);
            this.Controls.Add(this.productoNombreComercialTextBox);
            this.Controls.Add(productoUMLabel);
            this.Controls.Add(this.productoUMTextBox);
            this.Controls.Add(this.listaProductoBindingNavigator);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductoBindingNavigator)).EndInit();
            this.listaProductoBindingNavigator.ResumeLayout(false);
            this.listaProductoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProductoBindingSource;
        private System.Windows.Forms.BindingNavigator listaProductoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaProductoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.CheckBox productoActivoCheckBox;
        private System.Windows.Forms.TextBox productoDescripcionTextBox;
        private System.Windows.Forms.TextBox productoNombreTextBox;
        private System.Windows.Forms.TextBox productoNombreComercialTextBox;
        private System.Windows.Forms.TextBox productoUMTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}