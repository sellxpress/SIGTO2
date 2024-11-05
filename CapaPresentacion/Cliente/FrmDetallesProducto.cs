using System;
using System.Windows.Forms;
using DTO;
using CapaLogica;
using System.Drawing;
namespace CapaPresentacion
{
    public partial class FrmDetallesProducto : Form
    {
        private ArticuloDTO articulo;
        int? idcliente;
        public FrmDetallesProducto(ArticuloDTO articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            CargarDatos();

        }
        private void CargarDatos()
        {
            txtNombre.Text = articulo.Nombre;
            txtCategoria.Text = articulo.Categoria.ToString();
            txtPrecio.Text = articulo.Precio.ToString();
            txtCantidad.Text = articulo.Stock.ToString();
            txtEstado.Text = articulo.Estado.ToString();
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
            FrmNavegar SellXpress = new FrmNavegar();
            SellXpress.Show();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            txtNombre.Enter += (s, args) => { this.ActiveControl = null; };
            txtPrecio.Enter += (s, args) => { this.ActiveControl = null; };
            txtEstado.Enter += (s, args) => { this.ActiveControl = null; };
            txtDescripcion.Enter += (s, args) => { this.ActiveControl = null; };
            txtCategoria.Enter += (s, args) => { this.ActiveControl = null; };
            txtCantidad.Enter += (s, args) => { this.ActiveControl = null; };
            txtRutaImagen.Enter += (s, args) => { this.ActiveControl = null; };

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmNavegar form = new FrmNavegar();
            form.Show();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (idcliente.HasValue)
            {
                // Mostrar el formulario para ingresar la cantidad
                FrmCantidadProducto formCantidad = new FrmCantidadProducto();
                formCantidad.ShowDialog();

                if (formCantidad.Confirmar)
                {
                    int cantidad = formCantidad.Cantidad;

                    // Verificar que la cantidad solicitada no supere el stock disponible
                    if (cantidad <= articulo.Stock)
                    {
                        decimal montoTotal = cantidad * articulo.Precio;

                        // Llamar al método para insertar o actualizar el carrito
                        Carrito carrito = new Carrito();
                        carrito.InsertarOActualizarCarrito(idcliente.Value, cantidad, montoTotal, articulo.Idarticulo);

                        // Mensaje de confirmación
                        MessageBox.Show($"{cantidad} artículo(s) agregado(s) al carrito. Monto total: {montoTotal:C}");
                    }
                    else
                    {
                        MessageBox.Show($"La cantidad solicitada excede el stock disponible. Stock actual: {articulo.Stock}");
                    }
                }
            }
        }
    }
}
   
    