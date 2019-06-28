using System;
using System.Windows.Forms;

namespace FrameCapture
{
    static class App
    {
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
        }
    }
}