namespace KeyPassUserInterface
{
    partial class _StatusStripControl
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
            this._StatusStripTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._StatusStripComboBox = new System.Windows.Forms.ComboBox();
            this._TotalGroupsLabel = new System.Windows.Forms.Label();
            this._SelectedKeysLabel = new System.Windows.Forms.Label();
            this._clockControl = new KeyPassUserInterface.ClockControl();
            this._StatusStripTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _StatusStripTableLayoutPanel
            // 
            this._StatusStripTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._StatusStripTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._StatusStripTableLayoutPanel.ColumnCount = 4;
            this._StatusStripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._StatusStripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._StatusStripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._StatusStripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._StatusStripTableLayoutPanel.Controls.Add(this._StatusStripComboBox, 0, 0);
            this._StatusStripTableLayoutPanel.Controls.Add(this._TotalGroupsLabel, 1, 0);
            this._StatusStripTableLayoutPanel.Controls.Add(this._SelectedKeysLabel, 2, 0);
            this._StatusStripTableLayoutPanel.Controls.Add(this._clockControl, 3, 0);
            this._StatusStripTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._StatusStripTableLayoutPanel.Name = "_StatusStripTableLayoutPanel";
            this._StatusStripTableLayoutPanel.RowCount = 1;
            this._StatusStripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._StatusStripTableLayoutPanel.Size = new System.Drawing.Size(780, 30);
            this._StatusStripTableLayoutPanel.TabIndex = 0;
            // 
            // _StatusStripComboBox
            // 
            this._StatusStripComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._StatusStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._StatusStripComboBox.FormattingEnabled = true;
            this._StatusStripComboBox.Location = new System.Drawing.Point(3, 4);
            this._StatusStripComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this._StatusStripComboBox.Name = "_StatusStripComboBox";
            this._StatusStripComboBox.Size = new System.Drawing.Size(469, 21);
            this._StatusStripComboBox.TabIndex = 0;
            // 
            // _TotalGroupsLabel
            // 
            this._TotalGroupsLabel.AutoSize = true;
            this._TotalGroupsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TotalGroupsLabel.Location = new System.Drawing.Point(478, 0);
            this._TotalGroupsLabel.Name = "_TotalGroupsLabel";
            this._TotalGroupsLabel.Size = new System.Drawing.Size(47, 30);
            this._TotalGroupsLabel.TabIndex = 1;
            this._TotalGroupsLabel.Text = "Groups: ";
            this._TotalGroupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _SelectedKeysLabel
            // 
            this._SelectedKeysLabel.AutoSize = true;
            this._SelectedKeysLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SelectedKeysLabel.Location = new System.Drawing.Point(531, 0);
            this._SelectedKeysLabel.Name = "_SelectedKeysLabel";
            this._SelectedKeysLabel.Size = new System.Drawing.Size(100, 30);
            this._SelectedKeysLabel.TabIndex = 2;
            this._SelectedKeysLabel.Text = "x of y selected keys";
            this._SelectedKeysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _clockControl
            // 
            this._clockControl.Cursor = System.Windows.Forms.Cursors.Default;
            this._clockControl.Location = new System.Drawing.Point(637, 3);
            this._clockControl.Name = "_clockControl";
            this._clockControl.Size = new System.Drawing.Size(140, 24);
            this._clockControl.TabIndex = 3;
            // 
            // _StatusStripControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._StatusStripTableLayoutPanel);
            this.Name = "_StatusStripControl";
            this.Size = new System.Drawing.Size(780, 30);
            this.Load += new System.EventHandler(this.OnLoad);
            this._StatusStripTableLayoutPanel.ResumeLayout(false);
            this._StatusStripTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _StatusStripTableLayoutPanel;
        private System.Windows.Forms.ComboBox _StatusStripComboBox;
        private System.Windows.Forms.Label _TotalGroupsLabel;
        private System.Windows.Forms.Label _SelectedKeysLabel;
        private ClockControl _clockControl;
    }
}
