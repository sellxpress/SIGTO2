using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Principal
    {
        public static FrmLogin principal;
        [STAThread]
        private static void Main()
      {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            principal = new FrmLogin();
            Application.Run(principal);
        }
    }
}