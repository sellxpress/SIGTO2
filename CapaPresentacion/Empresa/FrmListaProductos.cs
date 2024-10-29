using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;
using System.Collections.Generic;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
           
        }
        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV
            // Cambiar el nombre de la primera columna
            dgvProducto.Columns[0].HeaderText = "ID ";

            // Establecer la fuente del DataGridView
            dgv.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);

            // Ajustar la apariencia general del DataGridView
            dgvProducto.EnableHeadersVisualStyles = false; // Permitir personalización de encabezados
            dgvProducto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 71, 80); // Color de fondo del encabezado
            dgvProducto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto del encabezado
            dgvProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Fuente del encabezado
            dgvProducto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación del encabezado

            // Ajustar el tamaño de las columnas automáticamente según el contenido
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cambiar el estilo de las filas
            dgvProducto.DefaultCellStyle.BackColor = Color.White; // Color de fondo de las celdas
            dgvProducto.DefaultCellStyle.ForeColor = Color.Black; // Color del texto de las celdas
            dgvProducto.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56); // Color de fondo al seleccionar una fila
            dgvProducto.DefaultCellStyle.SelectionForeColor = Color.White; // Color del texto al seleccionar una fila
            dgvProducto.DefaultCellStyle.Font = new Font("Segoe UI", 9); // Fuente de las celdas

            // Ajustar la altura de las filas y encabezados
            dgvProducto.RowTemplate.Height = 30; // Altura de las filas
            dgvProducto.ColumnHeadersHeight = 35; // Altura del encabezado

            // Opcionalmente, si necesitas eliminar ciertas columnas, puedes hacerlo así:
            dgvProducto.Columns.RemoveAt(6);
            dgvProducto.Columns.RemoveAt(7);

            // Bordes de las celdas para dar un aspecto más limpio
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducto.GridColor = Color.FromArgb(224, 224, 224);  // Color de las líneas de la cuadrícula

            // Deshabilitar el resaltado azul al seleccionar una celda
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.MultiSelect = false; // Selección de solo una fila a la vez

            // Alternar colores de fila para mejor legibilidad
            dgvProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Ajustar automáticamente el ancho de las columnas para que el contenido se muestre completo
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Permitir ajuste automático de la altura de las filas para texto largo
            dgvProducto.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Opción adicional para asegurar que columnas específicas se expandan, por ejemplo, para "Categoria":
            dgvProducto.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            #endregion
        }
        private void CargarArticulos()
        {
            string textoBusqueda = txtBuscar.Text.Trim();
            Logica logica = new Logica();
            List<ArticuloDTO> articulos = logica.ObtenerArticulosPorCorreo(Principal.principal.Correo, textoBusqueda);
            dgvProducto.DataSource = articulos;
            ConfigurarDataGridView(dgvProducto);
            // Actualizar el Label con la cantidad de artículos
            lblCantidadProductos.Text = $" {articulos.Count}";
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



        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                // Obtener el artículo seleccionado
                ArticuloDTO articuloSeleccionado = (ArticuloDTO)dgvProducto.SelectedRows[0].DataBoundItem;

                // Abre el formulario en modo "Editar"
                this.Close();
                FrmProductos form = new FrmProductos(articuloSeleccionado);
                form.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para editar.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProductos form = new FrmProductos();
            form.Show();

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)  // Verifica si hay filas seleccionadas
            {
                int idArticulo = Convert.ToInt32(dgvProducto.SelectedRows[0].Cells["IdArticulo"].Value); 

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este artículo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Logica logica = new Logica();
                    bool exito = logica.EliminarArticulo(idArticulo);

                    if (exito)
                    {
                        CargarArticulos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el artículo.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo para eliminar.");
            }
        }
    }
    }