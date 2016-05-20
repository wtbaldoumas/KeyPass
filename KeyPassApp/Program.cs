using KeyPassUserInterface;
using System;
using System.Windows.Forms;

namespace KeyPassApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PasswordForm passwordForm = new PasswordForm();
            
            if(passwordForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
