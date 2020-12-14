namespace CF_BOX_1
{
    using Common.Cache;
    using Domain;
    using System;
    using System.Windows.Forms;
    using CF_BOX_1.Registros;
 
    public partial class frmClases : Form
    {
        string PageAction;
        public frmClases()
        {
            InitializeComponent();
        }

        private void FrmClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClases.Clases' Puede moverla o quitarla según sea necesario.
            this.clasesTableAdapter.Fill(this.dsClases.Clases);

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

            dgClases.Enabled = !v;
            gbDatosClases.Enabled = v;
            gbBusqueda.Enabled = !v;
            btAddCliente.Enabled = !v;
        }

        private void ToolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.clasesTableAdapter.FillByDia(this.dsClases.Clases, "%" + txtBusqueda.Text.ToString() + "%");

        }

        private void ToolStripAgregar_Click(object sender, EventArgs e)
        {
            PageAction = "ADD";
            ClearField();
            EstablecerEstado(true);
            txtDia.Focus();
        }

        private void ClearField()
        {
            txtDia.Text = String.Empty;
            txtHoraFin.Text = String.Empty;
            txtHoraInicio.Text = String.Empty;
            txtIDregistro.Text = String.Empty;
            txtBusqueda.Text = String.Empty;
        }

        private void ToolStripModificar_Click(object sender, EventArgs e)
        {
            PageAction = "EDIT";
            CargaDeClases();
            txtDia.Focus();
            EstablecerEstado(true);
        }

        private void CargaDeClases()
        {
            if (dgClases.CurrentCell == null)
            {
                MessageBox.Show("No hay personal en el sistema", "Warning", MessageBoxButtons.OK);
                EstablecerEstado(false);
                return;
            }

            txtDia.Text = dgClases[1, dgClases.CurrentRow.Index].Value.ToString();
            txtHoraInicio.Text = dgClases[2, dgClases.CurrentRow.Index].Value.ToString();
            txtHoraFin.Text = dgClases[3, dgClases.CurrentRow.Index].Value.ToString();
            txtIDregistro.Text = dgClases[4, dgClases.CurrentRow.Index].Value.ToString();
        }

        private void ToolStripCancelar_Click(object sender, EventArgs e)
        {
            EstablecerEstado(false);
            ClearField();
        }

        private void ToolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtDia.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes de introducir un Dia", "Warning", MessageBoxButtons.OK);
                txtDia.Focus();
                return;
            }

            if (txtHoraInicio.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes de introducir una hora de inicio", "Warning", MessageBoxButtons.OK);
                txtHoraInicio.Focus();
                return;
            }

            if (PageAction == "ADD")
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.InsertarClases(txtDia.Text, txtHoraInicio.Text, txtHoraFin.Text, Convert.ToInt32(txtIDregistro.Text) );
                this.clasesTableAdapter.Fill(this.dsClases.Clases);
                EstablecerEstado(false);
            }
            else
            {
                if (PageAction == "EDIT")
                {
                    if (int.Parse(dgClases[0, dgClases.CurrentRow.Index].Value.ToString()) == 1)
                    {
                        MessageBox.Show("Está clase no se puede editar", "Warning", MessageBoxButtons.OK);
                        ClearField();
                        EstablecerEstado(false);
                        return;
                    }
                    int ID;
                    ID = int.Parse(dgClases[0, dgClases.CurrentRow.Index].Value.ToString());

                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.EditarClases(ID, txtDia.Text, txtHoraInicio.Text, txtHoraFin.Text, Convert.ToInt32(txtIDregistro.Text));
                    this.clasesTableAdapter.Fill(this.dsClases.Clases);
                    EstablecerEstado(false);
                }
            }
        }

        private void ToolStripBorrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgClases[0, dgClases.CurrentRow.Index].Value.ToString());
            if (id == 1)
            {
                MessageBox.Show("No se puede borrar está clase", "Warning", MessageBoxButtons.OK);
                ClearField();
                EstablecerEstado(false);
                return;
            }

            if (MessageBox.Show("Seguro que desea borrar está clase??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.BorrarClases(id);
                EstablecerEstado(false);
                this.clasesTableAdapter.Fill(this.dsClases.Clases);
                ClearField();
            }
        }

        private void BtAddCliente_Click(object sender, EventArgs e)
        {
            frmCliente form = new frmCliente();
            form.ShowDialog();
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
