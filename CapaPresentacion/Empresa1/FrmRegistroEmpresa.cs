using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DTO;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmRegistroEmpresa : Form
    {
        public FrmRegistroEmpresa()
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
            if (txtNombre.Text == "")
            {
                ok = false;
                ep.SetError(txtNombre, "Debe ingresar un nombre a la empresa");
            }

            if (txtRut.Text == "")
            {
                ok = false;
                ep.SetError(txtRut, "Debe ingresar el RUT de la empresa");
            }
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
            ep.SetError(txtNombre, "");
            ep.SetError(txtEmail, "");
            ep.SetError(txtRut, "");
            ep.SetError(txtContraseña, "");
        }

        #endregion "Eliminar Error Textboxs"

        #region "Controlar la ventana"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

        #region "Placeholder"

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        #endregion "Placeholder"

        #region "PruebaRegistro"
        private bool Registro()
        {
            bool ok = true;
            if (txtNombre.Text == "" && txtRut.Text == "" && txtEmail.Text == "" && txtContraseña.Text == "")
            {
                ok = false;
                ValidarCampos();
            }
            else
            {
                Form formulario = new FrmLogin();
                formulario.Show();
                this.Hide();
            }
            return ok;
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string correo = txtEmail.Text;
            string contra = txtContraseña.Text;
            Empresa unaEmpresa = new Empresa (rut, nombre, correo,contra);
            unaEmpresa.insertarEmpresa();
            EliminarError();
            ValidarCampos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmRegistroEmpresa_Load(object sender, EventArgs e)
        {
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmRegistroEmpresa_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblEleccion_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}