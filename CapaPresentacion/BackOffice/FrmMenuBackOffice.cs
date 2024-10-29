using System;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmMenuBackOffice : Form
    {
        public FrmMenuBackOffice()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            lblNombre.Text = $"{info.Nombre} {info.Apellido}";
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Principal.principal.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngestionarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnMonitorearActividad_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}