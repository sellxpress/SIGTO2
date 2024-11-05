using System;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmMenuBackOffice : Form
    {
        string hora;
        public FrmMenuBackOffice()
        {
            InitializeComponent();
            hora = DateTime.Now.ToString("HH:mm");
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            lblInfo.Text = $" Sr. {info.Nombre +" "+ info.Apellido} | " + hora;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmMiUsuarioDatosBO SellXpress = new FrmMiUsuarioDatosBO();
            SellXpress.Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductosBo SellXpress = new FrmListaProductosBo();
            SellXpress.Show();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmEleccionUsuarios SellXpress = new FrmEleccionUsuarios();
            SellXpress.Show();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Principal.principal.Show();
            this.Close();
        }
    }
}