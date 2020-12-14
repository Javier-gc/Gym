namespace CF_BOX_1.Registros
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new CF_BOX_1.DataSets.dsClientes();
            this.clienteTableAdapter = new CF_BOX_1.DataSets.dsClientesTableAdapters.ClienteTableAdapter();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioFinalizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClases = new CF_BOX_1.DataSets.dsClases();
            this.lblidRegistro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtIDetalles = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clasesTableAdapter = new CF_BOX_1.DataSets.dsClasesTableAdapters.ClasesTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClases)).BeginInit();
            this.gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
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
            this.toolStrip1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(320, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Cliente";
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AutoGenerateColumns = false;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.idDetallesDataGridViewTextBoxColumn});
            this.dgCliente.DataSource = this.clienteBindingSource;
            this.dgCliente.Location = new System.Drawing.Point(16, 142);
            this.dgCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.RowHeadersWidth = 51;
            this.dgCliente.Size = new System.Drawing.Size(1035, 315);
            this.dgCliente.TabIndex = 5;
            this.dgCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellContentClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 91;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 87;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 87;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 70;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 96;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 93;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 80;
            // 
            // idDetallesDataGridViewTextBoxColumn
            // 
            this.idDetallesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDetallesDataGridViewTextBoxColumn.DataPropertyName = "idDetalles";
            this.idDetallesDataGridViewTextBoxColumn.HeaderText = "idDetalles";
            this.idDetallesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDetallesDataGridViewTextBoxColumn.Name = "idDetallesDataGridViewTextBoxColumn";
            this.idDetallesDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetallesDataGridViewTextBoxColumn.Width = 99;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dsClientes;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "dsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.dataGridView1);
            this.gbBusqueda.Controls.Add(this.lblidRegistro);
            this.gbBusqueda.Controls.Add(this.label11);
            this.gbBusqueda.Controls.Add(this.txtBusqueda);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbBusqueda.Location = new System.Drawing.Point(16, 480);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Size = new System.Drawing.Size(349, 370);
            this.gbBusqueda.TabIndex = 6;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClasesDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.horarioInicioDataGridViewTextBoxColumn,
            this.horarioFinalizaDataGridViewTextBoxColumn,
            this.idRegistroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(333, 220);
            this.dataGridView1.TabIndex = 4;
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
            this.horarioInicioDataGridViewTextBoxColumn.Visible = false;
            this.horarioInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // horarioFinalizaDataGridViewTextBoxColumn
            // 
            this.horarioFinalizaDataGridViewTextBoxColumn.DataPropertyName = "horarioFinaliza";
            this.horarioFinalizaDataGridViewTextBoxColumn.HeaderText = "horarioFinaliza";
            this.horarioFinalizaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horarioFinalizaDataGridViewTextBoxColumn.Name = "horarioFinalizaDataGridViewTextBoxColumn";
            this.horarioFinalizaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioFinalizaDataGridViewTextBoxColumn.Visible = false;
            this.horarioFinalizaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idRegistroDataGridViewTextBoxColumn
            // 
            this.idRegistroDataGridViewTextBoxColumn.DataPropertyName = "idRegistro";
            this.idRegistroDataGridViewTextBoxColumn.HeaderText = "idRegistro";
            this.idRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRegistroDataGridViewTextBoxColumn.Name = "idRegistroDataGridViewTextBoxColumn";
            this.idRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRegistroDataGridViewTextBoxColumn.Visible = false;
            this.idRegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // clasesBindingSource
            // 
            this.clasesBindingSource.DataMember = "Clases";
            this.clasesBindingSource.DataSource = this.dsClasesBindingSource;
            // 
            // dsClasesBindingSource
            // 
            this.dsClasesBindingSource.DataSource = this.dsClases;
            this.dsClasesBindingSource.Position = 0;
            // 
            // dsClases
            // 
            this.dsClases.DataSetName = "dsClases";
            this.dsClases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblidRegistro
            // 
            this.lblidRegistro.AutoSize = true;
            this.lblidRegistro.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidRegistro.Location = new System.Drawing.Point(123, 97);
            this.lblidRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidRegistro.Name = "lblidRegistro";
            this.lblidRegistro.Size = new System.Drawing.Size(130, 42);
            this.lblidRegistro.TabIndex = 3;
            this.lblidRegistro.Text = "ID Detalle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID Detalle:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(29, 60);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(295, 32);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.txtIDetalles);
            this.gbDatosCliente.Controls.Add(this.label10);
            this.gbDatosCliente.Controls.Add(this.txtCorreo);
            this.gbDatosCliente.Controls.Add(this.txtTelefono);
            this.gbDatosCliente.Controls.Add(this.txtDireccion);
            this.gbDatosCliente.Controls.Add(this.txtEdad);
            this.gbDatosCliente.Controls.Add(this.txtApellido);
            this.gbDatosCliente.Controls.Add(this.txtNombre);
            this.gbDatosCliente.Controls.Add(this.label8);
            this.gbDatosCliente.Controls.Add(this.label7);
            this.gbDatosCliente.Controls.Add(this.label6);
            this.gbDatosCliente.Controls.Add(this.label5);
            this.gbDatosCliente.Controls.Add(this.label4);
            this.gbDatosCliente.Controls.Add(this.label3);
            this.gbDatosCliente.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbDatosCliente.Location = new System.Drawing.Point(385, 480);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosCliente.Size = new System.Drawing.Size(665, 370);
            this.gbDatosCliente.TabIndex = 7;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // txtIDetalles
            // 
            this.txtIDetalles.Location = new System.Drawing.Point(127, 308);
            this.txtIDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDetalles.MaxLength = 70;
            this.txtIDetalles.Name = "txtIDetalles";
            this.txtIDetalles.Size = new System.Drawing.Size(517, 32);
            this.txtIDetalles.TabIndex = 10;
            this.txtIDetalles.TextChanged += new System.EventHandler(this.txtIDetalles_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 311);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "id Detalles:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(127, 261);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 70;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(517, 32);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(127, 215);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(517, 32);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(127, 172);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 70;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(517, 32);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(127, 130);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(517, 32);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(127, 87);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 70;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(517, 32);
            this.txtApellido.TabIndex = 3;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido:";
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
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.dsClientes;
            // 
            // clasesTableAdapter
            // 
            this.clasesTableAdapter.ClearBeforeFill = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 873);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClases)).EndInit();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgCliente;
        private DataSets.dsClientes dsClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataSets.dsClientesTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblidRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtIDetalles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private DataSets.dsClases dsClases;
        private System.Windows.Forms.BindingSource dsClasesBindingSource;
        private System.Windows.Forms.BindingSource clasesBindingSource;
        private DataSets.dsClasesTableAdapters.ClasesTableAdapter clasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioFinalizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroDataGridViewTextBoxColumn;
    }
}