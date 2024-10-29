using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMiEmpresaDatos : Form
    {
        private EmpresaDTO empresa;
        public FrmMiEmpresaDatos(EmpresaDTO empresa)
        {
            InitializeComponent();
            this.empresa = empresa; 
            txtEmail.Text = Principal.principal.Correo; 
            CargarDatos();
        }
        public FrmMiEmpresaDatos()
        {
            InitializeComponent();
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            empresa = logica.ObtenerEmpresaPorCorreo(correo);
            CargarDatos();
        }
        private void CargarDatos()
        {
            txtRUT.Text = empresa.Rut;
            txtNombre.Text = empresa.Nombre;
            txtEmail.Text = Principal.principal.Correo;
            txtNroVentas.Text = empresa.Nroventas.ToString();
            txtDescripcion.Text = empresa.Descripcion;
            txtContraseña.Text = empresa.Contra;
            // Cargar el logo si existe
            if (!string.IsNullOrEmpty(empresa.Logo))
            {
                try
                {
                    pbLogo.Image = Image.FromFile(empresa.Logo);
                    txtRutaLogo.Text = empresa.Logo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
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
            Form formulario = new FrmMenuEmpresa();
            formulario.Show();

        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                    pbLogo.Image = Image.FromFile(imagePath);

                    // Guardar la ruta de la imagen para insertar en la base de datos
                    txtRutaLogo.Text = imagePath; // Asegúrate de tener un TextBox para almacenar la ruta
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es un campo obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que la contraseña no esté vacía
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("La contraseña es un campo obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que el logo y la descripción, si se proporcionan, no estén vacíos (opcional)
            string logo = string.IsNullOrWhiteSpace(txtRutaLogo.Text) ? null : txtRutaLogo.Text;
            string descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text;

            // Obtener los valores de los campos
            string nombreEmpresa = txtNombre.Text;
            string correo = Principal.principal.Correo;
            string contrasena = txtContraseña.Text;
            string rutEmpresa = txtRUT.Text; 
            long nroVentas = long.Parse(txtNroVentas.Text); 

            // Crear un nuevo objeto Empresa con los datos
            Empresa empresaActualizada = new Empresa(rutEmpresa, nombreEmpresa,correo, contrasena, nroVentas, logo, descripcion);
            Empresa empresa = new Empresa();
            empresaActualizada.actualizarEmpresa();

            this.Close();
            FrmMenuEmpresa form = new FrmMenuEmpresa();
            form.Show();
        }
            private void btnVolver_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmMenuEmpresa();
            formulario.Show();
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtRutaLogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMiEmpresaDatos_Load(object sender, EventArgs e)
        {
            txtRUT.Enter += (s, args) => { this.ActiveControl = null; };
            txtNroVentas.Enter += (s, args) => { this.ActiveControl = null; };
            txtEmail.Enter += (s, args) => { this.ActiveControl = null; };
        }
    }
}