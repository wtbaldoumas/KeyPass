using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoObjects;

namespace KeyPassUserInterface
{
    public partial class KeyListControl : UserControl
    {
        public KeyListControl()
        {
            InitializeComponent();
            Application.Idle += OnIdle;
            DoubleBuffered = true;
        }

        public void OnIdle(object sender, EventArgs e)
        {
            if (_listViewKeys.SelectedItems.Count != 1)
            {
                _listViewKeysEditButton.Enabled = false;
                _keyListContextMenuEdit.Enabled = false;
            }
            else
            {
                _listViewKeysEditButton.Enabled = true;
                _keyListContextMenuEdit.Enabled = true;
            }
            if (_listViewKeys.SelectedItems.Count < 1)
            {
                _listViewKeysDeleteButton.Enabled = false;
                _keyListContextMenuDelete.Enabled = false;
                _keyListContextMenuDuplicate.Enabled = false;
            }
            else
            {
                ControlLinker.SelectedKey = (Key)_listViewKeys.SelectedItems[0].Tag;
                _listViewKeysDeleteButton.Enabled = true;
                _keyListContextMenuDelete.Enabled = true;
                _keyListContextMenuDuplicate.Enabled = true;
            }
        }

        public void Initialize()
        {
            _listViewKeys.Columns.Add("Title");
            _listViewKeys.Columns.Add("Username");
            _listViewKeys.Columns.Add("Password");
            _listViewKeys.Columns.Add("URL");
            _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // takes care of populating and updating the ListView control
        public void UpdateKeys()
        {
            if (KeyPassManager.GetAllGroups().Count < 1)
            {
                _listViewKeys.BeginUpdate();
                _listViewKeys.Items.Clear();
                _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                _listViewKeys.EndUpdate();
            }
            else if (ControlLinker.SelectedGroup != ControlLinker.PreviousGroup)
            {
                Group selectedGroup = ControlLinker.SelectedGroup;
                ControlLinker.PreviousGroup = ControlLinker.SelectedGroup;
                _listViewKeys.BeginUpdate();
                _listViewKeys.Items.Clear();

                foreach (Key key in selectedGroup.Keys)
                {
                    string _passwordMask = string.Empty;
                    for(int i = 0; i < key.Password.Length; ++i)
                    {
                        _passwordMask += "●";
                    }
                    ListViewItem _item = _listViewKeys.Items.Add(key.Title);
                    _item.SubItems.Add(key.Username);
                    _item.SubItems.Add(_passwordMask);
                    _item.SubItems.Add(key.Url);
                    _item.Tag = key;
                }
                if (selectedGroup.Keys.Count > 0)
                {
                    _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                else
                {
                    _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                _listViewKeys.EndUpdate();
            }
        }
   
        private void OnSelectionChange(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (_listViewKeys.SelectedItems.Count == 0)
            {
                ControlLinker.UpdateKeyInfo = true;
            }
        }

        public int GetSelectedItemCount()
        {
            return _listViewKeys.SelectedItems.Count;
        }

        public string GetSelectedKeyInfo()
        {
            string _info = string.Empty;
            Key _selectedKey = (Key)_listViewKeys.SelectedItems[0].Tag;
            _info += ("Title: " + _selectedKey.Title + "\n");
            _info += ("Username: " + _selectedKey.Username + "\n");
            _info += ("Password: " + _selectedKey.Password + "\n");
            _info += ("URL: " + _selectedKey.Url + "\n");
            _info += "Notes:\n----------------------------------------------------------\n";
            _info += _selectedKey.Notes;
            return _info;
        }

        public void OnKeyNewClick(object sender, EventArgs e)
        {
            if (ControlLinker.SelectedGroup == null)
            {
                MessageBox.Show(this, "Please select a group.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlLinker.UpdateSuccess = false;
                return;
            }

            List<Group> groups = KeyPassManager.GetAllGroups();
            KeyForm keyForm = new KeyForm(ControlLinker.SelectedGroup, null);

            keyForm.SetGroups(groups);

            if (keyForm.ShowDialog() != DialogResult.OK)
            {
                ControlLinker.UpdateSuccess = false;
                return;
            }

            Key key = keyForm.Key;

            KeyPassManager.AddKeyToGroup(keyForm.SelectedGroup, key);
            ControlLinker.IsModified = true;
            ControlLinker.UpdateSuccess = true;
            ControlLinker.AddAuditFlow(": Key " + key.Title + " added to group " + keyForm.SelectedGroup.Name);
            ControlLinker.AuditCount = 1;

            if (keyForm.SelectedGroup == ControlLinker.SelectedGroup)
            {
                string _passwordMask = string.Empty;
                for (int i = 0; i < key.Password.Length; ++i)
                {
                    _passwordMask += "●";
                }

                ListViewItem _item = _listViewKeys.Items.Add(key.Title);
                _item.SubItems.Add(key.Username);
                _item.SubItems.Add(_passwordMask);
                _item.SubItems.Add(key.Url);
                _item.Tag = key;

                _listViewKeys.BeginUpdate();
                _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                _listViewKeys.EndUpdate();
            }
        }

        public void OnKeyEditClick(object sender, EventArgs e)
        {
            if (ControlLinker.SelectedGroup == null)
            {
                MessageBox.Show("Please select a group.");
                ControlLinker.UpdateSuccess = false;
                return;
            }
            if (_listViewKeys.SelectedItems == null)
            {
                MessageBox.Show("Please select a key.");
                ControlLinker.UpdateSuccess = false;
                return;
            }

            List<Group> groups = KeyPassManager.GetAllGroups();
            Key editKey = (Key)_listViewKeys.SelectedItems[0].Tag;
            KeyForm keyForm = new KeyForm(ControlLinker.SelectedGroup, editKey);

            keyForm.SetGroups(groups);

            if (keyForm.ShowDialog() != DialogResult.OK)
            {
                ControlLinker.UpdateSuccess = false;
                return;
            }

            editKey.Title = keyForm.Key.Title;
            editKey.Username = keyForm.Key.Username;
            editKey.Password = keyForm.Key.Password;
            editKey.Url = keyForm.Key.Url;
            editKey.Notes = keyForm.Key.Notes;

            ControlLinker.IsModified = true;
            ControlLinker.UpdateKeyInfo = true;
            ControlLinker.UpdateSuccess = true;
            ControlLinker.AddAuditFlow(": Key " + editKey.Title + " edited in group " + keyForm.SelectedGroup.Name);
            ControlLinker.AuditCount = 1;

            if (keyForm.SelectedGroup != keyForm.EntryGroup)
            {
                KeyPassManager.AddKeyToGroup(keyForm.SelectedGroup, editKey);
                KeyPassManager.RemoveKeyFromGroup(keyForm.EntryGroup, editKey);
                ListViewItem deleteItem = _listViewKeys.SelectedItems[0];

                _listViewKeys.BeginUpdate();
                deleteItem.Remove();
                _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                _listViewKeys.EndUpdate();
            }
            else
            {
                string passwordMask = string.Empty;
                for (int i = 0; i < editKey.Password.Length; ++i)
                {
                    passwordMask += "●";
                }

                _listViewKeys.SelectedItems[0].Text = editKey.Title;
                _listViewKeys.SelectedItems[0].SubItems[1].Text = editKey.Username;
                _listViewKeys.SelectedItems[0].SubItems[2].Text = passwordMask;
                _listViewKeys.SelectedItems[0].SubItems[3].Text = editKey.Url;
                _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        public void OnKeyDeleteClick(object sender, EventArgs e)
        {
            if (ControlLinker.SelectedGroup != null)
            {
                Group deleteGroup = ControlLinker.SelectedGroup;

                foreach (ListViewItem item in _listViewKeys.SelectedItems)
                {
                    Key deleteKey = (Key)_listViewKeys.SelectedItems[0].Tag;
                    KeyPassManager.RemoveKeyFromGroup(deleteGroup, deleteKey);
                    ControlLinker.IsModified = true;
                    ControlLinker.AddAuditFlow(": Key " + deleteKey.Title + " deleted from group " + deleteGroup.Name);
                    ControlLinker.AuditCount += 1;
                    
                    ListViewItem deleteItem = _listViewKeys.SelectedItems[0];
                    _listViewKeys.BeginUpdate();
                    deleteItem.Remove();
                    _listViewKeys.EndUpdate();
                }

                ControlLinker.UpdateSuccess = true;

                if (deleteGroup.Keys.Count > 0)
                {
                    _listViewKeys.BeginUpdate();
                    _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    _listViewKeys.EndUpdate();
                }
                else
                {
                    _listViewKeys.BeginUpdate();
                    _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    _listViewKeys.EndUpdate();
                }
            }
        }

        private void OnDeleteKeyDown(object sender, KeyEventArgs e)
        {
            if (ControlLinker.SelectedGroup != null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    OnKeyDeleteClick(sender, e);
                }
            }
        }

        public void OnNewClick()
        {
            _listViewKeys.Clear();
            _listViewKeys.Columns.Add("Title");
            _listViewKeys.Columns.Add("Username");
            _listViewKeys.Columns.Add("Password");
            _listViewKeys.Columns.Add("URL");
            _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void OnDuplicateKey()
        {
            if (_listViewKeys.SelectedItems.Count > 0)
            {
                Group addGroup = ControlLinker.SelectedGroup;
                string passwordMask = string.Empty;

                foreach (ListViewItem item in _listViewKeys.SelectedItems)
                {
                    Key tempKey = (Key)item.Tag;
                    Key addKey = new Key();

                    addKey.Title = tempKey.Title;
                    addKey.Username = tempKey.Username;
                    addKey.Password = tempKey.Password;
                    addKey.Url = tempKey.Url;
                    addKey.Notes = tempKey.Notes;

                    KeyPassManager.AddKeyToGroup(addGroup, addKey);
                    ControlLinker.AddAuditFlow(": Key " + addKey.Title + " added to group " + addGroup.Name);
                    ControlLinker.AuditCount += 1;

                    passwordMask = string.Empty;
                    for (int i = 0; i < addKey.Password.Length; ++i)
                    {
                        passwordMask += "●";
                    }

                    ListViewItem addItem = _listViewKeys.Items.Add(addKey.Title);
                    addItem.SubItems.Add(addKey.Username);
                    addItem.SubItems.Add(passwordMask);
                    addItem.SubItems.Add(addKey.Url);
                    addItem.Tag = addKey;
                }

                ControlLinker.IsModified = true;
                ControlLinker.UpdateSuccess = true;

                if (addGroup.Keys.Count > 0)
                {
                    _listViewKeys.BeginUpdate();
                    _listViewKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    _listViewKeys.EndUpdate();
                }
            }
        }

        private void OnKeyDuplicateClick(object sender, EventArgs e)
        {
            OnDuplicateKey();
        }

        private void OnFindClick(object sender, EventArgs e)
        {
            if (_listViewKeys.Items.Count < 1 || string.IsNullOrWhiteSpace(_listViewKeysComboBox.Text))
            {
                return;
            }

            for(int i = 0; i < _listViewKeys.Items.Count; ++i)
            {
                foreach(ListViewItem.ListViewSubItem item in _listViewKeys.Items[i].SubItems)
                {
                    if(item.Text.Contains(_listViewKeysComboBox.Text))
                    {
                        _listViewKeys.Items[i].Selected = true;
                    }
                }
            }

            _listViewKeys.Focus();
        }

        private void OnDropDown(object sender, EventArgs e)
        {
            if (_listViewKeys.Items.Count < 1)
            {
                return;
            }

            _listViewKeysComboBox.Items.Clear();
            _listViewKeysComboBox.Items.Add(_listViewKeysComboBox.Text);
            _listViewKeysComboBox.SelectedIndex = 0;

            for (int i = 0; i < _listViewKeys.Items.Count; ++i)
            {
                foreach (ListViewItem.ListViewSubItem item in _listViewKeys.Items[i].SubItems)
                {
                    if (item.Text.Contains(_listViewKeysComboBox.Text))
                    {
                        _listViewKeysComboBox.Items.Add(item.Text);
                    }
                }
            }
        }
    }
}
