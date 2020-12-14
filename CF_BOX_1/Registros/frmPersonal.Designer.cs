namespace CF_BOX_1
{
    partial class frmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.idPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPersonal = new CF_BOX_1.DataSets.dsPersonal();
            this.label1 = new System.Windows.Forms.Label();
            this.personalTableAdapter = new CF_BOX_1.DataSets.dsPersonalTableAdapters.PersonalTableAdapter();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblidRegistro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusquedaPuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosPersonal = new System.Windows.Forms.GroupBox();
            this.txtIDregistro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPersonal)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.gbDatosPersonal.SuspendLayout();
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
            this.toolStrip1.TabIndex = 0;
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
            // dgPersonal
            // 
            this.dgPersonal.AllowUserToAddRows = false;
            this.dgPersonal.AllowUserToDeleteRows = false;
            this.dgPersonal.AutoGenerateColumns = false;
            this.dgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonalDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.idRegistroDataGridViewTextBoxColumn});
            this.dgPersonal.DataSource = this.personalBindingSource;
            this.dgPersonal.Location = new System.Drawing.Point(16, 134);
            this.dgPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.dgPersonal.Name = "dgPersonal";
            this.dgPersonal.ReadOnly = true;
            this.dgPersonal.RowHeadersWidth = 51;
            this.dgPersonal.Size = new System.Drawing.Size(1035, 287);
            this.dgPersonal.TabIndex = 1;
            // 
            // idPersonalDataGridViewTextBoxColumn
            // 
            this.idPersonalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idPersonalDataGridViewTextBoxColumn.DataPropertyName = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.HeaderText = "idPersonal";
            this.idPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPersonalDataGridViewTextBoxColumn.Name = "idPersonalDataGridViewTextBoxColumn";
            this.idPersonalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonalDataGridViewTextBoxColumn.Width = 104;
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
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.puestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            this.puestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.puestoDataGridViewTextBoxColumn.Width = 81;
            // 
            // idRegistroDataGridViewTextBoxColumn
            // 
            this.idRegistroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idRegistroDataGridViewTextBoxColumn.DataPropertyName = "idRegistro";
            this.idRegistroDataGridViewTextBoxColumn.HeaderText = "idRegistro";
            this.idRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRegistroDataGridViewTextBoxColumn.Name = "idRegistroDataGridViewTextBoxColumn";
            this.idRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRegistroDataGridViewTextBoxColumn.Width = 101;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.dsPersonal;
            // 
            // dsPersonal
            // 
            this.dsPersonal.DataSetName = "dsPersonal";
            this.dsPersonal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(316, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de Personal";
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblidRegistro);
            this.gbBusqueda.Controls.Add(this.label11);
            this.gbBusqueda.Controls.Add(this.txtBusquedaPuesto);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbBusqueda.Location = new System.Drawing.Point(16, 454);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.gbBusqueda.Size = new System.Drawing.Size(349, 283);
            this.gbBusqueda.TabIndex = 3;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // lblidRegistro
            // 
            this.lblidRegistro.AutoSize = true;
            this.lblidRegistro.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidRegistro.Location = new System.Drawing.Point(124, 164);
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
            // txtBusquedaPuesto
            // 
            this.txtBusquedaPuesto.Location = new System.Drawing.Point(29, 87);
            this.txtBusquedaPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaPuesto.Name = "txtBusquedaPuesto";
            this.txtBusquedaPuesto.Size = new System.Drawing.Size(295, 32);
            this.txtBusquedaPuesto.TabIndex = 1;
            this.txtBusquedaPuesto.TextChanged += new System.EventHandler(this.TxtPuesto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puesto:";
            // 
            // gbDatosPersonal
            // 
            this.gbDatosPersonal.Controls.Add(this.txtIDregistro);
            this.gbDatosPersonal.Controls.Add(this.label10);
            this.gbDatosPersonal.Controls.Add(this.txtPuesto);
            this.gbDatosPersonal.Controls.Add(this.txtCorreo);
            this.gbDatosPersonal.Controls.Add(this.txtTelefono);
            this.gbDatosPersonal.Controls.Add(this.txtDireccion);
            this.gbDatosPersonal.Controls.Add(this.txtEdad);
            this.gbDatosPersonal.Controls.Add(this.txtApellido);
            this.gbDatosPersonal.Controls.Add(this.txtNombre);
            this.gbDatosPersonal.Controls.Add(this.label9);
            this.gbDatosPersonal.Controls.Add(this.label8);
            this.gbDatosPersonal.Controls.Add(this.label7);
            this.gbDatosPersonal.Controls.Add(this.label6);
            this.gbDatosPersonal.Controls.Add(this.label5);
            this.gbDatosPersonal.Controls.Add(this.label4);
            this.gbDatosPersonal.Controls.Add(this.label3);
            this.gbDatosPersonal.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonal.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbDatosPersonal.Location = new System.Drawing.Point(397, 454);
            this.gbDatosPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosPersonal.Name = "gbDatosPersonal";
            this.gbDatosPersonal.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosPersonal.Size = new System.Drawing.Size(653, 416);
            this.gbDatosPersonal.TabIndex = 4;
            this.gbDatosPersonal.TabStop = false;
            this.gbDatosPersonal.Text = "Datos del Personal";
            // 
            // txtIDregistro
            // 
            this.txtIDregistro.Location = new System.Drawing.Point(127, 356);
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
            this.label10.Location = new System.Drawing.Point(15, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "id Registro:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(127, 304);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuesto.MaxLength = 70;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(517, 32);
            this.txtPuesto.TabIndex = 8;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Puesto:";
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
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 885);
            this.Controls.Add(this.gbDatosPersonal);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPersonal);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPersonal)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbDatosPersonal.ResumeLayout(false);
            this.gbDatosPersonal.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.Label label1;
        private DataSets.dsPersonal dsPersonal;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private DataSets.dsPersonalTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatosPersonal;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDregistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblidRegistro;
        private System.Windows.Forms.Label label11;
    }
}