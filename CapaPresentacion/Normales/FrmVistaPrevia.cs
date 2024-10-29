using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmVistaPrevia : Form
    {
        private bool buscando = false; 
        public FrmVistaPrevia()
        {
            InitializeComponent();

           
        }
        private void CargarArticulos()
        {
             string textoBusqueda = txtBuscar.Text.Trim();
             Logica logica = new Logica();
             List<ArticuloDTO> articulos = logica.ObtenerTodosLosArticulos(textoBusqueda);
             dgvProducto.DataSource = articulos;
             ConfigurarDataGridView(dgvProducto);
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
            dgvProducto.Columns.RemoveAt(0);

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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal.principal.Show();
            this.Close();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (buscando && txtBuscar.Text != "Buscar por nombre...")
            {
                CargarArticulos(); 
            }
        }

        private void FrmNavegar_Load(object sender, EventArgs e)
        {
            CargarArticulos();
            txtBuscar.Text = "Buscar por nombre...";
            txtBuscar.ForeColor = Color.DarkGray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                // Obtener el artículo seleccionado
                ArticuloDTO articuloSeleccionado = (ArticuloDTO)dgvProducto.SelectedRows[0].DataBoundItem;
                this.Close();
                FrmVistaPrevia2 form = new FrmVistaPrevia2(articuloSeleccionado);
                form.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para ver");
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por nombre...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black; 
            }
            buscando = true;
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar por nombre...";
                txtBuscar.ForeColor = Color.DarkGray; 
                buscando = false;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistroEleccion form = new FrmRegistroEleccion();
            form.Show();
        }
    }
}