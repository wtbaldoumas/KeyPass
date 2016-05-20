namespace KeyPassUserInterface
{
    partial class KeyListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyListControl));
            this._listViewKeysToolStrip = new System.Windows.Forms.ToolStrip();
            this._listViewKeysAddKeyButton = new System.Windows.Forms.ToolStripButton();
            this._listViewKeysEditButton = new System.Windows.Forms.ToolStripButton();
            this._listViewKeysDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this._listViewKeysFindButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this._listViewKeys = new System.Windows.Forms.ListView();
            this._keyListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._keyListContextMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._keyListContextMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._keyListContextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this._keyListContextMenuDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this._listViewKeysComboBox = new System.Windows.Forms.ComboBox();
            this._listViewKeysToolStrip.SuspendLayout();
            this._keyListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _listViewKeysToolStrip
            // 
            this._listViewKeysToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this._listViewKeysToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._listViewKeysAddKeyButton,
            this._listViewKeysEditButton,
            this._listViewKeysDeleteButton,
            this.toolStripSeparator10,
            this._listViewKeysFindButton,
            this.toolStripSeparator11});
            this._listViewKeysToolStrip.Location = new System.Drawing.Point(0, 0);
            this._listViewKeysToolStrip.Name = "_listViewKeysToolStrip";
            this._listViewKeysToolStrip.Size = new System.Drawing.Size(364, 25);
            this._listViewKeysToolStrip.TabIndex = 3;
            this._listViewKeysToolStrip.Text = "toolStrip1";
            // 
            // _listViewKeysAddKeyButton
            // 
            this._listViewKeysAddKeyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._listViewKeysAddKeyButton.Image = ((System.Drawing.Image)(resources.GetObject("_listViewKeysAddKeyButton.Image")));
            this._listViewKeysAddKeyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._listViewKeysAddKeyButton.Name = "_listViewKeysAddKeyButton";
            this._listViewKeysAddKeyButton.Size = new System.Drawing.Size(23, 22);
            this._listViewKeysAddKeyButton.Text = "&Add Key";
            this._listViewKeysAddKeyButton.Click += new System.EventHandler(this.OnKeyNewClick);
            // 
            // _listViewKeysEditButton
            // 
            this._listViewKeysEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._listViewKeysEditButton.Image = ((System.Drawing.Image)(resources.GetObject("_listViewKeysEditButton.Image")));
            this._listViewKeysEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._listViewKeysEditButton.Name = "_listViewKeysEditButton";
            this._listViewKeysEditButton.Size = new System.Drawing.Size(23, 22);
            this._listViewKeysEditButton.Text = "&Edit Key";
            this._listViewKeysEditButton.Click += new System.EventHandler(this.OnKeyEditClick);
            // 
            // _listViewKeysDeleteButton
            // 
            this._listViewKeysDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._listViewKeysDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("_listViewKeysDeleteButton.Image")));
            this._listViewKeysDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._listViewKeysDeleteButton.Name = "_listViewKeysDeleteButton";
            this._listViewKeysDeleteButton.Size = new System.Drawing.Size(23, 22);
            this._listViewKeysDeleteButton.Text = "&Delete Key";
            this._listViewKeysDeleteButton.Click += new System.EventHandler(this.OnKeyDeleteClick);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // _listViewKeysFindButton
            // 
            this._listViewKeysFindButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._listViewKeysFindButton.Image = ((System.Drawing.Image)(resources.GetObject("_listViewKeysFindButton.Image")));
            this._listViewKeysFindButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._listViewKeysFindButton.Name = "_listViewKeysFindButton";
            this._listViewKeysFindButton.Size = new System.Drawing.Size(23, 22);
            this._listViewKeysFindButton.Text = "Find";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // _listViewKeys
            // 
            this._listViewKeys.ContextMenuStrip = this._keyListContextMenu;
            this._listViewKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listViewKeys.FullRowSelect = true;
            this._listViewKeys.GridLines = true;
            this._listViewKeys.HideSelection = false;
            this._listViewKeys.Location = new System.Drawing.Point(0, 25);
            this._listViewKeys.Name = "_listViewKeys";
            this._listViewKeys.Size = new System.Drawing.Size(364, 170);
            this._listViewKeys.TabIndex = 5;
            this._listViewKeys.UseCompatibleStateImageBehavior = false;
            this._listViewKeys.View = System.Windows.Forms.View.Details;
            this._listViewKeys.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnSelectionChange);
            this._listViewKeys.DoubleClick += new System.EventHandler(this.OnKeyEditClick);
            this._listViewKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDeleteKeyDown);
            // 
            // _keyListContextMenu
            // 
            this._keyListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._keyListContextMenuAdd,
            this._keyListContextMenuEdit,
            this._keyListContextMenuDelete,
            this._keyListContextMenuDuplicate});
            this._keyListContextMenu.Name = "_keyListContextMenu";
            this._keyListContextMenu.Size = new System.Drawing.Size(189, 92);
            // 
            // _keyListContextMenuAdd
            // 
            this._keyListContextMenuAdd.Image = ((System.Drawing.Image)(resources.GetObject("_keyListContextMenuAdd.Image")));
            this._keyListContextMenuAdd.Name = "_keyListContextMenuAdd";
            this._keyListContextMenuAdd.Size = new System.Drawing.Size(188, 22);
            this._keyListContextMenuAdd.Text = "Add Key...";
            this._keyListContextMenuAdd.Click += new System.EventHandler(this.OnKeyNewClick);
            // 
            // _keyListContextMenuEdit
            // 
            this._keyListContextMenuEdit.Image = ((System.Drawing.Image)(resources.GetObject("_keyListContextMenuEdit.Image")));
            this._keyListContextMenuEdit.Name = "_keyListContextMenuEdit";
            this._keyListContextMenuEdit.Size = new System.Drawing.Size(188, 22);
            this._keyListContextMenuEdit.Text = "Edit Key...";
            this._keyListContextMenuEdit.Click += new System.EventHandler(this.OnKeyEditClick);
            // 
            // _keyListContextMenuDelete
            // 
            this._keyListContextMenuDelete.Image = ((System.Drawing.Image)(resources.GetObject("_keyListContextMenuDelete.Image")));
            this._keyListContextMenuDelete.Name = "_keyListContextMenuDelete";
            this._keyListContextMenuDelete.Size = new System.Drawing.Size(188, 22);
            this._keyListContextMenuDelete.Text = "Delete Key";
            this._keyListContextMenuDelete.Click += new System.EventHandler(this.OnKeyDeleteClick);
            // 
            // _keyListContextMenuDuplicate
            // 
            this._keyListContextMenuDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("_keyListContextMenuDuplicate.Image")));
            this._keyListContextMenuDuplicate.Name = "_keyListContextMenuDuplicate";
            this._keyListContextMenuDuplicate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._keyListContextMenuDuplicate.Size = new System.Drawing.Size(188, 22);
            this._keyListContextMenuDuplicate.Text = "Duplicate Key";
            this._keyListContextMenuDuplicate.Click += new System.EventHandler(this.OnKeyDuplicateClick);
            // 
            // _listViewKeysComboBox
            // 
            this._listViewKeysComboBox.FormattingEnabled = true;
            this._listViewKeysComboBox.Location = new System.Drawing.Point(115, 2);
            this._listViewKeysComboBox.Name = "_listViewKeysComboBox";
            this._listViewKeysComboBox.Size = new System.Drawing.Size(121, 21);
            this._listViewKeysComboBox.TabIndex = 6;
            // 
            // KeyListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._listViewKeysComboBox);
            this.Controls.Add(this._listViewKeys);
            this.Controls.Add(this._listViewKeysToolStrip);
            this.Name = "KeyListControl";
            this.Size = new System.Drawing.Size(364, 195);
            this._listViewKeysToolStrip.ResumeLayout(false);
            this._listViewKeysToolStrip.PerformLayout();
            this._keyListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _listViewKeysToolStrip;
        private System.Windows.Forms.ToolStripButton _listViewKeysAddKeyButton;
        private System.Windows.Forms.ToolStripButton _listViewKeysEditButton;
        private System.Windows.Forms.ToolStripButton _listViewKeysDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton _listViewKeysFindButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ListView _listViewKeys;
        private System.Windows.Forms.ComboBox _listViewKeysComboBox;
        private System.Windows.Forms.ContextMenuStrip _keyListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem _keyListContextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem _keyListContextMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem _keyListContextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem _keyListContextMenuDuplicate;
    }
}
