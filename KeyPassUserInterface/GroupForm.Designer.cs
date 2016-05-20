namespace KeyPassUserInterface
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this._groupFormTableLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this._groupFormLabel = new System.Windows.Forms.Label();
            this._groupFormTextBox = new System.Windows.Forms.TextBox();
            this._groupFormTestButton = new System.Windows.Forms.Button();
            this._groupFormOKButton = new System.Windows.Forms.Button();
            this._groupFormCancelButton = new System.Windows.Forms.Button();
            this._groupFormTableLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupFormTableLayout1
            // 
            this._groupFormTableLayout1.ColumnCount = 4;
            this._groupFormTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._groupFormTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this._groupFormTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this._groupFormTableLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this._groupFormTableLayout1.Controls.Add(this._groupFormLabel, 0, 0);
            this._groupFormTableLayout1.Controls.Add(this._groupFormTextBox, 1, 0);
            this._groupFormTableLayout1.Controls.Add(this._groupFormTestButton, 0, 1);
            this._groupFormTableLayout1.Controls.Add(this._groupFormOKButton, 2, 1);
            this._groupFormTableLayout1.Controls.Add(this._groupFormCancelButton, 3, 1);
            this._groupFormTableLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupFormTableLayout1.Location = new System.Drawing.Point(0, 0);
            this._groupFormTableLayout1.Name = "_groupFormTableLayout1";
            this._groupFormTableLayout1.RowCount = 2;
            this._groupFormTableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._groupFormTableLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._groupFormTableLayout1.Size = new System.Drawing.Size(342, 87);
            this._groupFormTableLayout1.TabIndex = 0;
            // 
            // _groupFormLabel
            // 
            this._groupFormLabel.AutoSize = true;
            this._groupFormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._groupFormLabel.Location = new System.Drawing.Point(3, 0);
            this._groupFormLabel.Name = "_groupFormLabel";
            this._groupFormLabel.Size = new System.Drawing.Size(58, 43);
            this._groupFormLabel.TabIndex = 0;
            this._groupFormLabel.Text = "Group:";
            this._groupFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _groupFormTextBox
            // 
            this._groupFormTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._groupFormTableLayout1.SetColumnSpan(this._groupFormTextBox, 3);
            this._groupFormTextBox.Location = new System.Drawing.Point(67, 11);
            this._groupFormTextBox.Name = "_groupFormTextBox";
            this._groupFormTextBox.Size = new System.Drawing.Size(272, 20);
            this._groupFormTextBox.TabIndex = 1;
            // 
            // _groupFormTestButton
            // 
            this._groupFormTableLayout1.SetColumnSpan(this._groupFormTestButton, 2);
            this._groupFormTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupFormTestButton.Location = new System.Drawing.Point(3, 46);
            this._groupFormTestButton.Name = "_groupFormTestButton";
            this._groupFormTestButton.Size = new System.Drawing.Size(150, 38);
            this._groupFormTestButton.TabIndex = 2;
            this._groupFormTestButton.Text = "Test";
            this._groupFormTestButton.UseVisualStyleBackColor = true;
            this._groupFormTestButton.Click += new System.EventHandler(this.OnTestClick);
            // 
            // _groupFormOKButton
            // 
            this._groupFormOKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupFormOKButton.Location = new System.Drawing.Point(159, 46);
            this._groupFormOKButton.Name = "_groupFormOKButton";
            this._groupFormOKButton.Size = new System.Drawing.Size(86, 38);
            this._groupFormOKButton.TabIndex = 3;
            this._groupFormOKButton.Text = "OK";
            this._groupFormOKButton.UseVisualStyleBackColor = true;
            this._groupFormOKButton.Click += new System.EventHandler(this.OnOKClick);
            // 
            // _groupFormCancelButton
            // 
            this._groupFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._groupFormCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupFormCancelButton.Location = new System.Drawing.Point(251, 46);
            this._groupFormCancelButton.Name = "_groupFormCancelButton";
            this._groupFormCancelButton.Size = new System.Drawing.Size(88, 38);
            this._groupFormCancelButton.TabIndex = 4;
            this._groupFormCancelButton.Text = "Cancel";
            this._groupFormCancelButton.UseVisualStyleBackColor = true;
            this._groupFormCancelButton.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // GroupForm
            // 
            this.AcceptButton = this._groupFormOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._groupFormCancelButton;
            this.ClientSize = new System.Drawing.Size(342, 87);
            this.Controls.Add(this._groupFormTableLayout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Group";
            this.Load += new System.EventHandler(this.OnGroupFormLoad);
            this._groupFormTableLayout1.ResumeLayout(false);
            this._groupFormTableLayout1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _groupFormTableLayout1;
        private System.Windows.Forms.Label _groupFormLabel;
        private System.Windows.Forms.TextBox _groupFormTextBox;
        private System.Windows.Forms.Button _groupFormTestButton;
        private System.Windows.Forms.Button _groupFormOKButton;
        private System.Windows.Forms.Button _groupFormCancelButton;
    }
}