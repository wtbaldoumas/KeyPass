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
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(_passwordTextBox.Text);
            SHA1 sha = new SHA1CryptoServiceProvider();
            Authenticator.PasswordBytes = sha.ComputeHash(bytes);

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
