namespace KeyPassUserInterface
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._editGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._duplicateEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MainToolStrip = new System.Windows.Forms.ToolStrip();
            this._newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._SplitContainerVertical = new System.Windows.Forms.SplitContainer();
            this._SplitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this._keyDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this._groupImageList = new System.Windows.Forms.ImageList(this.components);
            this._groupTreeControl = new KeyPassUserInterface.GroupTreeControl();
            this._listViewKeys = new KeyPassUserInterface.KeyListControl();
            this._mainFormStatusStrip = new KeyPassUserInterface._StatusStripControl();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainFormMenuStrip.SuspendLayout();
            this._MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SplitContainerVertical)).BeginInit();
            this._SplitContainerVertical.Panel1.SuspendLayout();
            this._SplitContainerVertical.Panel2.SuspendLayout();
            this._SplitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._SplitContainerHorizontal)).BeginInit();
            this._SplitContainerHorizontal.Panel1.SuspendLayout();
            this._SplitContainerHorizontal.Panel2.SuspendLayout();
            this._SplitContainerHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainFormMenuStrip
            // 
            this._mainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this._mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._editToolStripMenuItem,
            this._viewToolStripMenuItem,
            this._toolsToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainFormMenuStrip.Name = "_mainFormMenuStrip";
            this._mainFormMenuStrip.Size = new System.Drawing.Size(884, 24);
            this._mainFormMenuStrip.TabIndex = 0;
            this._mainFormMenuStrip.Text = "MainMenuStrip";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this._saveToolStripMenuItem,
            this._saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this._printToolStripMenuItem,
            this._printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileToolStripMenuItem.Text = "&File";
            this._fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnFileMenuOpening);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // _saveToolStripMenuItem
            // 
            this._saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_saveToolStripMenuItem.Image")));
            this._saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveToolStripMenuItem.Name = "_saveToolStripMenuItem";
            this._saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this._saveToolStripMenuItem.Text = "&Save";
            this._saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _saveAsToolStripMenuItem
            // 
            this._saveAsToolStripMenuItem.Name = "_saveAsToolStripMenuItem";
            this._saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this._saveAsToolStripMenuItem.Text = "Save &As...";
            this._saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // _printToolStripMenuItem
            // 
            this._printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_printToolStripMenuItem.Image")));
            this._printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._printToolStripMenuItem.Name = "_printToolStripMenuItem";
            this._printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this._printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this._printToolStripMenuItem.Text = "&Print...";
            this._printToolStripMenuItem.Click += new System.EventHandler(this.Print);
            // 
            // _printPreviewToolStripMenuItem
            // 
            this._printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_printPreviewToolStripMenuItem.Image")));
            this._printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._printPreviewToolStripMenuItem.Name = "_printPreviewToolStripMenuItem";
            this._printPreviewToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this._printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this._printPreviewToolStripMenuItem.Click += new System.EventHandler(this.OnPrintPreviewClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
            // 
            // _editToolStripMenuItem
            // 
            this._editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem,
            this.toolStripSeparator3,
            this._editGroupToolStripMenuItem,
            this._deleteGroupToolStripMenuItem,
            this.toolStripSeparator4,
            this._addEntryToolStripMenuItem,
            this._editEntryToolStripMenuItem,
            this._deleteEntryToolStripMenuItem,
            this._duplicateEntryToolStripMenuItem,
            this.toolStripSeparator6,
            this._findToolStripMenuItem});
            this._editToolStripMenuItem.Name = "_editToolStripMenuItem";
            this._editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this._editToolStripMenuItem.Text = "&Edit";
            this._editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OnEditMenuOpening);
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addGroupToolStripMenuItem.Image")));
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addGroupToolStripMenuItem.Text = "Add Group...";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.OnGroupNewClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // _editGroupToolStripMenuItem
            // 
            this._editGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_editGroupToolStripMenuItem.Image")));
            this._editGroupToolStripMenuItem.Name = "_editGroupToolStripMenuItem";
            this._editGroupToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._editGroupToolStripMenuItem.Text = "Edit Group...";
            this._editGroupToolStripMenuItem.Click += new System.EventHandler(this.OnGroupEditClick);
            // 
            // _deleteGroupToolStripMenuItem
            // 
            this._deleteGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_deleteGroupToolStripMenuItem.Image")));
            this._deleteGroupToolStripMenuItem.Name = "_deleteGroupToolStripMenuItem";
            this._deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._deleteGroupToolStripMenuItem.Text = "Delete Group...";
            this._deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.OnGroupDeleteClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // _addEntryToolStripMenuItem
            // 
            this._addEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_addEntryToolStripMenuItem.Image")));
            this._addEntryToolStripMenuItem.Name = "_addEntryToolStripMenuItem";
            this._addEntryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._addEntryToolStripMenuItem.Text = "Add Entry...";
            this._addEntryToolStripMenuItem.Click += new System.EventHandler(this.OnKeyNewClick);
            // 
            // _editEntryToolStripMenuItem
            // 
            this._editEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_editEntryToolStripMenuItem.Image")));
            this._editEntryToolStripMenuItem.Name = "_editEntryToolStripMenuItem";
            this._editEntryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._editEntryToolStripMenuItem.Text = "Edit Entry...";
            this._editEntryToolStripMenuItem.Click += new System.EventHandler(this.OnKeyEditClick);
            // 
            // _deleteEntryToolStripMenuItem
            // 
            this._deleteEntryToolStripMenuItem.Image = global::KeyPassUserInterface.Properties.Resources.Delete;
            this._deleteEntryToolStripMenuItem.Name = "_deleteEntryToolStripMenuItem";
            this._deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._deleteEntryToolStripMenuItem.Text = "Delete Entry...";
            this._deleteEntryToolStripMenuItem.Click += new System.EventHandler(this.OnKeyDeleteClick);
            // 
            // _duplicateEntryToolStripMenuItem
            // 
            this._duplicateEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_duplicateEntryToolStripMenuItem.Image")));
            this._duplicateEntryToolStripMenuItem.Name = "_duplicateEntryToolStripMenuItem";
            this._duplicateEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._duplicateEntryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._duplicateEntryToolStripMenuItem.Text = "Duplicate Entry";
            this._duplicateEntryToolStripMenuItem.Click += new System.EventHandler(this.OnKeyDuplicateClick);
            // 
            // _viewToolStripMenuItem
            // 
            this._viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this._viewToolStripMenuItem.Name = "_viewToolStripMenuItem";
            this._viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this._viewToolStripMenuItem.Text = "View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolBarToolStripMenuItem.Text = "Tool Bar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.OnToolBarViewClick);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.OnStatusBarViewClick);
            // 
            // _toolsToolStripMenuItem
            // 
            this._toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this._toolsToolStripMenuItem.Name = "_toolsToolStripMenuItem";
            this._toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this._toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customizeToolStripMenuItem.Image")));
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.customizeToolStripMenuItem.Text = "&Customize...";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this._helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contentsToolStripMenuItem.Image")));
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // _MainToolStrip
            // 
            this._MainToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this._MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newToolStripButton,
            this._openToolStripButton,
            this._saveToolStripButton,
            this._printToolStripButton,
            this._toolStripSeparator1,
            this._aboutToolStripButton,
            this._toolStripSeparator2});
            this._MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this._MainToolStrip.Name = "_MainToolStrip";
            this._MainToolStrip.Size = new System.Drawing.Size(884, 25);
            this._MainToolStrip.TabIndex = 1;
            this._MainToolStrip.Text = "toolStrip1";
            // 
            // _newToolStripButton
            // 
            this._newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_newToolStripButton.Image")));
            this._newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newToolStripButton.Name = "_newToolStripButton";
            this._newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._newToolStripButton.Text = "&New";
            this._newToolStripButton.Click += new System.EventHandler(this.OnNewClick);
            // 
            // _openToolStripButton
            // 
            this._openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_openToolStripButton.Image")));
            this._openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._openToolStripButton.Name = "_openToolStripButton";
            this._openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._openToolStripButton.Text = "&Open";
            this._openToolStripButton.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // _saveToolStripButton
            // 
            this._saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_saveToolStripButton.Image")));
            this._saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveToolStripButton.Name = "_saveToolStripButton";
            this._saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._saveToolStripButton.Text = "&Save";
            this._saveToolStripButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _printToolStripButton
            // 
            this._printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_printToolStripButton.Image")));
            this._printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._printToolStripButton.Name = "_printToolStripButton";
            this._printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._printToolStripButton.Text = "&Print";
            this._printToolStripButton.Click += new System.EventHandler(this.Print);
            // 
            // _toolStripSeparator1
            // 
            this._toolStripSeparator1.Name = "_toolStripSeparator1";
            this._toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _aboutToolStripButton
            // 
            this._aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_aboutToolStripButton.Image")));
            this._aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._aboutToolStripButton.Name = "_aboutToolStripButton";
            this._aboutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._aboutToolStripButton.Text = "About";
            this._aboutToolStripButton.Click += new System.EventHandler(this.OnAboutClick);
            // 
            // _toolStripSeparator2
            // 
            this._toolStripSeparator2.Name = "_toolStripSeparator2";
            this._toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _SplitContainerVertical
            // 
            this._SplitContainerVertical.BackColor = System.Drawing.SystemColors.Control;
            this._SplitContainerVertical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._SplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SplitContainerVertical.Location = new System.Drawing.Point(0, 49);
            this._SplitContainerVertical.Name = "_SplitContainerVertical";
            // 
            // _SplitContainerVertical.Panel1
            // 
            this._SplitContainerVertical.Panel1.Controls.Add(this._groupTreeControl);
            // 
            // _SplitContainerVertical.Panel2
            // 
            this._SplitContainerVertical.Panel2.Controls.Add(this._SplitContainerHorizontal);
            this._SplitContainerVertical.Size = new System.Drawing.Size(884, 483);
            this._SplitContainerVertical.SplitterDistance = 294;
            this._SplitContainerVertical.SplitterWidth = 5;
            this._SplitContainerVertical.TabIndex = 3;
            // 
            // _SplitContainerHorizontal
            // 
            this._SplitContainerHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._SplitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SplitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this._SplitContainerHorizontal.Name = "_SplitContainerHorizontal";
            this._SplitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _SplitContainerHorizontal.Panel1
            // 
            this._SplitContainerHorizontal.Panel1.Controls.Add(this._listViewKeys);
            // 
            // _SplitContainerHorizontal.Panel2
            // 
            this._SplitContainerHorizontal.Panel2.Controls.Add(this._keyDetailsRichTextBox);
            this._SplitContainerHorizontal.Size = new System.Drawing.Size(585, 483);
            this._SplitContainerHorizontal.SplitterDistance = 307;
            this._SplitContainerHorizontal.SplitterWidth = 5;
            this._SplitContainerHorizontal.TabIndex = 0;
            // 
            // _keyDetailsRichTextBox
            // 
            this._keyDetailsRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this._keyDetailsRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._keyDetailsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keyDetailsRichTextBox.Location = new System.Drawing.Point(0, 0);
            this._keyDetailsRichTextBox.Name = "_keyDetailsRichTextBox";
            this._keyDetailsRichTextBox.ReadOnly = true;
            this._keyDetailsRichTextBox.Size = new System.Drawing.Size(581, 167);
            this._keyDetailsRichTextBox.TabIndex = 0;
            this._keyDetailsRichTextBox.Text = "";
            // 
            // _groupImageList
            // 
            this._groupImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_groupImageList.ImageStream")));
            this._groupImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._groupImageList.Images.SetKeyName(0, "Lock.ico");
            // 
            // _groupTreeControl
            // 
            this._groupTreeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupTreeControl.Location = new System.Drawing.Point(0, 0);
            this._groupTreeControl.Name = "_groupTreeControl";
            this._groupTreeControl.Size = new System.Drawing.Size(290, 479);
            this._groupTreeControl.TabIndex = 0;
            // 
            // _listViewKeys
            // 
            this._listViewKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listViewKeys.Location = new System.Drawing.Point(0, 0);
            this._listViewKeys.Name = "_listViewKeys";
            this._listViewKeys.Size = new System.Drawing.Size(581, 303);
            this._listViewKeys.TabIndex = 4;
            // 
            // _mainFormStatusStrip
            // 
            this._mainFormStatusStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._mainFormStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._mainFormStatusStrip.Location = new System.Drawing.Point(0, 532);
            this._mainFormStatusStrip.Name = "_mainFormStatusStrip";
            this._mainFormStatusStrip.Size = new System.Drawing.Size(884, 30);
            this._mainFormStatusStrip.TabIndex = 2;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(193, 6);
            // 
            // _findToolStripMenuItem
            // 
            this._findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_findToolStripMenuItem.Image")));
            this._findToolStripMenuItem.Name = "_findToolStripMenuItem";
            this._findToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this._findToolStripMenuItem.Text = "Find...";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this._SplitContainerVertical);
            this.Controls.Add(this._mainFormStatusStrip);
            this.Controls.Add(this._MainToolStrip);
            this.Controls.Add(this._mainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFileDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFileDragEnter);
            this._mainFormMenuStrip.ResumeLayout(false);
            this._mainFormMenuStrip.PerformLayout();
            this._MainToolStrip.ResumeLayout(false);
            this._MainToolStrip.PerformLayout();
            this._SplitContainerVertical.Panel1.ResumeLayout(false);
            this._SplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._SplitContainerVertical)).EndInit();
            this._SplitContainerVertical.ResumeLayout(false);
            this._SplitContainerHorizontal.Panel1.ResumeLayout(false);
            this._SplitContainerHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._SplitContainerHorizontal)).EndInit();
            this._SplitContainerHorizontal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem _saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem _editGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem _addEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _editEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _duplicateEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip _MainToolStrip;
        private System.Windows.Forms.ToolStripButton _newToolStripButton;
        private System.Windows.Forms.ToolStripButton _openToolStripButton;
        private System.Windows.Forms.ToolStripButton _saveToolStripButton;
        private System.Windows.Forms.ToolStripButton _printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _aboutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator _toolStripSeparator2;
        private _StatusStripControl _mainFormStatusStrip;
        private System.Windows.Forms.SplitContainer _SplitContainerVertical;
        private System.Windows.Forms.SplitContainer _SplitContainerHorizontal;
        private System.Windows.Forms.ImageList _groupImageList;
        private GroupTreeControl _groupTreeControl;
        private KeyListControl _listViewKeys;
        private System.Windows.Forms.RichTextBox _keyDetailsRichTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem _findToolStripMenuItem;
    }
}