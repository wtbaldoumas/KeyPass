using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class _StatusStripControl : UserControl
    {
        public _StatusStripControl()
        {
            InitializeComponent();
        }

        public void UpdateGroupCount()
        {
            List<Group> groups = KeyPassManager.GetAllGroups();
            _TotalGroupsLabel.Text = "Groups: " + groups.Count.ToString();
        }

        public void UpdateSelectedKeys(int x, int y)
        {
            if (x > 1 || x == 0)
            {
                _SelectedKeysLabel.Text = x.ToString() + " selected keys of " + y.ToString();
            }
            else
            {
                _SelectedKeysLabel.Text = x.ToString() + " selected key of " + y.ToString();
            }
        }

        public void UpdateAuditFlow(string auditFlow)
        {
            string updateText = DateTime.Now.ToString() + auditFlow;
            _StatusStripComboBox.Items.Add(updateText);
            _StatusStripComboBox.SelectedItem = updateText;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _TotalGroupsLabel.Text = "Groups: 0";
        }
    }
}
