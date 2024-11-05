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
            if (lbCategoria.Items.Contains(articulo.Categoria))
            {
                lbCategoria.SelectedItem = articulo.Categoria; 
            }
            txtPrecio.Text = articulo.Precio.ToString();
            txtCantidad.Text = articulo.Stock.ToString();
            if (lbEstado.Items.Contains(articulo.Estado))
            {
                lbEstado.SelectedItem = articulo.Estado; 
            }
            if (!string.IsNullOrEmpty(articulo.Imagen))
            {
                try
                {
                    pbImagen.Image = Image.FromFile(articulo.Imagen);
                }
                catch (Exception ex)
                {
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) || lbCategoria.SelectedItem == null ||
                lbEstado.SelectedItem == null || string.IsNullOrWhiteSpace(txtRutaImagen.Text)) 
            {
                lblError.Visible = true;
                return;
            }
              else
            {
                lblError.Visible = false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Validar que la cantidad sea un número entero válido
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string nombreArticulo = txtNombre.Text;
            string categoria = lbCategoria.SelectedItem.ToString();
            string estado = lbEstado.SelectedItem.ToString();
            string descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text; 
            string imagen = txtRutaImagen.Text;
            int idarticulo = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;
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
            this.Close();
            FrmListaProductos form = new FrmListaProductos();
            form.Show();
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
                    string imagePath = openFileDialog.FileName;
                    pbImagen.Image = Image.FromFile(imagePath);
                    txtRutaImagen.Text = imagePath;
                }
            }
        }
    }
}
    
    