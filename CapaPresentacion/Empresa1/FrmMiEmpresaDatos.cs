using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMiEmpresaDatos : Form
    {
        public FrmMiEmpresaDatos()
        {
            InitializeComponent();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new FrmLogin();
            formulario.Show();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new FrmMenuEmpresa();
            formulario.Show();
           
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
            Form formulario = new FrmMenuEmpresa();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNacM_Click(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
           if (archivo.ShowDialog() == DialogResult.OK)
            {
                pBLogo.ImageLocation = archivo.FileName;
                pBLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
                }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}