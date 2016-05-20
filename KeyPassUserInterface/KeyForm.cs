using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeyPassUserInterface
{
    public partial class KeyForm : Form
    {
        private Key _key = null;
        private Group _selectedGroup = null;
        private Group _entryGroup = null;
        private List<Group> _groups = null;

        public KeyForm(Group selectedGroup, Key editKey)
        {
            InitializeComponent();
            _key = editKey;
            _selectedGroup = selectedGroup;
            _entryGroup = _selectedGroup;
        }

        public Group SelectedGroup
        {
            get { return _selectedGroup; }
            set { _selectedGroup = value; }
        }

        public Group EntryGroup
        {
            get { return _entryGroup; }
            set { _entryGroup = value; }
        }

        public Key Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public void SetGroups(List<Group> groups)
        {
            _groups = groups;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            for (int i = 0; i < _groups.Count(); ++i)
            {
                _keyComboBox.Items.Add(_groups[i]);
            }

            _keyComboBox.SelectedItem = _selectedGroup;

            if (_key != null)
            {
                _keyTitleTextBox.Text = _key.Title;
                _keyUsernameTextBox.Text = _key.Username;
                _keyPasswordTextBox.Text = _key.Password;
                _keyConfirmPasswordTextBox.Text = _key.Password;
                _keyUrlTextBox.Text = _key.Url;
                _keyNotesTextBox.Text = _key.Notes;
            }
            else
            {
                _key = new Key();
            }
        }

        private void OnOkClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_keyTitleTextBox.Text))
                MessageBox.Show(this, "Please enter a title.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(_keyUsernameTextBox.Text))
                MessageBox.Show(this, "Please enter a username.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(_keyPasswordTextBox.Text))
                MessageBox.Show(this, "Please enter a password.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(_keyConfirmPasswordTextBox.Text))
                MessageBox.Show(this, "Please confirm your password.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (_keyPasswordTextBox.Text != _keyConfirmPasswordTextBox.Text)
                MessageBox.Show(this, "Passwords do not match.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                _key.Title = _keyTitleTextBox.Text;
                _key.Username = _keyUsernameTextBox.Text;
                _key.Password = _keyPasswordTextBox.Text;
                _key.Url = _keyUrlTextBox.Text;
                _key.Notes = _keyNotesTextBox.Text;
                _selectedGroup = ((Group)_keyComboBox.SelectedItem);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void OnTestClick(object sender, EventArgs e)
        {
            string _title;
            string _username;
            string _password;
            string _url;
            string _notes;

            TestInputGenerator.GetTestKeyFields(out _title, out _username, out _password, out _url, out _notes);

            _keyTitleTextBox.Text = _title;
            _keyUsernameTextBox.Text = _username;
            _keyPasswordTextBox.Text = _password;
            _keyConfirmPasswordTextBox.Text = _password;
            _keyUrlTextBox.Text = _url;
            _keyNotesTextBox.Text = _notes;
        }
    }
}
