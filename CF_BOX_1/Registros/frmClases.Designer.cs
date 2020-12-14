namespace CF_BOX_1
{
    partial class frmClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClases));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClases = new System.Windows.Forms.DataGridView();
            this.idClasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioFinalizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClases = new CF_BOX_1.DataSets.dsClases();
            this.clasesTableAdapter = new CF_BOX_1.DataSets.dsClasesTableAdapters.ClasesTableAdapter();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblidRegistro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosClases = new System.Windows.Forms.GroupBox();
            this.txtIDregistro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClases)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.gbDatosClases.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(305, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de Clases";
            // 
            // dgClases
            // 
            this.dgClases.AllowUserToAddRows = false;
            this.dgClases.AllowUserToDeleteRows = false;
            this.dgClases.AutoGenerateColumns = false;
            this.dgClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClasesDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.horarioInicioDataGridViewTextBoxColumn,
            this.horarioFinalizaDataGridViewTextBoxColumn,
            this.idRegistroDataGridViewTextBoxColumn});
            this.dgClases.DataSource = this.clasesBindingSource;
            this.dgClases.Location = new System.Drawing.Point(16, 145);
            this.dgClases.Margin = new System.Windows.Forms.Padding(4);
            this.dgClases.Name = "dgClases";
            this.dgClases.ReadOnly = true;
            this.dgClases.RowHeadersWidth = 51;
            this.dgClases.Size = new System.Drawing.Size(1035, 338);
            this.dgClases.TabIndex = 4;
            // 
            // idClasesDataGridViewTextBoxColumn
            // 
            this.idClasesDataGridViewTextBoxColumn.DataPropertyName = "idClases";
            this.idClasesDataGridViewTextBoxColumn.HeaderText = "idClases";
            this.idClasesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClasesDataGridViewTextBoxColumn.Name = "idClasesDataGridViewTextBoxColumn";
            this.idClasesDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClasesDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            this.diaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaDataGridViewTextBoxColumn.Width = 125;
            // 
            // horarioInicioDataGridViewTextBoxColumn
            // 
            this.horarioInicioDataGridViewTextBoxColumn.DataPropertyName = "HorarioInicio";
            this.horarioInicioDataGridViewTextBoxColumn.HeaderText = "HorarioInicio";
            this.horarioInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horarioInicioDataGridViewTextBoxColumn.Name = "horarioInicioDataGridViewTextBoxColumn";
            this.horarioInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // horarioFinalizaDataGridViewTextBoxColumn
            // 
            this.horarioFinalizaDataGridViewTextBoxColumn.DataPropertyName = "horarioFinaliza";
            this.horarioFinalizaDataGridViewTextBoxColumn.HeaderText = "horarioFinaliza";
            this.horarioFinalizaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horarioFinalizaDataGridViewTextBoxColumn.Name = "horarioFinalizaDataGridViewTextBoxColumn";
            this.horarioFinalizaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioFinalizaDataGridViewTextBoxColumn.Width = 125;
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
            // clasesBindingSource
            // 
            this.clasesBindingSource.DataMember = "Clases";
            this.clasesBindingSource.DataSource = this.dsClases;
            // 
            // dsClases
            // 
            this.dsClases.DataSetName = "dsClases";
            this.dsClases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasesTableAdapter
            // 
            this.clasesTableAdapter.ClearBeforeFill = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblidRegistro);
            this.gbBusqueda.Controls.Add(this.label11);
            this.gbBusqueda.Controls.Add(this.txtBusqueda);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbBusqueda.Location = new System.Drawing.Point(16, 503);
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
            this.lblidRegistro.Location = new System.Drawing.Point(121, 165);
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
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dia:";
            // 
            // gbDatosClases
            // 
            this.gbDatosClases.Controls.Add(this.txtIDregistro);
            this.gbDatosClases.Controls.Add(this.label10);
            this.gbDatosClases.Controls.Add(this.txtHoraFin);
            this.gbDatosClases.Controls.Add(this.txtHoraInicio);
            this.gbDatosClases.Controls.Add(this.txtDia);
            this.gbDatosClases.Controls.Add(this.label5);
            this.gbDatosClases.Controls.Add(this.label4);
            this.gbDatosClases.Controls.Add(this.label3);
            this.gbDatosClases.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosClases.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbDatosClases.Location = new System.Drawing.Point(397, 503);
            this.gbDatosClases.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosClases.Name = "gbDatosClases";
            this.gbDatosClases.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosClases.Size = new System.Drawing.Size(653, 283);
            this.gbDatosClases.TabIndex = 6;
            this.gbDatosClases.TabStop = false;
            this.gbDatosClases.Text = "Datos de las Clases";
            // 
            // txtIDregistro
            // 
            this.txtIDregistro.Location = new System.Drawing.Point(160, 202);
            this.txtIDregistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDregistro.MaxLength = 20;
            this.txtIDregistro.Name = "txtIDregistro";
            this.txtIDregistro.Size = new System.Drawing.Size(483, 32);
            this.txtIDregistro.TabIndex = 10;
            this.txtIDregistro.TextChanged += new System.EventHandler(this.txtIDregistro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "id Registro:";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(160, 156);
            this.txtHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraFin.MaxLength = 30;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(483, 32);
            this.txtHoraFin.TabIndex = 4;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(160, 113);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraInicio.MaxLength = 30;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(483, 32);
            this.txtHoraInicio.TabIndex = 3;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(160, 68);
            this.txtDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDia.MaxLength = 30;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(483, 32);
            this.txtDia.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horario Finaliza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Horario Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dia:";
            // 
            // btAddCliente
            // 
            this.btAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btAddCliente.FlatAppearance.BorderSize = 3;
            this.btAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCliente.Font = new System.Drawing.Font("Haettenschweiler", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCliente.ForeColor = System.Drawing.Color.DarkOrange;
            this.btAddCliente.Location = new System.Drawing.Point(764, 65);
            this.btAddCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(277, 70);
            this.btAddCliente.TabIndex = 7;
            this.btAddCliente.Text = "Add Cliente";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.BtAddCliente_Click);
            // 
            // frmClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 806);
            this.Controls.Add(this.btAddCliente);
            this.Controls.Add(this.gbDatosClases);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dgClases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClases";
            this.Load += new System.EventHandler(this.FrmClases_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClases)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbDatosClases.ResumeLayout(false);
            this.gbDatosClases.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgClases;
        private DataSets.dsClases dsClases;
        private System.Windows.Forms.BindingSource clasesBindingSource;
        private DataSets.dsClasesTableAdapters.ClasesTableAdapter clasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioFinalizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblidRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatosClases;
        private System.Windows.Forms.TextBox txtIDregistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddCliente;
    }
}