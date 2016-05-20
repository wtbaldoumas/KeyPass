using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KeyPassUserInterface
{

    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _ClockLabel.Text = DateTime.Now.ToString();
        }

        private void OnTimeClick(object sender, EventArgs e)
        {
            Process.Start("TimeDate.cpl");
        }
    }
}
