using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMenuEmpresa : Form
    {
        string hora;
        public FrmMenuEmpresa()
        {
            InitializeComponent();
            hora = DateTime.Now.ToString("HH:mm");
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Empresa";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            lblInfo.Text = $"{info.NombreEmpresa} | "+hora;
        }

        private void FrmPrincipalEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductos formulario = new FrmListaProductos();
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
            FrmVentas formulario = new FrmVentas();
            formulario.Show();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmListaPedidos formulario = new FrmListaPedidos();
            formulario.Show();
            this.Close();
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
            FrmListaPromociones form = new FrmListaPromociones();
            form.Show();
            this.Close();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
           hora = DateTime.Now.ToString("HH:mm");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}