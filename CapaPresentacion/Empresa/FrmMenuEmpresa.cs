using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMenuEmpresa : Form
    {
        
        public FrmMenuEmpresa()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Empresa";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            lblNombre.Text = $"{info.NombreEmpresa}";
        }

        private void FrmPrincipalEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmListaProductos();
            formulario.Show();
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

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            Principal.principal.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmMiEmpresaDatos form = new FrmMiEmpresaDatos();
            form.Show();
            this.Close();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void pbUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}