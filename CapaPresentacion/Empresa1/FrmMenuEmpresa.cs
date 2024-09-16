using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuEmpresa : Form
    {
        public FrmMenuEmpresa()
        {
            InitializeComponent();
        }

        private void FrmPrincipalEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMiEmpresaDatos();
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmLogin();
            formulario.Show();
            this.Hide();
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
    }
}