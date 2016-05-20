using System;
using System.Windows.Forms;
using KeyPassInfoObjects;
using KeyPassBusiness;
using System.Runtime.InteropServices;

namespace KeyPassUserInterface
{
    public partial class GroupTreeControl : UserControl
    {
        [DllImport("user32.dll")]
        static extern uint RegisterClipboardFormat(string format);

        [DllImport("user32.dll")]
        static extern bool IsClipboardFormatAvailable(uint format);

        private readonly uint dataCookie;
        const string DATA_FORMAT = "Group";

        public TreeNode _selectedNode => _treeViewGroups.SelectedNode;

        public TreeNode GetSelectedNode
        {
            get { return _selectedNode; }
        }

        public GroupTreeControl()
        {
            InitializeComponent();
            Application.Idle += OnIdle;
            dataCookie = RegisterClipboardFormat(DATA_FORMAT);
            DoubleBuffered = true;
        }

        private void OnIdle(object sender, EventArgs e)
        {
            if (_treeViewGroups.SelectedNode == null)
            {
                _treeViewDeleteButton.Enabled = false;
                _treeViewEditButton.Enabled = false;
                _contextMenuGroupEdit.Enabled = false;
                _contextMenuGroupDelete.Enabled = false;
                _contextMenuGroupCopy.Enabled = false;
            }
            else
            {
                ControlLinker.SelectedGroup = (Group)_treeViewGroups.SelectedNode.Tag;
                _treeViewDeleteButton.Enabled = true;
                _treeViewEditButton.Enabled = true;
                _contextMenuGroupEdit.Enabled = true;
                _contextMenuGroupDelete.Enabled = true;
                _contextMenuGroupCopy.Enabled = true;
            }
            if (!IsClipboardFormatAvailable(dataCookie))
            {
                _contextMenuGroupPaste.Enabled = false;
            }
            else
            {
                _contextMenuGroupPaste.Enabled = true;
            }
        }

        private void OnDeleteKeyDown(object sender, KeyEventArgs e)
        {
            if (ControlLinker.SelectedGroup != null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    OnGroupDeleteClick(sender, e);
                }
            }
        }

        public void OnGroupNewClick(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm(null);
            if (groupForm.ShowDialog() != DialogResult.OK)
            {
                ControlLinker.UpdateSuccess = false;
                return;
            }

            Group newGroup = groupForm.Group;
            KeyPassManager.AddGroup(newGroup);
            ControlLinker.IsModified = true;
            ControlLinker.UpdateSuccess = true;
            ControlLinker.AddAuditFlow(": Group " + newGroup.Name + " added");
            ControlLinker.AuditCount = 1;

            TreeNode _node = _treeViewGroups.Nodes.Add(newGroup.Name);
            _treeViewGroups.SelectedNode = _node;
            _node.Tag = newGroup;
        }

        public void OnGroupEditClick(object sender, EventArgs e)
        {
            if (_treeViewGroups.SelectedNode != null)
            {
                Group editGroup = (Group)_treeViewGroups.SelectedNode.Tag;

                GroupForm _groupForm = new GroupForm(editGroup);
                if (_groupForm.ShowDialog() != DialogResult.OK)
                {
                    ControlLinker.UpdateSuccess = false;
                    return;
                }

                editGroup.Name = _groupForm.Group.Name;
                ControlLinker.IsModified = true;
                ControlLinker.UpdateSuccess = true;
                ControlLinker.AddAuditFlow(": Group " + editGroup.Name + " edited");
                ControlLinker.AuditCount = 1;
                _treeViewGroups.SelectedNode.Text = editGroup.Name;
            }
        }

        public void OnGroupDeleteClick(object sender, EventArgs e)
        {
            GroupDeleteForm groupDeleteForm = new GroupDeleteForm();

            if (groupDeleteForm.ShowDialog() != DialogResult.OK)
            {
                ControlLinker.UpdateSuccess = false;
                return;
            }

            Group deleteGroup = (Group)_treeViewGroups.SelectedNode.Tag;

            KeyPassManager.RemoveGroup(deleteGroup);
            ControlLinker.IsModified = true;
            ControlLinker.UpdateSuccess = true;
            ControlLinker.AddAuditFlow(": Group " + deleteGroup.Name + " deleted");
            ControlLinker.AuditCount = 1;
            _treeViewGroups.Nodes.Remove(_treeViewGroups.SelectedNode);

            if (_treeViewGroups.Nodes.Count == 0)
            {
                ControlLinker.SelectedGroup = null;
            }
        }

        public void OnNewClick()
        {
            _treeViewGroups.Nodes.Clear();
        }

        public void OnOpen(Group loadGroup)
        {
            TreeNode node = _treeViewGroups.Nodes.Add(loadGroup.Name);
            _treeViewGroups.SelectedNode = node;
            node.Tag = loadGroup;
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            Group copyGroup = new Group();
            copyGroup = (Group)_treeViewGroups.SelectedNode.Tag;
            DataObject dataObject = new DataObject();
            dataObject.SetData("Group", copyGroup);
            Clipboard.SetDataObject(dataObject, true);
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            Group pasteGroup = new Group();
            IDataObject dataObject = Clipboard.GetDataObject();

            if (dataObject.GetDataPresent("Group"))
            {
                pasteGroup = (Group)dataObject.GetData("Group");
                KeyPassManager.AddGroup(pasteGroup);
                ControlLinker.IsModified = true;
                ControlLinker.UpdateSuccess = true;
                ControlLinker.AddAuditFlow(": Group " + pasteGroup.Name + " added");
                ControlLinker.AuditCount = 1;

                TreeNode _node = _treeViewGroups.Nodes.Add(pasteGroup.Name);
                _treeViewGroups.SelectedNode = _node;
                _node.Tag = pasteGroup;
            }
        }
    }
}
