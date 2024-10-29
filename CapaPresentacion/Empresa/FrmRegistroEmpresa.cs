using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
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
        #region Controlar la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

        #region Validar Correo
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        private void PnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmRegistroEleccion();
            formulario.Show();
            this.Close();

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // 1. Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtRut.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                lblError.Visible = true;
                return; // Detener ejecución si hay campos vacíos
            }
            else
            {
                lblError.Visible = false; // Ocultar error si no hay campos vacíos
            }

            // 2. Validar que el RUT tenga exactamente 12 dígitos
            if (txtRut.Text.Length != 12 || !txtRut.Text.All(char.IsDigit))
            {
                lblErrorRut.Visible = true;
                return; // Detener ejecución si el RUT no cumple el formato
            }
            else
            {
                lblErrorRut.Visible = false;
            }

            // 3. Validar formato del correo
            if (!IsValidEmail(txtEmail.Text))
            {
                lblErrorEmail.Visible = true;
                return; // Detener ejecución si el formato del correo es incorrecto
            }
            else
            {
                lblErrorEmail.Visible = false;
            }

            // Si todas las validaciones pasan, proceder con el registro de la empresa
            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string correo = txtEmail.Text;
            string contra = txtContraseña.Text;
            long nroventas = 0;
            string logo = "";
            string descripcion = "";
            Empresa unaEmpresa = new Empresa(rut, nombre, correo, contra, nroventas, logo, descripcion);

            try
            {
                unaEmpresa.insertarEmpresa();
                // Redirigir al formulario de login después del registro exitoso
                Principal.principal.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar la empresa: " + ex.Message);
            }
        }

        private void FrmRegistroEmpresa_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblErrorRut.Visible = false;
            lblErrorEmail.Visible = false;
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}