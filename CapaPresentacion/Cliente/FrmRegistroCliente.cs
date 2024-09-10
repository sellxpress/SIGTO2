using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

        #region "Validar Campos TextBoxs"

        private bool ValidarCampos()
        {
            DateTime FechaNac;
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                ep.SetError(txtNombre, "Debe ingresar un nombre");
            }
            if (txtApellido.Text == "")
            {
                ok = false;
                ep.SetError(txtApellido, "Debe ingresar un apellido");
            }
            if (txtCedula.Text == "")
            {
                ok = false;
                ep.SetError(txtCedula, "Debe ingresar una cedula de identidad");
            }
            if (txtEmail.Text == "")
            {
                ok = false;
                ep.SetError(txtEmail, "Debe ingresar un email");
            }
            if (txtNroTelefonico.Text == "")
            {
                ok = false;
                ep.SetError(txtNroTelefonico, "Debe ingresar un nro telefonico valido");
            }
            if (txtFechaNac.Text == "" || !DateTime.TryParse(txtFechaNac.Text, out FechaNac))
            {
                ok = false;
                ep.SetError(txtFechaNac, "Debe ingresar una fecha de nacimiento valida, el formato es DD-MM-YYYY");
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
            ep.SetError(txtApellido, "");
            ep.SetError(txtEmail, "");
            ep.SetError(txtCedula, "");
            ep.SetError(txtNroTelefonico, "");
            ep.SetError(txtFechaNac, "");
            ep.SetError(txtContraseña, "");
        }

        #endregion "Eliminar Error Textboxs"

        #region "Controlar la ventana"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblEmail_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void LblContraseña_Click(object sender, EventArgs e)
        {
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroTelefonico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFechaNac_Validating(object sender, CancelEventArgs e)
        {
        }

        private void PnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string correo = txtEmail.Text;
            string ci = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contra = txtContraseña.Text;
            string fechanac = txtFechaNac.Text;
            string nrocelular = txtNroTelefonico.Text;
           CapaLogica.PersonaDTO user = new Persona(correo,ci,nombre,apellido,contra,fechanac,nrocelular);
            user.insertarPersona();
            EliminarError();
            ValidarCampos();
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar >= 46 && e.KeyChar <= 47))
            {
                e.Handled = true;
                return;
            }
        }
    }
}