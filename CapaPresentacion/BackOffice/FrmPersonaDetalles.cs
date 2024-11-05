using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmPersonaDetalles : Form
    {
        private PersonaDTO persona;
        public FrmPersonaDetalles(PersonaDTO persona)
        {
            InitializeComponent();
            this.persona = persona;
            CargarDatos();
        }
        private void CargarDatos()
        {
            txtID.Text = persona.Idcliente.ToString();
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtCedula.Text = persona.Ci;
            txtEmail.Text = persona.Correo;
            txtNroTelefonico.Text = persona.Nrocelular.ToString();
            txtFechaNac.Text = persona.Fechanac.ToString("yyyy-MM-dd");
            if (!string.IsNullOrEmpty(persona.Foto))
            {
                try
                {
                    pbFoto.Image = Image.FromFile(persona.Foto);
                    txtRutaFoto.Text = persona.Foto;
                }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
                {
                }
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaUsuarios SellXpress = new FrmListaUsuarios();
            SellXpress.Show();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar >= 46 && e.KeyChar <= 47))
            {
                e.Handled = true;
                return;
            }
        }

        private void FrmMiUsuarioDatos_Load(object sender, EventArgs e)
        {
            txtNombre.Enter += (s, args) => { this.ActiveControl = null; };
            txtEmail.Enter += (s, args) => { this.ActiveControl = null; };
            txtCedula.Enter += (s, args) => { this.ActiveControl = null; };
            txtNroTelefonico.Enter += (s, args) => { this.ActiveControl = null; };
            txtApellido.Enter += (s, args) => { this.ActiveControl = null; };
            txtFechaNac.Enter += (s, args) => { this.ActiveControl = null; };
            txtID.Enter += (s, args) => { this.ActiveControl = null; };
            txtRutaFoto.Enter += (s, args) => { this.ActiveControl = null; };
            pbFoto.Enter += (s, args) => { this.ActiveControl = null; };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaUsuarios SellXpress = new FrmListaUsuarios();
            SellXpress.Show();
        }
    }
    }
