namespace CF_BOX_1
{
    using Common.Cache;
    using System;
    using System.Windows.Forms;

    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea salir de la aplicación?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la seción?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }  
        }

        private void BtMaterial_Click(object sender, EventArgs e)
        {
            frmMaterial form = new frmMaterial();
            form.ShowDialog();
        }

        private void BtPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal form = new frmPersonal();
            form.ShowDialog();
        }

        private void BtClase_Click(object sender, EventArgs e)
        {
            frmClases form = new frmClases();
            form.ShowDialog();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            LoadUserData();

        }

        private void LoadUserData()
        {
            lblUser.Text = userCache.loginName;
            lblID.Text = userCache.userID;
            lbIDRegistro.Text = Convert.ToString(userCache.userID) ;
        }
    }
}
