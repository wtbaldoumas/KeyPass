using System;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class _AboutForm : Form
    {
        public _AboutForm()
        {
            InitializeComponent();
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
