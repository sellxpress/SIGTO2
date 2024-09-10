using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMiUsuarioEleccion : Form
    {
        public FrmMiUsuarioEleccion ()
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmRegistroEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void FrmRegistroEmpresa_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
        }

        private void lblRedireccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new FrmLogin();
            formulario.Show();
            this.Hide();
        }

        private void pnlPie_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMiUsuarioDireccion();
            formulario.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMiUsuarioDatos();
            formulario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void FrmRegistroEleccion_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMenuCliente();
            formulario.Show();
            this.Hide();
        }
    }
}