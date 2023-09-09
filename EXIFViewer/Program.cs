using System;
using System.Threading;
using System.Windows.Forms;

namespace EXIFViewer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(GlobalException);

            Application.Run(new EXIFViewer());
        }

        static void GlobalException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
