namespace CF_BOX_1
{
    partial class frmRegistro
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
            this.btMaterial = new System.Windows.Forms.Button();
            this.btPersonal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btClase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIDRegistro = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMaterial
            // 
            this.btMaterial.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaterial.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaterial.ForeColor = System.Drawing.Color.Gold;
            this.btMaterial.Location = new System.Drawing.Point(213, 292);
            this.btMaterial.Name = "btMaterial";
            this.btMaterial.Size = new System.Drawing.Size(141, 88);
            this.btMaterial.TabIndex = 0;
            this.btMaterial.Text = "Material";
            this.btMaterial.UseVisualStyleBackColor = true;
            this.btMaterial.Click += new System.EventHandler(this.BtMaterial_Click);
            // 
            // btPersonal
            // 
            this.btPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPersonal.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPersonal.ForeColor = System.Drawing.Color.Gold;
            this.btPersonal.Location = new System.Drawing.Point(558, 292);
            this.btPersonal.Name = "btPersonal";
            this.btPersonal.Size = new System.Drawing.Size(141, 88);
            this.btPersonal.TabIndex = 1;
            this.btPersonal.Text = "Personal";
            this.btPersonal.UseVisualStyleBackColor = true;
            this.btPersonal.Click += new System.EventHandler(this.BtPersonal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(5, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Registro:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSeciónToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::CF_BOX_1.Properties.Resources.Books;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // cerrarSeciónToolStripMenuItem
            // 
            this.cerrarSeciónToolStripMenuItem.Name = "cerrarSeciónToolStripMenuItem";
            this.cerrarSeciónToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.cerrarSeciónToolStripMenuItem.Text = "Cerrar Seción";
            this.cerrarSeciónToolStripMenuItem.Click += new System.EventHandler(this.CerrarSeciónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // btClase
            // 
            this.btClase.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClase.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClase.ForeColor = System.Drawing.Color.Gold;
            this.btClase.Location = new System.Drawing.Point(385, 292);
            this.btClase.Name = "btClase";
            this.btClase.Size = new System.Drawing.Size(141, 88);
            this.btClase.TabIndex = 7;
            this.btClase.Text = "Clase";
            this.btClase.UseVisualStyleBackColor = true;
            this.btClase.Click += new System.EventHandler(this.BtClase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIDRegistro);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Gold;
            this.lblID.Location = new System.Drawing.Point(109, 93);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 26);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "User:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gold;
            this.lblUser.Location = new System.Drawing.Point(109, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 26);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(74, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(373, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 67);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registro";
            // 
            // lbIDRegistro
            // 
            this.lbIDRegistro.AutoSize = true;
            this.lbIDRegistro.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDRegistro.ForeColor = System.Drawing.Color.Gold;
            this.lbIDRegistro.Location = new System.Drawing.Point(109, 145);
            this.lbIDRegistro.Name = "lbIDRegistro";
            this.lbIDRegistro.Size = new System.Drawing.Size(52, 26);
            this.lbIDRegistro.TabIndex = 13;
            this.lbIDRegistro.Text = "User:";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClase);
            this.Controls.Add(this.btPersonal);
            this.Controls.Add(this.btMaterial);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMaterial;
        private System.Windows.Forms.Button btPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btClase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIDRegistro;
    }
}