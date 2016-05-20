using KeyPassBusiness;
using KeyPassInfoObjects;
using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace KeyPassUserInterface
{
    public partial class MainForm : Form
    {
        private PrintDocument _printDocument = new PrintDocument();

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnToolBarViewClick(object sender, EventArgs e)
        {
            _MainToolStrip.Visible = !_MainToolStrip.Visible;
        }

        private void OnStatusBarViewClick(object sender, EventArgs e)
        {
            _mainFormStatusStrip.Visible = !_mainFormStatusStrip.Visible;
        }

        private void OnGroupNewClick(object sender, EventArgs e)
        {
            _groupTreeControl.OnGroupNewClick(sender, e);
        }

        private void OnGroupEditClick(object sender, EventArgs e)
        {
            _groupTreeControl.OnGroupEditClick(sender, e);
        }

        private void OnGroupDeleteClick(object sender, EventArgs e)
        {
            _groupTreeControl.OnGroupDeleteClick(sender, e);
        }

        private void OnKeyNewClick(object sender, EventArgs e)
        {
            _listViewKeys.OnKeyNewClick(sender, e);
        }

        private void OnKeyEditClick(object sender, EventArgs e)
        {
            _listViewKeys.OnKeyEditClick(sender, e);
        }

        private void OnKeyDeleteClick(object sender, EventArgs e)
        {
            _listViewKeys.OnKeyDeleteClick(sender, e);
        }

        private void OnKeyDuplicateClick(object sender, EventArgs e)
        {
            _listViewKeys.OnDuplicateKey();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            _listViewKeys.Initialize();
            ControlLinker.IsModified = false;
            Text = KeyPassManager.FileName;
            Application.Idle += OnIdle;
            _printDocument.PrintPage += new PrintPageEventHandler(PrintDocumentPrintPage);
        }

        private void OnIdle(object sender, EventArgs e)
        {
            _listViewKeys.UpdateKeys();

            if (ControlLinker.SelectedGroup != null)
            {
                _mainFormStatusStrip.UpdateSelectedKeys(_listViewKeys.GetSelectedItemCount(), ControlLinker.SelectedGroup.Keys.Count);
            }
            else
            {
                _mainFormStatusStrip.UpdateSelectedKeys(0, 0);
            }
            if (KeyPassManager.FileName == "KeyPass" && KeyPassManager.GetAllGroups().Count == 0)
            {
                _saveToolStripButton.Enabled = false;
            }
            else if (ControlLinker.IsModified == false)
            {
                _saveToolStripButton.Enabled = false;
            }
            else
            {
                _saveToolStripButton.Enabled = true;
            }
            if(_listViewKeys.GetSelectedItemCount() != 1)
            {
                _keyDetailsRichTextBox.Enabled = false;
                _keyDetailsRichTextBox.Text = string.Empty;
            }
            else
            {
                if (ControlLinker.UpdateKeyInfo == true && ControlLinker.SelectedKey != null)
                {
                    ControlLinker.PreviousKey = ControlLinker.SelectedKey;
                    _keyDetailsRichTextBox.Enabled = true;
                    _keyDetailsRichTextBox.Text = _listViewKeys.GetSelectedKeyInfo();
                    ControlLinker.UpdateKeyInfo = false;
                }
                else if (ControlLinker.SelectedKey != ControlLinker.PreviousKey)
                {
                    ControlLinker.PreviousKey = ControlLinker.SelectedKey;
                    _keyDetailsRichTextBox.Enabled = true;
                    _keyDetailsRichTextBox.Text = _listViewKeys.GetSelectedKeyInfo();
                }
            }
            if(ControlLinker.UpdateSuccess == true)
            {
                _mainFormStatusStrip.UpdateGroupCount();
                for (int index = 0; index < ControlLinker.AuditCount; ++index)
                {
                    _mainFormStatusStrip.UpdateAuditFlow(ControlLinker.GetAuditFlow(index));
                }
                ControlLinker.ClearAuditFlow();
                ControlLinker.AuditCount = 0;
                ControlLinker.UpdateSuccess = false;
            }
        }

        private void OnEditMenuOpening(object sender, EventArgs e)
        {
            if (_groupTreeControl.GetSelectedNode == null)
            {
                _deleteGroupToolStripMenuItem.Enabled = false;
                _editGroupToolStripMenuItem.Enabled = false;
                _addEntryToolStripMenuItem.Enabled = false;
            }
            else
            {
                _deleteGroupToolStripMenuItem.Enabled = true;
                _editGroupToolStripMenuItem.Enabled = true;
                _addEntryToolStripMenuItem.Enabled = true;
            }
            if (_listViewKeys.GetSelectedItemCount() != 1)
            {
                _editEntryToolStripMenuItem.Enabled = false;
            }
            else
            {
                _editEntryToolStripMenuItem.Enabled = true;
            }
            if (_listViewKeys.GetSelectedItemCount() < 1)
            {
                _deleteEntryToolStripMenuItem.Enabled = false;
                _duplicateEntryToolStripMenuItem.Enabled = false;
            }
            else
            {
                _deleteEntryToolStripMenuItem.Enabled = true;
                _duplicateEntryToolStripMenuItem.Enabled = true;
            }

        }
        private void OnFileMenuOpening(object sender, EventArgs e)
        {
            if (KeyPassManager.FileName == "KeyPass" && KeyPassManager.GetAllGroups().Count == 0)
            {
                _saveAsToolStripMenuItem.Enabled = false;
                _saveToolStripMenuItem.Enabled = false;
            }

            else if (ControlLinker.IsModified == false)
            {
                if (KeyPassManager.FileName == "KeyPass")
                {
                    _saveAsToolStripMenuItem.Enabled = false;

                }
                _saveToolStripMenuItem.Enabled = false;
            }
            else
            {
                _saveToolStripMenuItem.Enabled = true;
                _saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            _AboutForm about = new _AboutForm();
            about.ShowDialog(this);
        }

        private void OnExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnCloseSave(FormClosingEventArgs e)
        {
            if (KeyPassManager.FileName == "KeyPass")
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "KeyPass File (*.kpf)|*.kpf";
                if (saveDialog.ShowDialog(this) != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }

                KeyPassManager.FileName = saveDialog.FileName;
                Text = KeyPassManager.FileName;
            }

            KeyPassManager.CryptoSave();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (KeyPassManager.FileName == "KeyPass" && KeyPassManager.GetAllGroups().Count == 0)
            {
                return;
            }

            if (ControlLinker.IsModified)
            {
                DialogResult result = MessageBox.Show(this, "There are unsaved changes, do you want to save?", "KeyPass",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    OnCloseSave(e);
                }
            }
        }

        private bool Save(bool saveAs)
        {
            if (saveAs == true || KeyPassManager.FileName == "KeyPass")
            {    
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "KeyPass File (*.kpf)|*.kpf";
                if (saveDialog.ShowDialog(this) != DialogResult.OK)
                {
                    return false;
                }

                KeyPassManager.FileName = saveDialog.FileName;
                Text = KeyPassManager.FileName;
            }

            KeyPassManager.CryptoSave();
            ControlLinker.OnSaveClick();
            return true;
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            Save(false);
        }

        private void OnSaveAsClick(object sender, EventArgs e)
        {
            Save(true);
        }

        private void OnNewClick(object sender, EventArgs e)
        {
            if (!SavePrompt())
            {
                return;
            }
            else
            {
                KeyPassManager.OnNewClick();
                ControlLinker.OnNewClick();
                _groupTreeControl.OnNewClick();
                _listViewKeys.OnNewClick();
                Text = KeyPassManager.FileName;
            }
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            if (!SavePrompt())
            {
                return;
            }
            else
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "KeyPass File (*.kpf)|*.kpf";

                if (openDialog.ShowDialog(this) != DialogResult.OK)
                    return;

                if (KeyPassManager.CryptoOpen(openDialog.FileName))
                {
                    KeyPassManager.Groups = KeyPassManager.LoadGroups;
                    KeyPassManager.FileName = openDialog.FileName;
                    Text = KeyPassManager.FileName;
                    ControlLinker.OnOpenClick();

                    _groupTreeControl.OnNewClick();
                    foreach (Group loadGroup in KeyPassManager.GetAllGroups())
                    {
                        _groupTreeControl.OnOpen(loadGroup);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Error: incorrect password for this file.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SavePrompt()
        {
            if (!(KeyPassManager.FileName == "KeyPass" && KeyPassManager.GetAllGroups().Count == 0))
            {
                if (ControlLinker.IsModified)
                {
                    DialogResult result = MessageBox.Show(this, "There are unsaved changes, do you want to save?", "KeyPass",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        return Save(false);
                    }
                }
            }
            return true;
        }

        private void OnFileDragEnter(object sender, DragEventArgs e)
        {
            bool dropEnabled = false;
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] filenames = e.Data.GetData(DataFormats.FileDrop, true) as string[];

                foreach (string filename in filenames)
                {
                    if (System.IO.Path.GetExtension(filename).ToUpperInvariant() == ".KPF")
                    {
                        dropEnabled = true;
                        break;
                    }
                }
            }
            if (dropEnabled)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void OnFileDragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);

                if(!SavePrompt())
                {
                    return;
                }
                else
                {
                    if (KeyPassManager.CryptoOpen(filenames[0]))
                    {
                        KeyPassManager.FileName = filenames[0];
                        Text = KeyPassManager.FileName;
                        KeyPassManager.Groups = KeyPassManager.LoadGroups;

                        ControlLinker.OnOpenClick();
                        _groupTreeControl.OnNewClick();
                        foreach (Group loadGroup in KeyPassManager.GetAllGroups())
                        {
                            _groupTreeControl.OnOpen(loadGroup);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "You do not have access to this file.", "KeyPass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Print(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = _printDocument;

                if (printDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                _printDocument.Print();
            }
        }
        private void PrintDocumentPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.TranslateTransform(e.MarginBounds.Left, e.MarginBounds.Top);

            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                Point point = new Point(0, 0);
                Size size = new Size(((this.Width - 250) / 6), (this.Height / 20));
                Size groupBufferSize = new Size((((this.Width - 250) / 6) * 5), (this.Height / 20));

                Rectangle rectangle = new Rectangle(point, size);
                Rectangle groupBufferRectangle = new Rectangle(point, groupBufferSize);
                Rectangle keyBufferRectangle = new Rectangle(point, size);

                using (Font printFont = new Font("Courier", 9))
                {
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        using (SolidBrush shadedBrush = new SolidBrush(Color.FromArgb(255, 159, 186, 193)))
                        {
                            using (Pen pen = new Pen(Color.Black))
                            {

                                rectangle.Location = point;
                                e.Graphics.FillRectangle(shadedBrush, rectangle);
                                e.Graphics.DrawRectangle(pen, rectangle);
                                e.Graphics.DrawString("Group", printFont, brush, rectangle, stringFormat);
                                point.X += size.Width;

                                rectangle.Location = point;
                                e.Graphics.FillRectangle(shadedBrush, rectangle);
                                e.Graphics.DrawRectangle(pen, rectangle);
                                e.Graphics.DrawString("Title", printFont, brush, rectangle, stringFormat);
                                point.X += size.Width;

                                rectangle.Location = point;
                                e.Graphics.FillRectangle(shadedBrush, rectangle);
                                e.Graphics.DrawRectangle(pen, rectangle);
                                e.Graphics.DrawString("Username", printFont, brush, rectangle, stringFormat);
                                point.X += size.Width;

                                rectangle.Location = point;
                                e.Graphics.FillRectangle(shadedBrush, rectangle);
                                e.Graphics.DrawRectangle(pen, rectangle);
                                e.Graphics.DrawString("Password", printFont, brush, rectangle, stringFormat);
                                point.X += size.Width;

                                rectangle.Location = point;
                                e.Graphics.FillRectangle(shadedBrush, rectangle);
                                e.Graphics.DrawRectangle(pen, rectangle);
                                e.Graphics.DrawString("URL", printFont, brush, rectangle, stringFormat);
                                point.X += size.Width;

                                rectangle.Location = point;
                                e.Graphics.FillRectangle(shadedBrush, rectangle);
                                e.Graphics.DrawRectangle(pen, rectangle);
                                e.Graphics.DrawString("Notes", printFont, brush, rectangle, stringFormat);
                                point.Y += size.Height;

                                foreach (Group printGroup in KeyPassManager.GetAllGroups())
                                {
                                    point.X = 0;
                                    rectangle.Location = point;
                                    e.Graphics.FillRectangle(shadedBrush, rectangle);
                                    e.Graphics.DrawRectangle(pen, rectangle);
                                    e.Graphics.DrawString(printGroup.Name, printFont, brush, rectangle, stringFormat);
                                    point.X += size.Width;

                                    groupBufferRectangle.Location = point;
                                    e.Graphics.FillRectangle(shadedBrush, groupBufferRectangle);
                                    e.Graphics.DrawRectangle(pen, groupBufferRectangle);
                                    point.Y += size.Height;
                                    point.X = 0;

                                    keyBufferRectangle.Location = point;
                                    keyBufferRectangle.Height = size.Height * printGroup.Keys.Count;
                                    e.Graphics.DrawRectangle(pen, keyBufferRectangle);

                                    foreach (Key printKey in printGroup.Keys)
                                    {
                                        point.X = size.Width;
                                        rectangle.Location = point;
                                        e.Graphics.DrawString(printKey.Title, printFont, brush, rectangle, stringFormat);
                                        e.Graphics.DrawRectangle(pen, rectangle);

                                        point.X += size.Width;
                                        rectangle.Location = point;
                                        e.Graphics.DrawString(printKey.Username, printFont, brush, rectangle, stringFormat);
                                        e.Graphics.DrawRectangle(pen, rectangle);

                                        point.X += size.Width;
                                        rectangle.Location = point;
                                        e.Graphics.DrawString(printKey.Password, printFont, brush, rectangle, stringFormat);
                                        e.Graphics.DrawRectangle(pen, rectangle);

                                        point.X += size.Width;
                                        rectangle.Location = point;
                                        e.Graphics.DrawString(printKey.Url, printFont, brush, rectangle, stringFormat);
                                        e.Graphics.DrawRectangle(pen, rectangle);

                                        point.X += size.Width;
                                        rectangle.Location = point;
                                        e.Graphics.DrawString(printKey.Notes, printFont, brush, rectangle, stringFormat);
                                        e.Graphics.DrawRectangle(pen, rectangle);
                                        point.Y += size.Height;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void OnPrintPreviewClick(object sender, EventArgs e)
        {
            using (PrintPreviewDialog printPreview = new PrintPreviewDialog())
            {
                printPreview.Document = _printDocument;
                ((Form)printPreview).WindowState = FormWindowState.Maximized;
                printPreview.ShowDialog(this);
            }
        }
    }
}