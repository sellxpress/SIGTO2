using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmListaReseñas : Form
    {
        int? idcliente;
        public FrmListaReseñas()
        {
            InitializeComponent();
        }
        private void CargarValoraciones()
        {
            Logica logica = new Logica();
            string correo = Principal.principal.Correo;
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            List<ValoracionDTO> valoraciones = logica.ObtenerValoracionesPorCliente(idcliente.Value);
            dgvValoracion.DataSource = valoraciones;
            lblCantidad.Text = $"Reseñas realizadas: { valoraciones.Count}";
            ConfigurarDataGridView(dgvValoracion);
        }
        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV
            dgvValoracion.Columns[0].Visible = false;
            dgvValoracion.Columns[3].Visible = false; 
            dgvValoracion.Columns[4].Visible = false;

            // Cambiar encabezados de columna
            dgvValoracion.Columns[1].HeaderText = "Calificacion";
            dgvValoracion.Columns[2].HeaderText = "Comentario";
            dgvValoracion.Columns[5].HeaderText = "Nombre del articulo";

            // Establecer la fuente del encabezado de columna
            dgvValoracion.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Ajusta el tamaño según sea necesario

            // Establecer la fuente del DataGridView
            dgv.DefaultCellStyle.Font = new Font("Bahnschrift", 10); // Ajusta el tamaño aquí también

            // Ajustar la apariencia general del DataGridView
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 71, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar el estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Ajustar altura de filas y encabezados
            dgv.RowTemplate.Height = 30; // Ajustar según sea necesario
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; // Ajustar automáticamente la altura de los encabezados

            // Bordes de las celdas
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(224, 224, 224);

            // Configuración de selección de fila completa y alternar colores de fila
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Ajustar automáticamente el ancho de las columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar a todas las celdas según el contenido

            // Permitir ajuste automático de la altura de las filas para texto largo
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permitir saltos de línea
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Ajustar automáticamente la altura de las filas

            // Ocultar los encabezados de fila
            dgv.RowHeadersVisible = false; // Quitar el piquito en la primera columna
            #endregion
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuCliente SellXpress = new FrmMenuCliente();
            SellXpress.Show();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmReseñas form = new FrmReseñas();
            form.ShowDialog();
        }

        private void FrmListaReseñas_Load(object sender, EventArgs e)
        {
            CargarValoraciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvValoracion.SelectedRows.Count > 0)  // Verifica si hay filas seleccionadas
            {
                int idValoracion = Convert.ToInt32(dgvValoracion.SelectedRows[0].Cells["IdValoracion"].Value);
                Logica logica = new Logica();
                int filasAfectadas = logica.EliminarValoracion(idValoracion);
                CargarValoraciones();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvValoracion.SelectedRows.Count > 0)
            {
                ValoracionDTO valoracionseleccionada = (ValoracionDTO)dgvValoracion.SelectedRows[0].DataBoundItem;
                this.Close();
                FrmReseñas form = new FrmReseñas(valoracionseleccionada);
                form.Show();
            }
        }
    }
}
    

