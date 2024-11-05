using System;
using System.Windows.Forms;
using DTO;
using CapaLogica;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmPromociones : Form
    {
        private AnuncioDTO anuncio;
        string empresarut;
        public FrmPromociones(AnuncioDTO anuncio)
        {
            InitializeComponent();
            this.anuncio = anuncio;
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Empresa";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            empresarut = info.RutEmpresa;
            lblTitulo.Text = $"Modificar Promocion";
            CargarDatos();
        }
        public FrmPromociones()
        {
            InitializeComponent();
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Empresa";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            empresarut = info.RutEmpresa; // Obtener el RUT de la empresa actual
            // Inicializa el ID de artículo a 0 para indicar que es un nuevo producto
            txtID.Text = "0";
            txtID.ForeColor = Color.Gray; // Mostrar como placeholder
            lblTitulo.Text = $"Agregar Promocion";
        }
        private void CargarDatos()
        {
            txtID.Text = anuncio.Idanuncio.ToString();
            txtNombre.Text = anuncio.Nombre;
            txtDescuento.Text = anuncio.Descuento.ToString();
            dtpInicio.Value = anuncio.Fechainicio;
            dtpFin.Value = anuncio.Fechafin;
            if (!string.IsNullOrEmpty(anuncio.Imagen))
            {
                try
                {
                    pbFoto.Image = Image.FromFile(anuncio.Imagen);
                    txtRuta.Text = anuncio.Imagen;
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
            FrmListaPromociones formulario = new FrmListaPromociones();
            formulario.Show();
           
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblRUT_Click(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtID.Enter += (s, args) => { this.ActiveControl = null; };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaPromociones form = new FrmListaPromociones();
            form.Show();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones para campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
         

            string nombre = txtNombre.Text;
            int descuento = int.TryParse(txtDescuento.Text, out int parseddescuento) ? parseddescuento : 0;
            DateTime fechaInicio = dtpInicio.Value.ToUniversalTime();
            DateTime fechaFin = dtpFin.Value.ToUniversalTime();
            string imagen = txtRuta.Text;
            int idanuncio = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;
            
            if (descuento == 0)
            {
                lblErrorDescuento.Visible = true;
                return;
            }
            else
            {
                lblErrorDescuento.Visible = false;
            }

            // Crear un nuevo anuncio
            Anuncio nuevoAnuncio = new Anuncio(idanuncio, nombre, fechaInicio, fechaFin, descuento, imagen, empresarut);

            if (idanuncio == 0)
            {
                // Insertar nuevo anuncio
                nuevoAnuncio.insertarAnuncio();
            }
            else
            {
                // Actualizar anuncio existente
                nuevoAnuncio.actualizarAnuncio();
            }
            this.Close();
            FrmListaPromociones form = new FrmListaPromociones();
            form.Show();
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
                    txtRuta.Text = imagePath;
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}