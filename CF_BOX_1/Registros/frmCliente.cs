namespace CF_BOX_1.Registros
{
    using Common.Cache;
    using Domain;
    using System;
    using System.Windows.Forms;
    public partial class frmCliente : Form
    {
        string PageAction;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClases.Clases' Puede moverla o quitarla según sea necesario.
            this.clasesTableAdapter.Fill(this.dsClases.Clases);
            // TODO: esta línea de código carga datos en la tabla 'dsClientes.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dsClientes.Cliente);

            EstablecerEstado(false);

            lblidRegistro.Text = Convert.ToString(detallesCache.idDetalles+1);
        }

        private void EstablecerEstado(bool v)
        {
            toolStripAgregar.Enabled = !v;
            toolStripModificar.Enabled = !v;
            toolStripBorrar.Enabled = !v;
            toolStripGuardar.Enabled = v;
            toolStripCancelar.Enabled = v;
            toolStripSalir.Enabled = !v;

            dgCliente.Enabled = !v;
            gbDatosCliente.Enabled = v;
            gbBusqueda.Enabled = !v;
        }

        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByNombre(this.dsClientes.Cliente, "%" + txtBusqueda.Text.ToString() + "%");
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
            txtApellido.Text = String.Empty;
            txtEdad.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtIDetalles.Text = String.Empty;
        }

        private void ToolStripModificar_Click(object sender, EventArgs e)
        {
            PageAction = "EDIT";
            CargaDeCliente();
            txtNombre.Focus();
            EstablecerEstado(true);
        }

        private void CargaDeCliente()
        {
            if (dgCliente.CurrentCell == null)
            {
                MessageBox.Show("No hay clientes en el sistema", "Warning", MessageBoxButtons.OK);
                EstablecerEstado(false);
                return;
            }

            txtNombre.Text = dgCliente[1, dgCliente.CurrentRow.Index].Value.ToString();
            txtApellido.Text = dgCliente[2, dgCliente.CurrentRow.Index].Value.ToString();
            txtEdad.Text = dgCliente[3, dgCliente.CurrentRow.Index].Value.ToString();
            txtDireccion.Text = dgCliente[4, dgCliente.CurrentRow.Index].Value.ToString();
            txtTelefono.Text = dgCliente[5, dgCliente.CurrentRow.Index].Value.ToString();
            txtCorreo.Text = dgCliente[6, dgCliente.CurrentRow.Index].Value.ToString();
            txtIDetalles.Text = dgCliente[7, dgCliente.CurrentRow.Index].Value.ToString();
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

            if (txtApellido.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes de introducir un apellido", "Warning", MessageBoxButtons.OK);
                txtApellido.Focus();
                return;
            }

            if (PageAction == "ADD")
            {
                UsuarioModel usuarioModel = new UsuarioModel();

                usuarioModel.InsertarCliente(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, Convert.ToInt32(txtIDetalles.Text));
                this.clienteTableAdapter.Fill(this.dsClientes.Cliente);
                EstablecerEstado(false);
            }
            else
            {
                if (PageAction == "EDIT")
                {
                    int ID;
                    ID = int.Parse(dgCliente[0, dgCliente.CurrentRow.Index].Value.ToString());

                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.EditarCliente(ID, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtDireccion.Text,txtTelefono.Text, txtCorreo.Text, Convert.ToInt32(txtIDetalles.Text));
                    this.clienteTableAdapter.Fill(this.dsClientes.Cliente);
                    EstablecerEstado(false);
                }
            }
        }

        private void ToolStripBorrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCliente[0, dgCliente.CurrentRow.Index].Value.ToString());

            if (MessageBox.Show("Seguro que desea borrar este personal??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.BorrarCliente(id);
                EstablecerEstado(false);
                this.clienteTableAdapter.Fill(this.dsClientes.Cliente);
                ClearField();
            }
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEdad.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números");
                txtEdad.Text = txtEdad.Text.Remove(txtEdad.Text.Length - 1);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números");
                txtTelefono.Text = txtTelefono.Text.Remove(txtTelefono.Text.Length - 1);
            }
        }

        private void txtIDetalles_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDetalles.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingresa solo números");
                txtIDetalles.Text = txtIDetalles.Text.Remove(txtIDetalles.Text.Length - 1);
            }
        }
    }
}
