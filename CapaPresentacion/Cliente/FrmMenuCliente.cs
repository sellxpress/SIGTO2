using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMenuCliente : Form
    {
        public FrmMenuCliente()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente"; 
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            lblNombre.Text = $"{info.Nombre} {info.Apellido}";
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmNavegar();
            formulario.Show();
            this.Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Principal.principal.Show();
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

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
          
        }
        private void btnMiUsuario_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMiUsuarioEleccion();
            formulario.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}