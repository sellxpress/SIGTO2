using System;
using System.Windows.Forms;
using DTO;
using CapaLogica;
using System.Drawing;
namespace CapaPresentacion
{
    public partial class FrmProductosBO : Form
    {
        private ArticuloDTO articulo;
        public FrmProductosBO(ArticuloDTO articulo)
        {
            InitializeComponent();
            this.articulo = articulo; 
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
            FrmListaProductos formulario = new FrmListaProductos();
            formulario.Show();
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaProductos form = new FrmListaProductos();
            form.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaProductos form = new FrmListaProductos();
            form.Show();
        }
    }
        }
   
    