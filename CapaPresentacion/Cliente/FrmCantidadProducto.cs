using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmCantidadProducto : Form
    {
        public int Cantidad { get; set; } 
        public bool Confirmar { get; private set; }


        public FrmCantidadProducto()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Confirmar = false;
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

        private void PnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void FrmRegistroEleccion_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = Cantidad.ToString(); // Cargar la cantidad actual en el TextBox
           lblError.Visible = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form SellXpress = new FrmMenuCliente();
            SellXpress.Show();

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar >= 46 && e.KeyChar <= 47))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                Cantidad = cantidad;
                Confirmar = true;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}