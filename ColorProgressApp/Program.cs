using System;
using System.Windows.Forms;

namespace ColorProgressApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Ensure this matches the class name
        }
    }
}
