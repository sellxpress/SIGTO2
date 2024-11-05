using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmReseñas : Form
    {
        private ValoracionDTO valoracion;
       int? idcliente;
        public FrmReseñas(ValoracionDTO valoracion)
        {
            InitializeComponent();
            cbArticulosDisponibles.Visible = false;
            this.valoracion = valoracion;
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            CargarDatos();
        }
        public FrmReseñas()
        {
            InitializeComponent();
            cbArticulosDisponibles.Visible = true;
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            txtID.Text = "0";
            txtID.ForeColor = Color.Gray;
            CargarArticulosDisponibles();
        }
        private void CargarArticulosDisponibles()
        {
            Logica logica = new Logica();
            var articulosDisponibles = logica.ObtenerArticulosCompradosPorCliente(idcliente.Value);

            cbArticulosDisponibles.Items.Clear();

            if (articulosDisponibles.Count == 0)
            {
                // Si no hay artículos, agregar un elemento informativo
                lblErrorArticulo.Visible = true;
                cbArticulosDisponibles.Enabled = false; // Desactivar el ComboBox
            }
            else
            {
                cbArticulosDisponibles.Enabled = true; // Activar el ComboBox
                foreach (var articulo in articulosDisponibles)
                {
                    // Crear un objeto anónimo con solo el nombre del artículo para mostrarlo en el ComboBox
                    cbArticulosDisponibles.Items.Add(new ComboBoxItem(articulo.Idarticulo, articulo.Nombre));
                }
            }
        }
        private class ComboBoxItem
        {
            public int Id { get; }
            public string Nombre { get; }

            public ComboBoxItem(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }

            public override string ToString()
            {
                // Solo el nombre del artículo se muestra en el ComboBox
                return Nombre;
            }
        }
        private void  CargarDatos()
        {
            txtID.Text = valoracion.Idvaloracion.ToString();
            txtComentario.Text = valoracion.Comentario;
            if (lbCalificacion.Items.Contains(valoracion.Calificacion))
            {
                lbCalificacion.SelectedItem = valoracion.Calificacion;
            }
        }
            private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaReseñas formulario = new FrmListaReseñas();
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
            txtID.Enter += (s, args) => { this.ActiveControl = null; };
            lblError.Visible = false;
            lblErrorArticulo.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaReseñas formulario = new FrmListaReseñas();
            formulario.Show();
        }

        private void lbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones para campos obligatorios
            if (lbCalificacion.SelectedItem == null)
            {
                lblError.Visible = true;
                return;
            }
            else if (cbArticulosDisponibles.Visible && cbArticulosDisponibles.SelectedItem == null)
            {
                // Si el ComboBox está habilitado, verifica que se haya seleccionado un artículo
                lblError.Text = "Debes seleccionar un artículo para realizar la reseña.";
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

            // Obtener valores de los campos de texto
            string calificacion = lbCalificacion.SelectedItem.ToString();
            string comentario = txtComentario.Text;
            int idarticulo;
            int idvaloracion = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;

            if (idvaloracion == 0) // Si estamos creando una nueva valoración
            {
                idarticulo = (cbArticulosDisponibles.SelectedItem as ComboBoxItem)?.Id ?? 0; // Obtener del ComboBox
            }
            else // Si estamos editando una valoración existente
            {
                idarticulo = valoracion.Idarticulo; // Obtener del objeto valoracion
            }

            // Crear un nuevo objeto ValoracionDTO
            Valoracion nuevaValoracion = new Valoracion(idvaloracion, calificacion, comentario, idarticulo, idcliente.Value);
            if (idvaloracion == 0)
            {
                // Insertar nueva valoración
                nuevaValoracion.insertarValoracion();
            }
            else
            {
                // Actualizar valoración existente
                nuevaValoracion.actualizarValoracion();
            }
            this.Close();
            FrmListaReseñas form = new FrmListaReseñas();
            form.Show();
    }

            private void cbArticulosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}