namespace KeyPassUserInterface
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this._passwordtableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._passwordTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._passwordOKButton = new System.Windows.Forms.Button();
            this._passwordCancelButton = new System.Windows.Forms.Button();
            this._passwordCheckBox = new System.Windows.Forms.CheckBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._passwordtableLayoutPanel1.SuspendLayout();
            this._passwordTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _passwordtableLayoutPanel1
            // 
            this._passwordtableLayoutPanel1.ColumnCount = 2;
            this._passwordtableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.10585F));
            this._passwordtableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.89415F));
            this._passwordtableLayoutPanel1.Controls.Add(this._passwordTableLayoutPanel2, 1, 4);
            this._passwordtableLayoutPanel1.Controls.Add(this._passwordCheckBox, 0, 3);
            this._passwordtableLayoutPanel1.Controls.Add(this._passwordLabel, 0, 2);
            this._passwordtableLayoutPanel1.Controls.Add(this._passwordTextBox, 1, 2);
            this._passwordtableLayoutPanel1.Controls.Add(this._usernameTextBox, 1, 1);
            this._passwordtableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this._passwordtableLayoutPanel1.Controls.Add(this._pictureBox, 0, 0);
            this._passwordtableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordtableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._passwordtableLayoutPanel1.Name = "_passwordtableLayoutPanel1";
            this._passwordtableLayoutPanel1.RowCount = 5;
            this._passwordtableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._passwordtableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._passwordtableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._passwordtableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._passwordtableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._passwordtableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._passwordtableLayoutPanel1.Size = new System.Drawing.Size(359, 215);
            this._passwordtableLayoutPanel1.TabIndex = 0;
            // 
            // _passwordTableLayoutPanel2
            // 
            this._passwordTableLayoutPanel2.ColumnCount = 3;
            this._passwordTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._passwordTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._passwordTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._passwordTableLayoutPanel2.Controls.Add(this._passwordOKButton, 1, 0);
            this._passwordTableLayoutPanel2.Controls.Add(this._passwordCancelButton, 2, 0);
            this._passwordTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordTableLayoutPanel2.Location = new System.Drawing.Point(68, 185);
            this._passwordTableLayoutPanel2.Name = "_passwordTableLayoutPanel2";
            this._passwordTableLayoutPanel2.RowCount = 1;
            this._passwordTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._passwordTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this._passwordTableLayoutPanel2.Size = new System.Drawing.Size(288, 27);
            this._passwordTableLayoutPanel2.TabIndex = 0;
            // 
            // _passwordOKButton
            // 
            this._passwordOKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordOKButton.Location = new System.Drawing.Point(99, 3);
            this._passwordOKButton.Name = "_passwordOKButton";
            this._passwordOKButton.Size = new System.Drawing.Size(90, 21);
            this._passwordOKButton.TabIndex = 0;
            this._passwordOKButton.Text = "OK";
            this._passwordOKButton.UseVisualStyleBackColor = true;
            this._passwordOKButton.Click += new System.EventHandler(this.OnOKClick);
            // 
            // _passwordCancelButton
            // 
            this._passwordCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._passwordCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordCancelButton.Location = new System.Drawing.Point(195, 3);
            this._passwordCancelButton.Name = "_passwordCancelButton";
            this._passwordCancelButton.Size = new System.Drawing.Size(90, 21);
            this._passwordCancelButton.TabIndex = 1;
            this._passwordCancelButton.Text = "Cancel";
            this._passwordCancelButton.UseVisualStyleBackColor = true;
            this._passwordCancelButton.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // _passwordCheckBox
            // 
            this._passwordCheckBox.AutoSize = true;
            this._passwordtableLayoutPanel1.SetColumnSpan(this._passwordCheckBox, 2);
            this._passwordCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordCheckBox.Location = new System.Drawing.Point(3, 153);
            this._passwordCheckBox.Name = "_passwordCheckBox";
            this._passwordCheckBox.Size = new System.Drawing.Size(353, 26);
            this._passwordCheckBox.TabIndex = 1;
            this._passwordCheckBox.Text = "Show Password";
            this._passwordCheckBox.UseVisualStyleBackColor = true;
            this._passwordCheckBox.CheckedChanged += new System.EventHandler(this.OnShowPasswordChecked);
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._passwordLabel.Location = new System.Drawing.Point(3, 118);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(59, 32);
            this._passwordLabel.TabIndex = 2;
            this._passwordLabel.Text = "Password:";
            this._passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._passwordTextBox.Location = new System.Drawing.Point(68, 124);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '●';
            this._passwordTextBox.Size = new System.Drawing.Size(288, 20);
            this._passwordTextBox.TabIndex = 3;
            // 
            // _usernameTextBox
            // 
            this._usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._usernameTextBox.Location = new System.Drawing.Point(68, 92);
            this._usernameTextBox.Name = "_usernameTextBox";
            this._usernameTextBox.Size = new System.Drawing.Size(288, 20);
            this._usernameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _pictureBox
            // 
            this._passwordtableLayoutPanel1.SetColumnSpan(this._pictureBox, 2);
            this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_pictureBox.Image")));
            this._pictureBox.Location = new System.Drawing.Point(3, 3);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(353, 80);
            this._pictureBox.TabIndex = 6;
            this._pictureBox.TabStop = false;
            // 
            // PasswordForm
            // 
            this.AcceptButton = this._passwordOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._passwordCancelButton;
            this.ClientSize = new System.Drawing.Size(359, 215);
            this.Controls.Add(this._passwordtableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyPass";
            this._passwordtableLayoutPanel1.ResumeLayout(false);
            this._passwordtableLayoutPanel1.PerformLayout();
            this._passwordTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _passwordtableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel _passwordTableLayoutPanel2;
        private System.Windows.Forms.Button _passwordOKButton;
        private System.Windows.Forms.Button _passwordCancelButton;
        private System.Windows.Forms.CheckBox _passwordCheckBox;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox _pictureBox;
    }
}