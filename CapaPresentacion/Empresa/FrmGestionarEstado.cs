using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmGestionarEstado : Form
    {
        private int idventa;
        public bool Confirmar { get; private set; }


        public FrmGestionarEstado(int idVentaSeleccionada)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Confirmar = false;
            idventa = idVentaSeleccionada;
        }
     
        public string EstadoActual
        {
            get => cbEstado.SelectedItem.ToString();
            set => cbEstado.SelectedItem = value; 
        }

        public string NuevoEstado => cbEstado.SelectedItem.ToString(); // Devuelve el nuevo estado seleccionado

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

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaPedidos SellXpress = new FrmListaPedidos();
            SellXpress.Show();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                string nuevoEstado = NuevoEstado;
                Logica logica = new Logica();
                int filasAfectadas = logica.ActualizarEstadoVenta(idventa, nuevoEstado);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"El estado de la venta ha sido actualizado a: {nuevoEstado}");
                    Confirmar = true; 
                    this.Close(); 
                }
            }
        }
    }
