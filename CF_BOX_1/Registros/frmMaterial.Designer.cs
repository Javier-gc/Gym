namespace CF_BOX_1
{
    partial class frmMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterial));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMaterial = new System.Windows.Forms.DataGridView();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial = new CF_BOX_1.DataSets.dsMaterial();
            this.materialTableAdapter = new CF_BOX_1.DataSets.dsMaterialTableAdapters.MaterialTableAdapter();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblidRegistro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosMaterial = new System.Windows.Forms.GroupBox();
            this.txtIDregistro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.gbDatosMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgregar,
            this.toolStripModificar,
            this.toolStripBorrar,
            this.toolStripSeparator1,
            this.toolStripGuardar,
            this.toolStripCancelar,
            this.toolStripSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 51);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStripAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgregar.Image")));
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(96, 48);
            this.toolStripAgregar.Text = "&Agregar";
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAgregar.Click += new System.EventHandler(this.ToolStripAgregar_Click);
            // 
            // toolStripModificar
            // 
            this.toolStripModificar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripModificar.Image")));
            this.toolStripModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripModificar.Name = "toolStripModificar";
            this.toolStripModificar.Size = new System.Drawing.Size(109, 48);
            this.toolStripModificar.Text = "&Modificar";
            this.toolStripModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripModificar.Click += new System.EventHandler(this.ToolStripModificar_Click);
            // 
            // toolStripBorrar
            // 
            this.toolStripBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBorrar.Image")));
            this.toolStripBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBorrar.Name = "toolStripBorrar";
            this.toolStripBorrar.Size = new System.Drawing.Size(79, 48);
            this.toolStripBorrar.Text = "&Borrar";
            this.toolStripBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBorrar.Click += new System.EventHandler(this.ToolStripBorrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(97, 48);
            this.toolStripGuardar.Text = "&Guardar";
            this.toolStripGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripGuardar.Click += new System.EventHandler(this.ToolStripGuardar_Click);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(102, 48);
            this.toolStripCancelar.Text = "&Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Click += new System.EventHandler(this.ToolStripCancelar_Click);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSalir.Image")));
            this.toolStripSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(60, 48);
            this.toolStripSalir.Text = "&Salir";
            this.toolStripSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSalir.Click += new System.EventHandler(this.ToolStripSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(325, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de Material";
            // 
            // dgMaterial
            // 
            this.dgMaterial.AllowUserToAddRows = false;
            this.dgMaterial.AllowUserToDeleteRows = false;
            this.dgMaterial.AutoGenerateColumns = false;
            this.dgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.idRegistroDataGridViewTextBoxColumn});
            this.dgMaterial.DataSource = this.materialBindingSource;
            this.dgMaterial.Location = new System.Drawing.Point(16, 159);
            this.dgMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dgMaterial.Name = "dgMaterial";
            this.dgMaterial.ReadOnly = true;
            this.dgMaterial.RowHeadersWidth = 51;
            this.dgMaterial.Size = new System.Drawing.Size(1035, 343);
            this.dgMaterial.TabIndex = 4;
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "idMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "idMaterial";
            this.idMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // idRegistroDataGridViewTextBoxColumn
            // 
            this.idRegistroDataGridViewTextBoxColumn.DataPropertyName = "idRegistro";
            this.idRegistroDataGridViewTextBoxColumn.HeaderText = "idRegistro";
            this.idRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRegistroDataGridViewTextBoxColumn.Name = "idRegistroDataGridViewTextBoxColumn";
            this.idRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.dsMaterial;
            // 
            // dsMaterial
            // 
            this.dsMaterial.DataSetName = "dsMaterial";
            this.dsMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblidRegistro);
            this.gbBusqueda.Controls.Add(this.label11);
            this.gbBusqueda.Controls.Add(this.txtBusqueda);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbBusqueda.Location = new System.Drawing.Point(16, 534);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Size = new System.Drawing.Size(349, 283);
            this.gbBusqueda.TabIndex = 5;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // lblidRegistro
            // 
            this.lblidRegistro.AutoSize = true;
            this.lblidRegistro.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidRegistro.Location = new System.Drawing.Point(123, 164);
            this.lblidRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidRegistro.Name = "lblidRegistro";
            this.lblidRegistro.Size = new System.Drawing.Size(159, 42);
            this.lblidRegistro.TabIndex = 3;
            this.lblidRegistro.Text = "ID Registro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID Registro:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(29, 87);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(295, 32);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Material:";
            // 
            // gbDatosMaterial
            // 
            this.gbDatosMaterial.Controls.Add(this.txtIDregistro);
            this.gbDatosMaterial.Controls.Add(this.label10);
            this.gbDatosMaterial.Controls.Add(this.txtStock);
            this.gbDatosMaterial.Controls.Add(this.txtCantidad);
            this.gbDatosMaterial.Controls.Add(this.txtNombre);
            this.gbDatosMaterial.Controls.Add(this.label5);
            this.gbDatosMaterial.Controls.Add(this.label4);
            this.gbDatosMaterial.Controls.Add(this.label3);
            this.gbDatosMaterial.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMaterial.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbDatosMaterial.Location = new System.Drawing.Point(397, 534);
            this.gbDatosMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosMaterial.Name = "gbDatosMaterial";
            this.gbDatosMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosMaterial.Size = new System.Drawing.Size(653, 283);
            this.gbDatosMaterial.TabIndex = 6;
            this.gbDatosMaterial.TabStop = false;
            this.gbDatosMaterial.Text = "Datos del Material";
            // 
            // txtIDregistro
            // 
            this.txtIDregistro.Location = new System.Drawing.Point(127, 172);
            this.txtIDregistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDregistro.MaxLength = 70;
            this.txtIDregistro.Name = "txtIDregistro";
            this.txtIDregistro.Size = new System.Drawing.Size(517, 32);
            this.txtIDregistro.TabIndex = 10;
            this.txtIDregistro.TextChanged += new System.EventHandler(this.txtIDregistro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "id Registro:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(127, 130);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.MaxLength = 70;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(517, 32);
            this.txtStock.TabIndex = 4;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(127, 87);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.MaxLength = 70;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(517, 32);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 70;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(517, 32);
            this.txtNombre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 842);
            this.Controls.Add(this.gbDatosMaterial);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dgMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaterial";
            this.Load += new System.EventHandler(this.FrmMaterial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbDatosMaterial.ResumeLayout(false);
            this.gbDatosMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripModificar;
        private System.Windows.Forms.ToolStripButton toolStripBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMaterial;
        private DataSets.dsMaterial dsMaterial;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DataSets.dsMaterialTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblidRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatosMaterial;
        private System.Windows.Forms.TextBox txtIDregistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}