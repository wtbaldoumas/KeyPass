namespace KeyPassUserInterface
{
    using KeyPassBusiness;
    using KeyPassUserInterface.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class MainForm : Form
    {
        private GroupTreeControl _groupTreeControl;
        private KeyListControl _keyListControl;
        private ToolStripMenuItem _mnuEdit;
        private ToolStripMenuItem _mnuEditFind;
        private ToolStripMenuItem _mnuEditGroupAdd;
        private ToolStripMenuItem _mnuEditGroupDelete;
        private ToolStripMenuItem _mnuEditGroupEdit;
        private ToolStripMenuItem _mnuEntryAdd;
        private ToolStripMenuItem _mnuEntryDelete;
        private ToolStripMenuItem _mnuEntryDuplicate;
        private ToolStripMenuItem _mnuEntryEdit;
        private ToolStripMenuItem _mnuFile;
        private ToolStripMenuItem _mnuFileExit;
        private ToolStripMenuItem _mnuFileNew;
        private ToolStripMenuItem _mnuFileOpen;
        private ToolStripMenuItem _mnuFilePrint;
        private ToolStripMenuItem _mnuFilePrintPreview;
        private ToolStripMenuItem _MnuFileSave;
        private ToolStripMenuItem _mnuFileSaveAs;
        private ToolStripMenuItem _mnuHelp;
        private ToolStripMenuItem _mnuHelpAbout;
        private ToolStripMenuItem _mnuHelpContents;
        private MenuStrip _mnuStrip;
        private ToolStripMenuItem _mnuTools;
        private ToolStripMenuItem _mnuToolsCustomize;
        private ToolStripMenuItem _mnuToolsOptions;
        private ToolStripMenuItem _mnuView;
        private ToolStripMenuItem _mnuViewStatusBar;
        private ToolStripMenuItem _mnuViewToolBar;
        private ToolStripSeparator _sep1;
        private ToolStripSeparator _sep2;
        private ToolStripSeparator _sep3;
        private ToolStripSeparator _sepEdit1;
        private ToolStripSeparator _sepEdit2;
        private ToolStripSeparator _sepHelp1;
        private SplitContainer _spcMain;
        private StatusStripControl _statusStripControl;
        private ToolStripButton _tsbHelpAbout;
        private ToolStripButton _tsbNew;
        private ToolStripButton _tsbOpen;
        private ToolStripButton _tsbPrint;
        private ToolStripButton _tsbSave;
        private ToolStrip _tspMain;
        private IContainer components = null;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;

        public MainForm()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components > null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(MainForm));
            this._mnuStrip = new MenuStrip();
            this._mnuFile = new ToolStripMenuItem();
            this._mnuFileNew = new ToolStripMenuItem();
            this._mnuFileOpen = new ToolStripMenuItem();
            this._sep1 = new ToolStripSeparator();
            this._MnuFileSave = new ToolStripMenuItem();
            this._mnuFileSaveAs = new ToolStripMenuItem();
            this._sep2 = new ToolStripSeparator();
            this._mnuFilePrint = new ToolStripMenuItem();
            this._mnuFilePrintPreview = new ToolStripMenuItem();
            this._sep3 = new ToolStripSeparator();
            this._mnuFileExit = new ToolStripMenuItem();
            this._mnuEdit = new ToolStripMenuItem();
            this._mnuEditGroupAdd = new ToolStripMenuItem();
            this._sepEdit1 = new ToolStripSeparator();
            this._mnuEditGroupEdit = new ToolStripMenuItem();
            this._mnuEditGroupDelete = new ToolStripMenuItem();
            this._sepEdit2 = new ToolStripSeparator();
            this._mnuEntryAdd = new ToolStripMenuItem();
            this._mnuEntryEdit = new ToolStripMenuItem();
            this._mnuEntryDelete = new ToolStripMenuItem();
            this._mnuEntryDuplicate = new ToolStripMenuItem();
            this.toolStripMenuItem1 = new ToolStripSeparator();
            this._mnuEditFind = new ToolStripMenuItem();
            this._mnuView = new ToolStripMenuItem();
            this._mnuViewToolBar = new ToolStripMenuItem();
            this._mnuViewStatusBar = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripSeparator();
            this._mnuTools = new ToolStripMenuItem();
            this._mnuToolsCustomize = new ToolStripMenuItem();
            this._mnuToolsOptions = new ToolStripMenuItem();
            this._mnuHelp = new ToolStripMenuItem();
            this._mnuHelpContents = new ToolStripMenuItem();
            this._sepHelp1 = new ToolStripSeparator();
            this._mnuHelpAbout = new ToolStripMenuItem();
            this._tspMain = new ToolStrip();
            this._tsbNew = new ToolStripButton();
            this._tsbOpen = new ToolStripButton();
            this._tsbSave = new ToolStripButton();
            this._tsbPrint = new ToolStripButton();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this._tsbHelpAbout = new ToolStripButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this._statusStripControl = new StatusStripControl();
            this._groupTreeControl = new GroupTreeControl();
            this._spcMain = new SplitContainer();
            this._keyListControl = new KeyListControl();
            this._mnuStrip.SuspendLayout();
            this._tspMain.SuspendLayout();
            this._spcMain.BeginInit();
            this._spcMain.Panel1.SuspendLayout();
            this._spcMain.Panel2.SuspendLayout();
            this._spcMain.SuspendLayout();
            base.SuspendLayout();
            this._mnuStrip.BackColor = SystemColors.GradientInactiveCaption;
            this._mnuStrip.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this._mnuFile, this._mnuEdit, this._mnuView, this._mnuTools, this._mnuHelp };
            this._mnuStrip.Items.AddRange(toolStripItems);
            this._mnuStrip.Location = new Point(0, 0);
            this._mnuStrip.Name = "_mnuStrip";
            this._mnuStrip.Padding = new Padding(7, 2, 0, 2);
            this._mnuStrip.Size = new Size(0x47d, 0x19);
            this._mnuStrip.TabIndex = 0;
            this._mnuStrip.Text = "menuStrip1";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this._mnuFileNew, this._mnuFileOpen, this._sep1, this._MnuFileSave, this._mnuFileSaveAs, this._sep2, this._mnuFilePrint, this._mnuFilePrintPreview, this._sep3, this._mnuFileExit };
            this._mnuFile.DropDownItems.AddRange(itemArray2);
            this._mnuFile.Name = "_mnuFile";
            this._mnuFile.Size = new Size(40, 0x15);
            this._mnuFile.Text = "&File";
            this._mnuFileNew.Image = (Image) manager.GetObject("_mnuFileNew.Image");
            this._mnuFileNew.ImageTransparentColor = Color.Magenta;
            this._mnuFileNew.Name = "_mnuFileNew";
            this._mnuFileNew.Size = new Size(0x9c, 0x16);
            this._mnuFileNew.Text = "&New";
            this._mnuFileNew.Click += new EventHandler(this.OnFileNew);
            this._mnuFileOpen.Image = Resources.Open;
            this._mnuFileOpen.ImageTransparentColor = Color.Magenta;
            this._mnuFileOpen.Name = "_mnuFileOpen";
            this._mnuFileOpen.Size = new Size(0x9c, 0x16);
            this._mnuFileOpen.Text = "&Open...";
            this._mnuFileOpen.Click += new EventHandler(this.OnFileOpen);
            this._sep1.Name = "_sep1";
            this._sep1.Size = new Size(0x99, 6);
            this._MnuFileSave.Image = (Image) manager.GetObject("_MnuFileSave.Image");
            this._MnuFileSave.ImageTransparentColor = Color.Magenta;
            this._MnuFileSave.Name = "_MnuFileSave";
            this._MnuFileSave.Size = new Size(0x9c, 0x16);
            this._MnuFileSave.Text = "&Save";
            this._MnuFileSave.Click += new EventHandler(this.OnFileSave);
            this._mnuFileSaveAs.Name = "_mnuFileSaveAs";
            this._mnuFileSaveAs.Size = new Size(0x9c, 0x16);
            this._mnuFileSaveAs.Text = "Save &As...";
            this._mnuFileSaveAs.Click += new EventHandler(this.OnFileSaveAs);
            this._sep2.Name = "_sep2";
            this._sep2.Size = new Size(0x99, 6);
            this._mnuFilePrint.Image = (Image) manager.GetObject("_mnuFilePrint.Image");
            this._mnuFilePrint.ImageTransparentColor = Color.Magenta;
            this._mnuFilePrint.Name = "_mnuFilePrint";
            this._mnuFilePrint.Size = new Size(0x9c, 0x16);
            this._mnuFilePrint.Text = "&Print...";
            this._mnuFilePrint.Click += new EventHandler(this.OnFilePrint);
            this._mnuFilePrintPreview.Image = (Image) manager.GetObject("_mnuFilePrintPreview.Image");
            this._mnuFilePrintPreview.ImageTransparentColor = Color.Magenta;
            this._mnuFilePrintPreview.Name = "_mnuFilePrintPreview";
            this._mnuFilePrintPreview.Size = new Size(0x9c, 0x16);
            this._mnuFilePrintPreview.Text = "Print Pre&view";
            this._mnuFilePrintPreview.Click += new EventHandler(this.OnFilePrintPreview);
            this._sep3.Name = "_sep3";
            this._sep3.Size = new Size(0x99, 6);
            this._mnuFileExit.Name = "_mnuFileExit";
            this._mnuFileExit.Size = new Size(0x9c, 0x16);
            this._mnuFileExit.Text = "E&xit";
            this._mnuFileExit.Click += new EventHandler(this.OnFileExit);
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this._mnuEditGroupAdd, this._sepEdit1, this._mnuEditGroupEdit, this._mnuEditGroupDelete, this._sepEdit2, this._mnuEntryAdd, this._mnuEntryEdit, this._mnuEntryDelete, this._mnuEntryDuplicate, this.toolStripMenuItem1, this._mnuEditFind };
            this._mnuEdit.DropDownItems.AddRange(itemArray3);
            this._mnuEdit.Name = "_mnuEdit";
            this._mnuEdit.Size = new Size(0x2b, 0x15);
            this._mnuEdit.Text = "&Edit";
            this._mnuEdit.DropDownOpening += new EventHandler(this.OnEditMenuOpening);
            this._mnuEditGroupAdd.Image = Resources.Folder;
            this._mnuEditGroupAdd.Name = "_mnuEditGroupAdd";
            this._mnuEditGroupAdd.Size = new Size(0xb1, 0x16);
            this._mnuEditGroupAdd.Text = "Add Group...";
            this._mnuEditGroupAdd.Click += new EventHandler(this.OnAddGroup);
            this._sepEdit1.Name = "_sepEdit1";
            this._sepEdit1.Size = new Size(0xae, 6);
            this._mnuEditGroupEdit.Name = "_mnuEditGroupEdit";
            this._mnuEditGroupEdit.Size = new Size(0xb1, 0x16);
            this._mnuEditGroupEdit.Text = "Edit Group...";
            this._mnuEditGroupEdit.Click += new EventHandler(this.OnEditGroup);
            this._mnuEditGroupDelete.Image = Resources.TrashFull;
            this._mnuEditGroupDelete.ImageTransparentColor = Color.Magenta;
            this._mnuEditGroupDelete.Name = "_mnuEditGroupDelete";
            this._mnuEditGroupDelete.Size = new Size(0xb1, 0x16);
            this._mnuEditGroupDelete.Text = "Delete Group...";
            this._mnuEditGroupDelete.Click += new EventHandler(this.OnDeleteGroup);
            this._sepEdit2.Name = "_sepEdit2";
            this._sepEdit2.Size = new Size(0xae, 6);
            this._mnuEntryAdd.Image = Resources.Entry;
            this._mnuEntryAdd.Name = "_mnuEntryAdd";
            this._mnuEntryAdd.Size = new Size(0xb1, 0x16);
            this._mnuEntryAdd.Text = "Add Entry...";
            this._mnuEntryAdd.Click += new EventHandler(this.OnAddEntry);
            this._mnuEntryEdit.Image = Resources.Edit;
            this._mnuEntryEdit.Name = "_mnuEntryEdit";
            this._mnuEntryEdit.Size = new Size(0xb1, 0x16);
            this._mnuEntryEdit.Text = "Edit Entry...";
            this._mnuEntryEdit.Click += new EventHandler(this.OnEditEntry);
            this._mnuEntryDelete.Image = Resources.Delete;
            this._mnuEntryDelete.Name = "_mnuEntryDelete";
            this._mnuEntryDelete.Size = new Size(0xb1, 0x16);
            this._mnuEntryDelete.Text = "Delete Entry...";
            this._mnuEntryDelete.Click += new EventHandler(this.OnDeleteEntry);
            this._mnuEntryDuplicate.Image = Resources.DuplicateKey;
            this._mnuEntryDuplicate.Name = "_mnuEntryDuplicate";
            this._mnuEntryDuplicate.Size = new Size(0xb1, 0x16);
            this._mnuEntryDuplicate.Text = "Duplicate Entry...";
            this._mnuEntryDuplicate.Click += new EventHandler(this.OnDuplicateEntry);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(0xae, 6);
            this._mnuEditFind.Image = Resources.Find;
            this._mnuEditFind.Name = "_mnuEditFind";
            this._mnuEditFind.Size = new Size(0xb1, 0x16);
            this._mnuEditFind.Text = "Find...";
            this._mnuEditFind.Click += new EventHandler(this.OnFindEntry);
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this._mnuViewToolBar, this._mnuViewStatusBar, this.toolStripMenuItem2 };
            this._mnuView.DropDownItems.AddRange(itemArray4);
            this._mnuView.Name = "_mnuView";
            this._mnuView.Size = new Size(0x30, 0x15);
            this._mnuView.Text = "&View";
            this._mnuViewToolBar.Checked = true;
            this._mnuViewToolBar.CheckState = CheckState.Checked;
            this._mnuViewToolBar.Name = "_mnuViewToolBar";
            this._mnuViewToolBar.Size = new Size(0x8a, 0x16);
            this._mnuViewToolBar.Text = "Tool Bar";
            this._mnuViewToolBar.Click += new EventHandler(this.OnViewToolBar);
            this._mnuViewStatusBar.Checked = true;
            this._mnuViewStatusBar.CheckState = CheckState.Checked;
            this._mnuViewStatusBar.Name = "_mnuViewStatusBar";
            this._mnuViewStatusBar.Size = new Size(0x8a, 0x16);
            this._mnuViewStatusBar.Text = "Status Bar";
            this._mnuViewStatusBar.Click += new EventHandler(this.OnViewStatusBar);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(0x87, 6);
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this._mnuToolsCustomize, this._mnuToolsOptions };
            this._mnuTools.DropDownItems.AddRange(itemArray5);
            this._mnuTools.Name = "_mnuTools";
            this._mnuTools.Size = new Size(0x34, 0x15);
            this._mnuTools.Text = "&Tools";
            this._mnuToolsCustomize.Name = "_mnuToolsCustomize";
            this._mnuToolsCustomize.Size = new Size(0x94, 0x16);
            this._mnuToolsCustomize.Text = "&Customize...";
            this._mnuToolsCustomize.Click += new EventHandler(this.OnCustomize);
            this._mnuToolsOptions.Image = Resources.Options;
            this._mnuToolsOptions.Name = "_mnuToolsOptions";
            this._mnuToolsOptions.Size = new Size(0x94, 0x16);
            this._mnuToolsOptions.Text = "&Options...";
            this._mnuToolsOptions.Click += new EventHandler(this.OnOptions);
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this._mnuHelpContents, this._sepHelp1, this._mnuHelpAbout };
            this._mnuHelp.DropDownItems.AddRange(itemArray6);
            this._mnuHelp.Name = "_mnuHelp";
            this._mnuHelp.Size = new Size(0x30, 0x15);
            this._mnuHelp.Text = "&Help";
            this._mnuHelpContents.Image = Resources.Info;
            this._mnuHelpContents.Name = "_mnuHelpContents";
            this._mnuHelpContents.Size = new Size(0x83, 0x16);
            this._mnuHelpContents.Text = "&Contents";
            this._mnuHelpContents.Click += new EventHandler(this.OnHelpContents);
            this._sepHelp1.Name = "_sepHelp1";
            this._sepHelp1.Size = new Size(0x80, 6);
            this._mnuHelpAbout.Image = Resources.Help;
            this._mnuHelpAbout.Name = "_mnuHelpAbout";
            this._mnuHelpAbout.Size = new Size(0x83, 0x16);
            this._mnuHelpAbout.Text = "&About...";
            this._mnuHelpAbout.Click += new EventHandler(this.OnHelpAbout);
            this._tspMain.BackColor = SystemColors.GradientInactiveCaption;
            this._tspMain.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this._tspMain.ImageScalingSize = new Size(0x20, 0x20);
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this._tsbNew, this._tsbOpen, this._tsbSave, this._tsbPrint, this.toolStripSeparator3, this._tsbHelpAbout, this.toolStripSeparator2 };
            this._tspMain.Items.AddRange(itemArray7);
            this._tspMain.Location = new Point(0, 0x19);
            this._tspMain.Name = "_tspMain";
            this._tspMain.Size = new Size(0x47d, 0x27);
            this._tspMain.TabIndex = 1;
            this._tspMain.Text = "toolStrip1";
            this._tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this._tsbNew.Image = (Image) manager.GetObject("_tsbNew.Image");
            this._tsbNew.ImageTransparentColor = Color.Magenta;
            this._tsbNew.Name = "_tsbNew";
            this._tsbNew.Size = new Size(0x24, 0x24);
            this._tsbNew.Text = "&New";
            this._tsbNew.Click += new EventHandler(this.OnFileNew);
            this._tsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this._tsbOpen.Image = Resources.Open;
            this._tsbOpen.ImageTransparentColor = Color.Magenta;
            this._tsbOpen.Name = "_tsbOpen";
            this._tsbOpen.Size = new Size(0x24, 0x24);
            this._tsbOpen.Text = "&Open";
            this._tsbOpen.Click += new EventHandler(this.OnFileOpen);
            this._tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this._tsbSave.Image = (Image) manager.GetObject("_tsbSave.Image");
            this._tsbSave.ImageTransparentColor = Color.Magenta;
            this._tsbSave.Name = "_tsbSave";
            this._tsbSave.Size = new Size(0x24, 0x24);
            this._tsbSave.Text = "&Save";
            this._tsbSave.Click += new EventHandler(this.OnFileSave);
            this._tsbPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this._tsbPrint.Image = (Image) manager.GetObject("_tsbPrint.Image");
            this._tsbPrint.ImageTransparentColor = Color.Magenta;
            this._tsbPrint.Name = "_tsbPrint";
            this._tsbPrint.Size = new Size(0x24, 0x24);
            this._tsbPrint.Text = "&Print";
            this._tsbPrint.Click += new EventHandler(this.OnFilePrint);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(6, 0x27);
            this._tsbHelpAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this._tsbHelpAbout.Image = (Image) manager.GetObject("_tsbHelpAbout.Image");
            this._tsbHelpAbout.ImageTransparentColor = Color.Magenta;
            this._tsbHelpAbout.Name = "_tsbHelpAbout";
            this._tsbHelpAbout.Size = new Size(0x24, 0x24);
            this._tsbHelpAbout.Text = "He&lp";
            this._tsbHelpAbout.Click += new EventHandler(this.OnHelpAbout);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(6, 0x27);
            this._statusStripControl.Dock = DockStyle.Bottom;
            this._statusStripControl.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this._statusStripControl.Location = new Point(0, 0x27f);
            this._statusStripControl.Margin = new Padding(4);
            this._statusStripControl.Name = "_statusStripControl";
            this._statusStripControl.Size = new Size(0x47d, 0x20);
            this._statusStripControl.TabIndex = 3;
            this._groupTreeControl.Dock = DockStyle.Fill;
            this._groupTreeControl.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._groupTreeControl.Location = new Point(0, 0);
            this._groupTreeControl.Margin = new Padding(3, 4, 3, 4);
            this._groupTreeControl.Name = "_groupTreeControl";
            this._groupTreeControl.Size = new Size(0x123, 0x23b);
            this._groupTreeControl.TabIndex = 0;
            this._spcMain.BorderStyle = BorderStyle.Fixed3D;
            this._spcMain.Dock = DockStyle.Fill;
            this._spcMain.Location = new Point(0, 0x40);
            this._spcMain.Name = "_spcMain";
            this._spcMain.Panel1.Controls.Add(this._groupTreeControl);
            this._spcMain.Panel2.Controls.Add(this._keyListControl);
            this._spcMain.Size = new Size(0x47d, 0x23f);
            this._spcMain.SplitterDistance = 0x127;
            this._spcMain.SplitterWidth = 5;
            this._spcMain.TabIndex = 7;
            this._keyListControl.Dock = DockStyle.Fill;
            this._keyListControl.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this._keyListControl.Location = new Point(0, 0);
            this._keyListControl.Margin = new Padding(3, 4, 3, 4);
            this._keyListControl.Name = "_keyListControl";
            this._keyListControl.Size = new Size(0x34d, 0x23b);
            this._keyListControl.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(8f, 17f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x47d, 0x29f);
            base.Controls.Add(this._spcMain);
            base.Controls.Add(this._statusStripControl);
            base.Controls.Add(this._tspMain);
            base.Controls.Add(this._mnuStrip);
            this.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MainMenuStrip = this._mnuStrip;
            base.Margin = new Padding(2, 3, 2, 3);
            base.Name = "MainForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "My Key Pass";
            base.Load += new EventHandler(this.OnLoad);
            this._mnuStrip.ResumeLayout(false);
            this._mnuStrip.PerformLayout();
            this._tspMain.ResumeLayout(false);
            this._tspMain.PerformLayout();
            this._spcMain.Panel1.ResumeLayout(false);
            this._spcMain.Panel2.ResumeLayout(false);
            this._spcMain.EndInit();
            this._spcMain.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void OnAddEntry(object sender, EventArgs e)
        {
            this._keyListControl.OnKeyAdd(sender, e);
        }

        private void OnAddGroup(object sender, EventArgs e)
        {
            this._groupTreeControl.OnGroupAdd(sender, e);
        }

        private void OnCustomize(object sender, EventArgs e)
        {
        }

        private void OnDeleteEntry(object sender, EventArgs e)
        {
            this._keyListControl.OnKeyDelete(sender, e);
        }

        private void OnDeleteGroup(object sender, EventArgs e)
        {
            this._groupTreeControl.OnGroupDelete(sender, e);
        }

        private void OnDuplicateEntry(object sender, EventArgs e)
        {
        }

        private void OnEditEntry(object sender, EventArgs e)
        {
            this._keyListControl.OnKeyEdit(sender, e);
        }

        private void OnEditGroup(object sender, EventArgs e)
        {
            this._groupTreeControl.OnGroupEdit(sender, e);
        }

        private void OnEditMenuOpening(object sender, EventArgs e)
        {
            bool flag = ContextMgr.SelectedGroup > null;
            this._mnuEditGroupDelete.Enabled = flag;
            this._mnuEditGroupEdit.Enabled = flag;
            this._mnuEntryAdd.Enabled = ContextMgr.SelectedGroup > null;
            this._mnuEntryEdit.Enabled = ContextMgr.SelectedKeys.Count == 1;
            this._mnuEntryDelete.Enabled = ContextMgr.SelectedKeys.Count > 0;
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            base.Close();
        }

        private void OnFileNew(object sender, EventArgs e)
        {
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
        }

        private void OnFilePrint(object sender, EventArgs e)
        {
        }

        private void OnFilePrintPreview(object sender, EventArgs e)
        {
        }

        private void OnFileSave(object sender, EventArgs e)
        {
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
        }

        private void OnFindEntry(object sender, EventArgs e)
        {
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog(this);
        }

        private void OnHelpContents(object sender, EventArgs e)
        {
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (!base.DesignMode)
            {
            }
        }

        private void OnOptions(object sender, EventArgs e)
        {
        }

        private void OnViewStatusBar(object sender, EventArgs e)
        {
            this._statusStripControl.Visible = !this._statusStripControl.Visible;
            this._mnuViewStatusBar.Checked = !this._mnuViewStatusBar.Checked;
        }

        private void OnViewToolBar(object sender, EventArgs e)
        {
            this._tspMain.Visible = !this._tspMain.Visible;
            this._mnuViewToolBar.Checked = !this._mnuViewToolBar.Checked;
        }
    }
}

