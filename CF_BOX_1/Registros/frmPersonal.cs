namespace CF_BOX_1
{
    using Common.Cache;
    using Domain;
    using System;
    using System.Windows.Forms;

    public partial class frmPersonal : Form
    {
        string PageAction;
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPersonal.Personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.dsPersonal.Personal);
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

            dgPersonal.Enabled = !v;
            gbDatosPersonal.Enabled = v;
            gbBusqueda.Enabled = !v;
        }

        private void TxtPuesto_TextChanged(object sender, EventArgs e)
        {
            this.personalTableAdapter.FillByPuesto(this.dsPersonal.Personal, "%" + txtBusquedaPuesto.Text.ToString() + "%");
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
            txtPuesto.Text = String.Empty;
            txtIDregistro.Text = String.Empty;
        }

        private void ToolStripModificar_Click(object sender, EventArgs e)
        {
            PageAction = "EDIT";
            CargaDePersonal();
            txtNombre.Focus();
            EstablecerEstado(true);
        }

        private void CargaDePersonal()
        {
            if (dgPersonal.CurrentCell == null)
            {
                MessageBox.Show("No hay personal en el sistema", "Warning", MessageBoxButtons.OK);
                EstablecerEstado(false);
                return;
            }

            txtNombre.Text = dgPersonal[1, dgPersonal.CurrentRow.Index].Value.ToString();
            txtApellido.Text = dgPersonal[2, dgPersonal.CurrentRow.Index].Value.ToString();
            txtEdad.Text = dgPersonal[3, dgPersonal.CurrentRow.Index].Value.ToString();
            txtDireccion.Text = dgPersonal[4, dgPersonal.CurrentRow.Index].Value.ToString();
            txtTelefono.Text = dgPersonal[5, dgPersonal.CurrentRow.Index].Value.ToString();
            txtCorreo.Text = dgPersonal[6, dgPersonal.CurrentRow.Index].Value.ToString();
            txtPuesto.Text = dgPersonal[7, dgPersonal.CurrentRow.Index].Value.ToString();
            txtIDregistro.Text = dgPersonal[8, dgPersonal.CurrentRow.Index].Value.ToString();

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

            if (txtPuesto.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes de introducir un puesto", "Warning", MessageBoxButtons.OK);
                txtPuesto.Focus();
                return;
            }

            if (PageAction == "ADD")
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.InsertarPersonal(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtPuesto.Text, Convert.ToInt32(txtIDregistro.Text));
                this.personalTableAdapter.Fill(this.dsPersonal.Personal);
                EstablecerEstado(false);
            }
            else
            {
                if (PageAction == "EDIT")
                {
                    if (int.Parse(dgPersonal[0, dgPersonal.CurrentRow.Index].Value.ToString()) == 1)
                    {
                        MessageBox.Show("Esté personal no se puede editar", "Warning", MessageBoxButtons.OK);
                        ClearField();
                        EstablecerEstado(false);
                        return;
                    }
                    int ID;
                    ID = int.Parse(dgPersonal[0, dgPersonal.CurrentRow.Index].Value.ToString());

                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.EditarPersonal(ID, txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtPuesto.Text, Convert.ToInt32(txtIDregistro.Text));
                    this.personalTableAdapter.Fill(this.dsPersonal.Personal);
                    EstablecerEstado(false);
                }
            }
        }

        private void ToolStripBorrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgPersonal[0, dgPersonal.CurrentRow.Index].Value.ToString());
            if (id == 1)
            {
                MessageBox.Show("No se puede borrar a esté personal", "Warning", MessageBoxButtons.OK);
                ClearField();
                this.personalTableAdapter.Fill(this.dsPersonal.Personal);
                EstablecerEstado(false);
                return;
            }

            if (MessageBox.Show("Seguro que desea borrar este personal??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.BorrarPersonal(id);
                EstablecerEstado(false);
                 this.personalTableAdapter.Fill(this.dsPersonal.Personal);
                ClearField();
            }
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
