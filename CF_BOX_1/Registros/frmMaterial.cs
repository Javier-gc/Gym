namespace CF_BOX_1
{
    using Common.Cache;
    using Domain;
    using System;
    using System.Windows.Forms;
    using System.Text.RegularExpressions;

    public partial class frmMaterial : Form
    {
        string PageAction;
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMaterial.Material' Puede moverla o quitarla según sea necesario.
            this.materialTableAdapter.Fill(this.dsMaterial.Material);

            EstablecerEstado(false);

            lblidRegistro.Text = Convert.ToString(registroCache.idRegistro + 1);
        }

        private void EstablecerEstado(bool v)
        {
            toolStripAgregar.Enabled = !v;
            toolStripModificar.Enabled = !v;
            toolStripBorrar.Enabled = !v;
            toolStripGuardar.Enabled = v;
            toolStripCancelar.Enabled = v;
            toolStripSalir.Enabled = !v;

            dgMaterial.Enabled = !v;
            gbDatosMaterial.Enabled = v;
            gbBusqueda.Enabled = !v;
        }

        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.materialTableAdapter.FillByNombre(this.dsMaterial.Material, "%" + txtBusqueda.Text.ToString() + "%");
        }

        private void ToolStripAgregar_Click(object sender, EventArgs e)
        {
            PageAction = "ADD";
            ClearField();
            EstablecerEstado(true);
            txtNombre.Focus();
        }

        private void ClearField()
        {
            txtNombre.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtStock.Text = String.Empty;
            txtIDregistro.Text = String.Empty;
        }

        private void ToolStripModificar_Click(object sender, EventArgs e)
        {
            PageAction = "EDIT";
            CargaDeMaterial();
            txtNombre.Focus();
            EstablecerEstado(true);

        }

        private void CargaDeMaterial()
        {
            if (dgMaterial.CurrentCell == null)
            {
                MessageBox.Show("No hay personal en el sistema", "Warning", MessageBoxButtons.OK);
                EstablecerEstado(false);
                return;
            }

            txtNombre.Text = dgMaterial[1, dgMaterial.CurrentRow.Index].Value.ToString();
            txtCantidad.Text = dgMaterial[2, dgMaterial.CurrentRow.Index].Value.ToString();
            txtStock.Text = dgMaterial[3, dgMaterial.CurrentRow.Index].Value.ToString();
            txtIDregistro.Text = dgMaterial[4, dgMaterial.CurrentRow.Index].Value.ToString();
        }

        private void ToolStripCancelar_Click(object sender, EventArgs e)
        {
            EstablecerEstado(false);
            ClearField();
        }

        private void ToolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes de introducir un nombre", "Warning", MessageBoxButtons.OK);
                txtNombre.Focus();
                return;
            }

            if (txtCantidad.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes de introducir una cantidad", "Warning", MessageBoxButtons.OK);
                txtCantidad.Focus();
                return;
            }

            if (PageAction == "ADD")
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.InsertarMaterial(txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtIDregistro.Text));
                this.materialTableAdapter.Fill(this.dsMaterial.Material);
                EstablecerEstado(false);
            }
            else
            {
                if (PageAction == "EDIT")
                {
                    if (int.Parse(dgMaterial[0, dgMaterial.CurrentRow.Index].Value.ToString()) == 1)
                    {
                        MessageBox.Show("Esté personal no se puede editar", "Warning", MessageBoxButtons.OK);
                        ClearField();
                        EstablecerEstado(false);
                        return;
                    }

                   // ID = Convert.ToInt32(dgUsuarios[0, dgUsuarios.CurrentRow.Index].Value.ToString());
                   // usuarioModel.editarUsuario(ID, Tipousuario, txtNombre.Text.ToUpper(), txtAPaterno.Text.ToUpper(), txtAMaterno.Text.ToUpper(), txtUsuario.Text, txtPassword.Text);
                   //  this.DATATABLE_USUARIOTableAdapter.Fill(this.dsProyecto.DATATABLE_USUARIO);

                    int ID;

                    ID = Convert.ToInt32(dgMaterial[0, dgMaterial.CurrentRow.Index].Value.ToString());
                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.EditarMaterial(ID, txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtIDregistro.Text));
                    this.materialTableAdapter.Fill(this.dsMaterial.Material);
                    EstablecerEstado(false);
                }
            }
        }

        private void ToolStripBorrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgMaterial[0, dgMaterial.CurrentRow.Index].Value.ToString());
            if (id == 1)
            {
                MessageBox.Show("No se puede borrar esté material", "Warning", MessageBoxButtons.OK);
                ClearField();
                EstablecerEstado(false);
                return;
            }

            if (MessageBox.Show("Seguro que desea borrar este Material??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.BorrarMaterial(id);
                this.materialTableAdapter.Fill(this.dsMaterial.Material);
                EstablecerEstado(false);
                ClearField();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números");
                txtCantidad.Text = txtCantidad.Text.Remove(txtCantidad.Text.Length - 1);
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStock.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números");
                txtStock.Text = txtStock.Text.Remove(txtStock.Text.Length - 1);
            }
        }

        private void txtIDregistro_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDregistro.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números");
                txtIDregistro.Text = txtIDregistro.Text.Remove(txtIDregistro.Text.Length - 1);
            }
        }
    }
}
