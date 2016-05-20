using System;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class GroupDeleteForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public GroupDeleteForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = createParams.ClassStyle | CP_NOCLOSE_BUTTON;
                return createParams;
            }
        }

        private void OnNoClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnYesClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
