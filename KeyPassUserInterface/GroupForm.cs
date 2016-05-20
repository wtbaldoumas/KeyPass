using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class GroupForm : Form
    {
        private Group _group = null;

        public GroupForm(Group editGroup)
        {
            InitializeComponent();
            _group = editGroup;
        }

        private void OnOKClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_groupFormTextBox.Text))
            {
                MessageBox.Show(this, "Please enter a group name.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _group.Name = _groupFormTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnTestClick(object sender, EventArgs e)
        {
            _groupFormTextBox.Text = TestInputGenerator.GetTestGroupTitle();
        }

        private void OnGroupFormLoad(object sender, EventArgs e)
        {
            if (_group != null)
            {
                _groupFormTextBox.Text = _group.Name;
            }
            else
            {
                _group = new Group();
            }
        }

        public Group Group
        {
            get { return _group; }
            set { _group = value; }
        }
    }
}