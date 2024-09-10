using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Validar Campos TextBoxs"

        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtEmail.Text == "")
            {
                ok = false;
                ep.SetError(txtEmail, "Debe ingresar un email");
            }
            if (txtContraseña.Text == "")
            {
                ok = false;
                ep.SetError(txtContraseña, "Debe ingresar una contraseña");
            }
            return ok;
        }

        #endregion "Validar Campos TextBoxs"

        #region "Eliminar Error Textboxs"

        private void EliminarError()
        {
            ep.SetError(txtEmail, "");
            ep.SetError(txtContraseña, "");
        }

        #endregion "Eliminar Error Textboxs"

        #region "Controlar la ventana"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void PbImagen_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void PnlIzq_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbLogo_Click(object sender, EventArgs e)
        {
        }

        private void PnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new FrmRegistroEleccion();
            formulario.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            EliminarError();
            ValidarCampos();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }
    }
}