using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMiUsuarioDatos : Form
    {
        public FrmMiUsuarioDatos()
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMiUsuarioEleccion();
            formulario.Show();
            this.Hide();
        }

        private void txtNroTelefonico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroTelefonico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar >= 46 && e.KeyChar <= 47))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                pBFoto.ImageLocation = archivo.FileName;
                pBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}