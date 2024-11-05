using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmRegistroCliente : Form
    {
        public FrmRegistroCliente()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Controlar la ventana"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

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

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlTitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // 1. Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtFechaNac.Text) ||
                string.IsNullOrWhiteSpace(txtNroTelefonico.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

            // 2. Validar formato del correo
            if (!IsValidEmail(txtEmail.Text))
            {
                lblErrorEmail.Visible = true;
                return;
            }
            else
            {
                lblErrorEmail.Visible = false;
            }

            // 3. Validar que la cédula tenga exactamente 8 dígitos y no contenga puntos ni guiones
            if (txtCedula.Text.Length != 8 || !txtCedula.Text.All(char.IsDigit))
            {
                lblErrorCI.Visible = true;
                return;
            }
            else
            {
                lblErrorCI.Visible = false;
            }

            // 4. Validar la fecha de nacimiento en formato yyyy-MM-dd
            if (!DateTime.TryParseExact(txtFechaNac.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                lblErrorFN.Visible = true;
                return;
            }
            else
            {
                lblErrorFN.Visible = false;
            }

            // 5. Validar que el número de teléfono tenga exactamente 9 dígitos
            if (txtNroTelefonico.Text.Length != 9 || !txtNroTelefonico.Text.All(char.IsDigit))
            {
                lblErrorNroTel.Visible = true;
                return;
            }
            else
            {
                lblErrorNroTel.Visible = false;
            }

            // Si todas las validaciones son correctas, proceder con el registro
            string correo = txtEmail.Text;
            string ci = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contra = txtContraseña.Text;
            DateTime fechanac = fechaNacimiento;
            string nrocelular = txtNroTelefonico.Text;
            string personacorreo = txtEmail.Text;
            long nrocompras = 0;
            int idcliente = 0;

            try
            {
                Persona unaPersona = new Persona(correo, ci, nombre, apellido, contra, fechanac, nrocelular);
                unaPersona.insertarPersona();

                Cliente unCliente = new Cliente(personacorreo, idcliente, nrocompras);
                unCliente.insertarCliente();

                Principal.principal.Show();
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }

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

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblErrorEmail.Visible = false;
            lblErrorFN.Visible = false;
            lblErrorCI.Visible = false;
            lblErrorNroTel.Visible = false;

            txtFechaNac.Text = "1981-09-28";  // Ejemplo fecha
            txtFechaNac.ForeColor = Color.LightGray; // Cambia el texto a gris
            txtCedula.Text = "12345678"; // Ejemplo ci
            txtCedula.ForeColor = Color.LightGray; // Cambia el texto a gris
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmRegistroEleccion formulario = new FrmRegistroEleccion();
            formulario.Show();
            this.Close();
        }

        private void txtCedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNroTelefonico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtFechaNac_Enter(object sender, EventArgs e)
        {
            if (txtFechaNac.Text == "1981-09-28") // Ejemplo fecha
            {
                txtFechaNac.Text = "";
                txtFechaNac.ForeColor = Color.Black; // Cambia el texto a negro
            }
        }

        private void txtFechaNac_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFechaNac.Text))
            {
                txtFechaNac.Text = "1981-09-28"; // Ejemplo fecha
                txtFechaNac.ForeColor = Color.LightGray; // Cambia el texto a gris
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "12345678")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Black; // Cambia el texto a negro
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                txtCedula.Text = "12345678";
                txtCedula.ForeColor = Color.LightGray; // Cambia el texto a gris 
            }
        }
    }
}