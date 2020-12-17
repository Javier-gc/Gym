namespace CF_BOX_1
{
    using Common.Cache;
    using Domain;
    using System;
    using System.Windows.Forms;
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                if (txtPassword.Text != String.Empty)
                {
                    UsuarioModel user = new UsuarioModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);

                    if (validLogin == true)
                    {
                        frmRegistro form = new frmRegistro();
                        MessageBox.Show("Bienvenido " + userCache.loginName + " " + userCache.userID);
                        form.ShowDialog();
                        //Codigo cuando se cierra el formulario principal
                        //form.FormClosed += Logout;
                        //this.Hide();
                        txtPassword.Text = String.Empty;
                        txtUser.Text = String.Empty;
                        txtUser.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                        txtPassword.Text = String.Empty;
                        txtUser.Text = String.Empty;
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Introduce la contraseña");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introduce todos los datos");
                txtUser.Focus();
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = String.Empty;
            txtUser.Text = String.Empty;
            txtUser.Focus();
            this.Show();
        }
    }
}
