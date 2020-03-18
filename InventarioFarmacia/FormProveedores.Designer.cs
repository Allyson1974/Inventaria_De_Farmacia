namespace InventarioFarmacia
{
    partial class FormProveedores
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label disponibleLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label rTNLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.listaProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.listadeProvedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.listadeProvedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listadeProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.proveedorBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaProveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listadeProveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            direccionLabel = new System.Windows.Forms.Label();
            disponibleLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            rTNLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProvedoresBindingNavigator)).BeginInit();
            this.listadeProvedoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 95);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 60;
            direccionLabel.Text = "Direccion:";
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.Location = new System.Drawing.Point(12, 208);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Size = new System.Drawing.Size(59, 13);
            disponibleLabel.TabIndex = 62;
            disponibleLabel.Text = "Disponible:";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(12, 124);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(51, 13);
            empresaLabel.TabIndex = 64;
            empresaLabel.Text = "Empresa:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 66);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 66;
            idLabel.Text = "Id:";
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Location = new System.Drawing.Point(12, 154);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(33, 13);
            rTNLabel.TabIndex = 68;
            rTNLabel.Text = "RTN:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 180);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 70;
            telefonoLabel.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso de Proveedores";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(12, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 20);
            this.textBox1.TabIndex = 60;
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
            // listadeProvedoresBindingNavigatorSaveItem
            // 
            this.listadeProvedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeProvedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeProvedoresBindingNavigatorSaveItem.Image")));
            this.listadeProvedoresBindingNavigatorSaveItem.Name = "listadeProvedoresBindingNavigatorSaveItem";
            this.listadeProvedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listadeProvedoresBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // Cancelar
            // 
            this.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(57, 22);
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // listadeProvedoresBindingNavigator
            // 
            this.listadeProvedoresBindingNavigator.AddNewItem = null;
            this.listadeProvedoresBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.listadeProvedoresBindingNavigator.BindingSource = this.listaProveedoresBindingSource;
            this.listadeProvedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeProvedoresBindingNavigator.DeleteItem = null;
            this.listadeProvedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listadeProvedoresBindingNavigatorSaveItem,
            this.Cancelar});
            this.listadeProvedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeProvedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeProvedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeProvedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeProvedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeProvedoresBindingNavigator.Name = "listadeProvedoresBindingNavigator";
            this.listadeProvedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeProvedoresBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.listadeProvedoresBindingNavigator.TabIndex = 2;
            this.listadeProvedoresBindingNavigator.Text = "bindingNavigator1";
            this.listadeProvedoresBindingNavigator.RefreshItems += new System.EventHandler(this.listadeProveedoresBindingNavigator_RefreshItems);
            // 
            // listadeProveedoresBindingSource
            // 
            this.listadeProveedoresBindingSource.DataSource = typeof(BL.InventarioFarmacia.Proveedor);
            this.listadeProveedoresBindingSource.CurrentChanged += new System.EventHandler(this.listadeProveedoresBindingSource_CurrentChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(77, 92);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(377, 20);
            this.direccionTextBox.TabIndex = 61;
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listadeProveedoresBindingSource, "Disponible", true));
            this.disponibleCheckBox.Location = new System.Drawing.Point(77, 203);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(89, 24);
            this.disponibleCheckBox.TabIndex = 63;
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(77, 121);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(377, 20);
            this.empresaTextBox.TabIndex = 65;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(77, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(377, 20);
            this.idTextBox.TabIndex = 67;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "RTN", true));
            this.rTNTextBox.Location = new System.Drawing.Point(77, 151);
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(377, 20);
            this.rTNTextBox.TabIndex = 69;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(77, 177);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(377, 20);
            this.telefonoTextBox.TabIndex = 71;
            // 
            // proveedorBLBindingSource
            // 
            this.proveedorBLBindingSource.DataSource = typeof(BL.InventarioFarmacia.ProveedorBL);
            // 
            // listaProveedoresBindingSource1
            // 
            this.listaProveedoresBindingSource1.DataMember = "ListaProveedores";
            this.listaProveedoresBindingSource1.DataSource = this.proveedorBLBindingSource;
            // 
            // listadeProveedoresDataGridView
            // 
            this.listadeProveedoresDataGridView.AutoGenerateColumns = false;
            this.listadeProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeProveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn3});
            this.listadeProveedoresDataGridView.DataSource = this.listaProveedoresBindingSource1;
            this.listadeProveedoresDataGridView.Location = new System.Drawing.Point(12, 261);
            this.listadeProveedoresDataGridView.Name = "listadeProveedoresDataGridView";
            this.listadeProveedoresDataGridView.Size = new System.Drawing.Size(633, 220);
            this.listadeProveedoresDataGridView.TabIndex = 71;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RTN";
            this.dataGridViewTextBoxColumn11.HeaderText = "RTN";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Empresa";
            this.dataGridViewTextBoxColumn12.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn13.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn14.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Disponible";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Disponible";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(645, 540);
            this.Controls.Add(this.listadeProveedoresDataGridView);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(disponibleLabel);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(rTNLabel);
            this.Controls.Add(this.rTNTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listadeProvedoresBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProvedoresBindingNavigator)).EndInit();
            this.listadeProvedoresBindingNavigator.ResumeLayout(false);
            this.listadeProvedoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProveedoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource listaProveedoresBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton listadeProvedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton Cancelar;
        private System.Windows.Forms.BindingNavigator listadeProvedoresBindingNavigator;
        private System.Windows.Forms.BindingSource listadeProveedoresBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox rTNTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.BindingSource proveedorBLBindingSource;
        private System.Windows.Forms.BindingSource listaProveedoresBindingSource1;
        private System.Windows.Forms.DataGridView listadeProveedoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    }
}