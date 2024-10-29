using System;
using System.Windows.Forms;
using DTO;
using CapaLogica;
using System.Drawing;
namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        private ArticuloDTO articulo;
        private string empresarut;

        // Constructor para editar un artículo
        public FrmProductos(ArticuloDTO articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Empresa";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            empresarut = info.RutEmpresa;
            lblTitulo.Text = $"Modificar Articulo";
            CargarDatos();
        }
        // Constructor para crear un nuevo artículo
        public FrmProductos()
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
            lblTitulo.Text = $"Agregar Articulo";
        }

     
        private void CargarDatos()
        {
            txtID.Text = articulo.Idarticulo.ToString();
            txtNombre.Text = articulo.Nombre;
            // Cargar la categoría seleccionada
            if (lbCategoria.Items.Contains(articulo.Categoria))
            {
                lbCategoria.SelectedItem = articulo.Categoria;  // Asumiendo que articulo.Categoria es un string que coincide con los elementos del ListBox
            }

            txtPrecio.Text = articulo.Precio.ToString();
            txtCantidad.Text = articulo.Stock.ToString();

            // Cargar el estado seleccionado
            if (lbEstado.Items.Contains(articulo.Estado))
            {
                lbEstado.SelectedItem = articulo.Estado;  // Asumiendo que articulo.Estado es un string que coincide con los elementos del ListBox
            }
            if (!string.IsNullOrEmpty(articulo.Imagen))
            {
                try
                {
                    pbImagen.Image = Image.FromFile(articulo.Imagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }

            txtDescripcion.Text = articulo.Descripcion;
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


        private void lblRUT_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            txtID.Enter += (s, args) => { this.ActiveControl = null; };
        }

        private void lbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaProductos form = new FrmListaProductos();
            form.Show();
        }

        private void lbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) || lbCategoria.SelectedItem == null ||
                lbEstado.SelectedItem == null || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que el precio sea un número decimal válido
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que la cantidad sea un número entero válido
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero y mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obtener los valores de los campos
            string nombreArticulo = txtNombre.Text;
            string categoria = lbCategoria.SelectedItem.ToString();
            string estado = lbEstado.SelectedItem.ToString();
            string descripcion = txtDescripcion.Text;
            string imagen = txtRutaImagen.Text;
            int idarticulo = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;

            // Crear un nuevo objeto Articulo
            Articulo nuevoArticulo = new Articulo(idarticulo, nombreArticulo, categoria, precio, cantidad, estado, imagen, descripcion, empresarut);

            if (idarticulo == 0)
            {
                // Insertar nuevo artículo
                nuevoArticulo.insertarArticulo();
            }
            else
            {
                // Actualizar artículo existente
                nuevoArticulo.actualizarArticulo();
            }

            // Redirigir a la lista de productos después del registro exitoso
            this.Close();
            FrmListaProductos form = new FrmListaProductos();
            form.Show();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    pbImagen.Image = Image.FromFile(imagePath);

                    // Guardar la ruta de la imagen para insertar en la base de datos
                    txtRutaImagen.Text = imagePath; // Asegúrate de tener un TextBox para almacenar la ruta
                }
            }
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    