using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMenuCliente : Form
    {
        string hora;
        public FrmMenuCliente()
        {
            InitializeComponent();
           hora = DateTime.Now.ToString("HH:mm");
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente"; 
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            lblInfo.Text = $"{info.Nombre+" "+info.Apellido} | " + hora;
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmNavegar SellXpress = new FrmNavegar();
            SellXpress.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReseñas_Click(object sender, EventArgs e)
        {
            FrmListaReseñas SellXpress = new FrmListaReseñas();
            SellXpress.Show();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras SellXpress = new FrmCompras();
            SellXpress.Show();
            this.Close();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrtitoC SellXpress = new FrmCarrtitoC();
            SellXpress.Show();
            this.Close();
        }
        private void btnMiUsuario_Click(object sender, EventArgs e)
        {
            FrmMiUsuarioEleccion formulario = new FrmMiUsuarioEleccion();
            formulario.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Principal.principal.Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm");
        }
    }
}