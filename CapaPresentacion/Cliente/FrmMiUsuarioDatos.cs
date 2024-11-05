using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMiUsuarioDatos : Form
    {
        private PersonaDTO persona;
        public FrmMiUsuarioDatos(PersonaDTO persona)
        {
            InitializeComponent();
            this.persona = persona;
            txtEmail.Text = Principal.principal.Correo;
            CargarDatos();
        }
        public FrmMiUsuarioDatos()
        {
            InitializeComponent();
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            persona = logica.ObtenerPersonaPorCorreo(correo);
            CargarDatos();
        }
        private void CargarDatos()
        {
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtCedula.Text = persona.Ci;
            txtEmail.Text = Principal.principal.Correo;
            txtNroTelefonico.Text = persona.Nrocelular.ToString();
            txtFechaNac.Text = persona.Fechanac.ToString("yyyy-MM-dd");
            txtContraseña.Text = persona.Contra;
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
            FrmMiUsuarioEleccion SellXpress = new FrmMiUsuarioEleccion();
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Archivos de imagen (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen en el PictureBox
                    string imagePath = openFileDialog.FileName;
                    pbFoto.Image = Image.FromFile(imagePath);
                    txtRutaFoto.Text = imagePath;
                }
            }
        }

        private void FrmMiUsuarioDatos_Load(object sender, EventArgs e)
        {
            txtEmail.Enter += (s, args) => { this.ActiveControl = null; };
            txtCedula.Enter += (s, args) => { this.ActiveControl = null; };
            txtNroTelefonico.Enter += (s, args) => { this.ActiveControl = null; };
            lblErrorFN.Visible = false;
            lblError.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtFechaNac.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

            if (!DateTime.TryParseExact(txtFechaNac.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNac))
            {
                lblErrorFN.Visible = true;
                return;
            }
            else
            {
                lblErrorFN.Visible = false;
            }

            
            string correo = Principal.principal.Correo;
            string ci = txtCedula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contrasena = txtContraseña.Text;
            string nroCelular = txtNroTelefonico.Text;
            string foto = string.IsNullOrWhiteSpace(txtRutaFoto.Text) ? null : txtRutaFoto.Text;


            Persona personaActualizada = new Persona(correo, ci, nombre, apellido, contrasena, fechaNac, nroCelular, foto);
            personaActualizada.actualizarPersona();

            this.Close();
            FrmMiUsuarioEleccion SellXpress = new FrmMiUsuarioEleccion();
            SellXpress.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMiUsuarioEleccion SellXpress = new FrmMiUsuarioEleccion();
            SellXpress.Show();
        }
    }
    }
