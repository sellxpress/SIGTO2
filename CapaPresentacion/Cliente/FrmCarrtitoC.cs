using System;
using System.Windows.Forms;
using DTO;
using CapaLogica;
using System.Collections.Generic;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmCarrtitoC : Form
    {
        int? idcliente;
        private List<CarritoDTO> carrito;
        public FrmCarrtitoC()
        {
            InitializeComponent();
            CargarCarrito();
            CalcularCantidadTotal(dgvCarrito);
            CalcularValorTotal(dgvCarrito);
        }
        private void CargarCarrito()
        {
            Logica logica = new Logica();
            string correo = Principal.principal.Correo;
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            carrito = logica.ObtenerArticulosDelCarrito(idcliente.Value);
            dgvCarrito.DataSource = carrito;
            ConfigurarDataGridViewCarrito(dgvCarrito);
        }
        private void CalcularCantidadTotal(DataGridView dgvCarrito)
        {
            int totalCantidad = 0;
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                // Asegurarse de que la fila no sea nula y tenga el valor de la columna "Cantidad"
                if (fila.Cells[1].Value != null)
                {
                    // Sumar el valor de la columna "Cantidad" si es un valor entero
                    totalCantidad += Convert.ToInt32(fila.Cells[1].Value);
                }
            }
            lblProductos.Text = $"Productos: {totalCantidad}";
        }
        private void CalcularValorTotal(DataGridView dgvCarrito)
        {
            int valorestimado = 0;
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                // Asegurarse de que la fila no sea nula y tenga el valor de la columna "Cantidad"
                if (fila.Cells[2].Value != null)
                {
                    // Sumar el valor de la columna "Cantidad" si es un valor entero
                    valorestimado += Convert.ToInt32(fila.Cells[2].Value);
                }
            }
            lblValorEstimado.Text = $"Costo total: ${valorestimado}";
        }
        private void ConfigurarDataGridViewCarrito(DataGridView dgv)
        {
            #region Apariencia DGV
            // Eliminar columnas específicas
            dgvCarrito.Columns[0].Visible = false; // Oculta la primera columna
            dgvCarrito.Columns[3].Visible = false; // Oculta la cuarta columna

            // Cambiar encabezados de columna
            dgvCarrito.Columns[1].HeaderText = "Cantidad";      
            dgvCarrito.Columns[2].HeaderText = "Monto Total";   
            dgvCarrito.Columns[6].HeaderText = "Artículo";      

            // Establecer la fuente del DataGridView
            dgvCarrito.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);

            // Ajustar la apariencia general del DataGridView
            dgvCarrito.EnableHeadersVisualStyles = false; // Permitir personalización de encabezados
            dgvCarrito.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 71, 80); // Color de fondo del encabezado
            dgvCarrito.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto del encabezado
            dgvCarrito.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente del encabezado
            dgvCarrito.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación del encabezado

            // Ajustar el tamaño de las columnas automáticamente según el contenido
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cambiar el estilo de las filas
            dgvCarrito.DefaultCellStyle.BackColor = Color.White; // Color de fondo de las celdas
            dgvCarrito.DefaultCellStyle.ForeColor = Color.Black; // Color del texto de las celdas
            dgvCarrito.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56); // Color de fondo al seleccionar una fila
            dgvCarrito.DefaultCellStyle.SelectionForeColor = Color.White; // Color del texto al seleccionar una fila
            dgvCarrito.DefaultCellStyle.Font = new Font("Segoe UI", 9); // Fuente de las celdas

            // Ajustar la altura de las filas y encabezados
            dgvCarrito.RowTemplate.Height = 30; // Altura de las filas
            dgvCarrito.ColumnHeadersHeight = 35; // Altura del encabezado

            // Bordes de las celdas para dar un aspecto más limpio
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.GridColor = Color.FromArgb(224, 224, 224);  // Color de las líneas de la cuadrícula

            // Deshabilitar el resaltado azul al seleccionar una celda
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false; // Selección de solo una fila a la vez

            // Alternar colores de fila para mejor legibilidad
            dgvCarrito.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Ajustar automáticamente el ancho de las columnas para que el contenido se muestre completo
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Permitir ajuste automático de la altura de las filas para texto largo
            dgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowHeadersVisible = false;
            #endregion
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuCliente formulario = new FrmMenuCliente();
            formulario.Show();

        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)  // Verifica si hay filas seleccionadas
            {
                int idArticulo = Convert.ToInt32(dgvCarrito.SelectedRows[0].Cells["IdArticulo"].Value);
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este artículo del carrito?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Logica logica = new Logica();
                    int filasAfectadas = logica.EliminarCarrito(idArticulo);
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Artículo eliminado del carrito exitosamente.");
                        CargarCarrito();  // Actualiza el DataGridView después de eliminar
                        CalcularValorTotal(dgvCarrito);
                        CalcularCantidadTotal(dgvCarrito);
                    }
                }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo para eliminar.");
            }
        }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmNavegar SellXpress = new FrmNavegar();
            SellXpress.Show();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas
            {
                CarritoDTO articuloSeleccionado = (CarritoDTO)dgvCarrito.SelectedRows[0].DataBoundItem;
                int cantidadActual = Convert.ToInt32(dgvCarrito.SelectedRows[0].Cells[1].Value); // Acceso a la columna de cantidad
                decimal precioUnitario = articuloSeleccionado.Precio; // Asumiendo que tienes el precio en el DTO

                // Crear instancia del formulario para seleccionar la nueva cantidad
                FrmCantidadProducto frmCantidad = new FrmCantidadProducto();
                frmCantidad.Cantidad = cantidadActual; // Cargar la cantidad actual en el TextBox del formulario
                frmCantidad.ShowDialog(); // Mostrar el formulario como un diálogo
                if (frmCantidad.Confirmar) // Verificar si el usuario confirmó
                {
                    int nuevaCantidad = frmCantidad.Cantidad;
                    // Calcular el nuevo monto total
                    decimal nuevoMontoTotal = nuevaCantidad * precioUnitario;
                    // Llama al método para actualizar la cantidad y el monto total en el carrito
                    Logica logica = new Logica();
                    int filasAfectadas = logica.ActualizarCantidadCarrito(articuloSeleccionado.Idarticulo, nuevaCantidad, nuevoMontoTotal);
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"La cantidad de {articuloSeleccionado.Nombre} ha sido actualizada a {nuevaCantidad}. Monto total actualizado a {nuevoMontoTotal:C}.");
                        CargarCarrito(); // Recargar el carrito para mostrar los cambios
                        CalcularValorTotal(dgvCarrito);
                        CalcularCantidadTotal(dgvCarrito);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un artículo para modificar su cantidad.");
                }
            }
        }
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmFinalizarCompra SellXpress = new FrmFinalizarCompra();
            SellXpress.Show();
        }
    }
    }
