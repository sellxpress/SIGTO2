using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Principal
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}