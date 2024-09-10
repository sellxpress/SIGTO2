using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenuBackOffice : Form
    {
        public FrmMenuBackOffice()
        {
            InitializeComponent();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
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

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btngestionarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnMonitorearActividad_Click(object sender, EventArgs e)
        {

        }
    }
}