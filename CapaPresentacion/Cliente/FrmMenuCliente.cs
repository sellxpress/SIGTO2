using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuCliente : Form
    {
        public FrmMenuCliente()
        {
            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMiUsuarioEleccion();
            formulario.Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new FrmLogin();
            formulario.Show();

        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}