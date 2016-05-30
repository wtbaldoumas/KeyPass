using KeyPassBusiness;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(_passwordTextBox.Text) || string.IsNullOrWhiteSpace(_usernameTextBox.Text))
            {
                MessageBox.Show(this, "Please fill in empty fields.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            byte[] loginBytes = System.Text.Encoding.UTF8.GetBytes(_passwordTextBox.Text + _usernameTextBox.Text);
            using (SHA1 sha = new SHA1CryptoServiceProvider())
            {
                Authenticator.CryptoBytes = sha.ComputeHash(loginBytes);
            }

            DialogResult = DialogResult.OK;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OnShowPasswordChecked(object sender, EventArgs e)
        {
            if(_passwordCheckBox.Checked)
            {
                _passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                _passwordTextBox.PasswordChar = '●';
            }
        }
    }
}
