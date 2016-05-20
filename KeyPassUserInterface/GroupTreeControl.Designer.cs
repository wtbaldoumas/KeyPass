namespace KeyPassUserInterface
{
    partial class GroupTreeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTreeControl));
            this._tvwToolStrip = new System.Windows.Forms.ToolStrip();
            this._treeViewNewButton = new System.Windows.Forms.ToolStripButton();
            this._treeViewEditButton = new System.Windows.Forms.ToolStripButton();
            this._treeViewDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this._treeViewGroups = new System.Windows.Forms.TreeView();
            this._GroupTreeControlImageList = new System.Windows.Forms.ImageList(this.components);
            this._groupTreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._contextMenuGroupNew = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuGroupEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._contextMenuGroupCopy = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuGroupPaste = new System.Windows.Forms.ToolStripMenuItem();
            this._tvwToolStrip.SuspendLayout();
            this._groupTreeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tvwToolStrip
            // 
            this._tvwToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._tvwToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this._tvwToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._treeViewNewButton,
            this._treeViewEditButton,
            this._treeViewDeleteButton,
            this.toolStripSeparator9});
            this._tvwToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this._tvwToolStrip.Location = new System.Drawing.Point(0, 0);
            this._tvwToolStrip.Name = "_tvwToolStrip";
            this._tvwToolStrip.Size = new System.Drawing.Size(24, 299);
            this._tvwToolStrip.TabIndex = 3;
            this._tvwToolStrip.Text = "toolStrip1";
            // 
            // _treeViewNewButton
            // 
            this._treeViewNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._treeViewNewButton.Image = ((System.Drawing.Image)(resources.GetObject("_treeViewNewButton.Image")));
            this._treeViewNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._treeViewNewButton.Name = "_treeViewNewButton";
            this._treeViewNewButton.Size = new System.Drawing.Size(21, 20);
            this._treeViewNewButton.Text = "&Add Group";
            this._treeViewNewButton.Click += new System.EventHandler(this.OnGroupNewClick);
            // 
            // _treeViewEditButton
            // 
            this._treeViewEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._treeViewEditButton.Image = ((System.Drawing.Image)(resources.GetObject("_treeViewEditButton.Image")));
            this._treeViewEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._treeViewEditButton.Name = "_treeViewEditButton";
            this._treeViewEditButton.Size = new System.Drawing.Size(21, 20);
            this._treeViewEditButton.Text = "&Edit Group";
            this._treeViewEditButton.Click += new System.EventHandler(this.OnGroupEditClick);
            // 
            // _treeViewDeleteButton
            // 
            this._treeViewDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._treeViewDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("_treeViewDeleteButton.Image")));
            this._treeViewDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._treeViewDeleteButton.Name = "_treeViewDeleteButton";
            this._treeViewDeleteButton.Size = new System.Drawing.Size(21, 20);
            this._treeViewDeleteButton.Text = "&Delete Group";
            this._treeViewDeleteButton.Click += new System.EventHandler(this.OnGroupDeleteClick);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(21, 6);
            // 
            // _treeViewGroups
            // 
            this._treeViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeViewGroups.HideSelection = false;
            this._treeViewGroups.ImageIndex = 0;
            this._treeViewGroups.ImageList = this._GroupTreeControlImageList;
            this._treeViewGroups.Location = new System.Drawing.Point(24, 0);
            this._treeViewGroups.Name = "_treeViewGroups";
            this._treeViewGroups.SelectedImageIndex = 0;
            this._treeViewGroups.Size = new System.Drawing.Size(216, 299);
            this._treeViewGroups.TabIndex = 4;
            this._treeViewGroups.DoubleClick += new System.EventHandler(this.OnGroupEditClick);
            this._treeViewGroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDeleteKeyDown);
            // 
            // _GroupTreeControlImageList
            // 
            this._GroupTreeControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_GroupTreeControlImageList.ImageStream")));
            this._GroupTreeControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._GroupTreeControlImageList.Images.SetKeyName(0, "Lock.ico");
            // 
            // _groupTreeContextMenu
            // 
            this._groupTreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._contextMenuGroupNew,
            this._contextMenuGroupEdit,
            this._contextMenuGroupDelete,
            this.toolStripSeparator1,
            this._contextMenuGroupCopy,
            this._contextMenuGroupPaste});
            this._groupTreeContextMenu.Name = "_groupTreeContextMenu";
            this._groupTreeContextMenu.Size = new System.Drawing.Size(153, 120);
            // 
            // _contextMenuGroupNew
            // 
            this._contextMenuGroupNew.Image = ((System.Drawing.Image)(resources.GetObject("_contextMenuGroupNew.Image")));
            this._contextMenuGroupNew.Name = "_contextMenuGroupNew";
            this._contextMenuGroupNew.Size = new System.Drawing.Size(152, 22);
            this._contextMenuGroupNew.Text = "Add Group...";
            this._contextMenuGroupNew.Click += new System.EventHandler(this.OnGroupNewClick);
            // 
            // _contextMenuGroupEdit
            // 
            this._contextMenuGroupEdit.Image = ((System.Drawing.Image)(resources.GetObject("_contextMenuGroupEdit.Image")));
            this._contextMenuGroupEdit.Name = "_contextMenuGroupEdit";
            this._contextMenuGroupEdit.Size = new System.Drawing.Size(152, 22);
            this._contextMenuGroupEdit.Text = "Edit Group...";
            this._contextMenuGroupEdit.Click += new System.EventHandler(this.OnGroupEditClick);
            // 
            // _contextMenuGroupDelete
            // 
            this._contextMenuGroupDelete.Image = global::KeyPassUserInterface.Properties.Resources.Delete;
            this._contextMenuGroupDelete.Name = "_contextMenuGroupDelete";
            this._contextMenuGroupDelete.Size = new System.Drawing.Size(152, 22);
            this._contextMenuGroupDelete.Text = "Delete Group...";
            this._contextMenuGroupDelete.Click += new System.EventHandler(this.OnGroupDeleteClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // _contextMenuGroupCopy
            // 
            this._contextMenuGroupCopy.Image = ((System.Drawing.Image)(resources.GetObject("_contextMenuGroupCopy.Image")));
            this._contextMenuGroupCopy.Name = "_contextMenuGroupCopy";
            this._contextMenuGroupCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this._contextMenuGroupCopy.Size = new System.Drawing.Size(152, 22);
            this._contextMenuGroupCopy.Text = "Copy";
            this._contextMenuGroupCopy.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // _contextMenuGroupPaste
            // 
            this._contextMenuGroupPaste.Image = ((System.Drawing.Image)(resources.GetObject("_contextMenuGroupPaste.Image")));
            this._contextMenuGroupPaste.Name = "_contextMenuGroupPaste";
            this._contextMenuGroupPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this._contextMenuGroupPaste.Size = new System.Drawing.Size(152, 22);
            this._contextMenuGroupPaste.Text = "Paste";
            this._contextMenuGroupPaste.Click += new System.EventHandler(this.OnPasteClick);
            // 
            // GroupTreeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this._groupTreeContextMenu;
            this.Controls.Add(this._treeViewGroups);
            this.Controls.Add(this._tvwToolStrip);
            this.Name = "GroupTreeControl";
            this.Size = new System.Drawing.Size(240, 299);
            this._tvwToolStrip.ResumeLayout(false);
            this._tvwToolStrip.PerformLayout();
            this._groupTreeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _tvwToolStrip;
        private System.Windows.Forms.ToolStripButton _treeViewNewButton;
        private System.Windows.Forms.ToolStripButton _treeViewEditButton;
        private System.Windows.Forms.ToolStripButton _treeViewDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.TreeView _treeViewGroups;
        private System.Windows.Forms.ImageList _GroupTreeControlImageList;
        private System.Windows.Forms.ContextMenuStrip _groupTreeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _contextMenuGroupNew;
        private System.Windows.Forms.ToolStripMenuItem _contextMenuGroupEdit;
        private System.Windows.Forms.ToolStripMenuItem _contextMenuGroupDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _contextMenuGroupCopy;
        private System.Windows.Forms.ToolStripMenuItem _contextMenuGroupPaste;
    }
}
