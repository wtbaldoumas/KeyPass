namespace KeyPassUserInterface
{
    partial class ClockControl
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
            this._ClockLabel = new System.Windows.Forms.Label();
            this._ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _ClockLabel
            // 
            this._ClockLabel.AutoSize = true;
            this._ClockLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._ClockLabel.Location = new System.Drawing.Point(0, 4);
            this._ClockLabel.Name = "_ClockLabel";
            this._ClockLabel.Size = new System.Drawing.Size(0, 16);
            this._ClockLabel.TabIndex = 0;
            this._ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ClockLabel.UseCompatibleTextRendering = true;
            this._ClockLabel.Click += new System.EventHandler(this.OnTimeClick);
            // 
            // _ClockTimer
            // 
            this._ClockTimer.Enabled = true;
            this._ClockTimer.Interval = 500;
            this._ClockTimer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // ClockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._ClockLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ClockControl";
            this.Size = new System.Drawing.Size(102, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _ClockLabel;
        private System.Windows.Forms.Timer _ClockTimer;
    }
}
