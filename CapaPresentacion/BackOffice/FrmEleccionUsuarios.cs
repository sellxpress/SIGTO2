using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmEleccionUsuarios : Form
    {
        public FrmEleccionUsuarios()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Controlar la ventana"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

        #region "Placeholder"

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        #endregion "Placeholder"

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmMenuBackOffice SellXpress = new FrmMenuBackOffice();
            SellXpress.Show();
            this.Close();
        }
        private void FrmEleccionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmListaUsuarios SellXpress = new FrmListaUsuarios();
            SellXpress.Show();
            this.Close();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FrmListaEmpresas SellXpress = new FrmListaEmpresas();
            SellXpress.Show();
            this.Close();
        }
    }
}