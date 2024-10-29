using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaLogica;


namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        private string correo;
        public string Correo
        {
            get { return this.correo; }
        }
        public FrmLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

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

        #region "Controlar la ventana"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion "Controlar la ventana"

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                lblError.Visible = true;
                return;
            }

            string correo = txtEmail.Text;
            string contrasena = txtContraseña.Text;
            Logica logica = new Logica();
            string tipoUsuario;
            bool loginExitoso = logica.IniciarSesion(correo, contrasena, out tipoUsuario);
            Principal.principal.correo = correo;

            if (loginExitoso && !string.IsNullOrEmpty(tipoUsuario))
            {
                switch (tipoUsuario)
                {
                    case "Cliente":
                        FrmMenuCliente frmMenuCliente = new FrmMenuCliente();
                        frmMenuCliente.Show();
                        this.Hide();
                        break;

                    case "Empresa":
                        FrmMenuEmpresa frmMenuEmpresa = new FrmMenuEmpresa();
                        frmMenuEmpresa.Show();
                        this.Hide();
                        break;

                    case "Administrador":
                        FrmMenuBackOffice frmMenuBackOffice = new FrmMenuBackOffice();
                        frmMenuBackOffice.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                lblError.Visible = true;
                txtContraseña.Clear();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmRegistroEleccion SellXpress= new FrmRegistroEleccion();
            SellXpress.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmVistaPrevia SellXpress = new FrmVistaPrevia();
            SellXpress.Show();
        }
    }
}