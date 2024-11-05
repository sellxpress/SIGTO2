using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;
using System.Collections.Generic;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmListaPromociones : Form
    {
        public FrmListaPromociones()
        {
            InitializeComponent();
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV
            dgv.Columns[0].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;

            // Cambiar el nombre de la primera columna
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "Nombre";
            dgv.Columns[2].HeaderText = "Fecha de inicio";
            dgv.Columns[3].HeaderText = "Fecha de fin";
            dgv.Columns[4].HeaderText = "Descuento";
            dgv.Columns[5].HeaderText = "Imagen";

            // Establecer la fuente del DataGridView
            dgv.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);

            // Ajustar la apariencia general del DataGridView
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 71, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajustar el tamaño de las columnas automáticamente según el contenido
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cambiar el estilo de las filas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Ajustar la altura de las filas y encabezados
            dgv.RowTemplate.Height = 30;
            dgv.ColumnHeadersHeight = 35;

            // Opcionalmente, si necesitas eliminar ciertas columnas, puedes hacerlo así:
            // dgv.Columns.RemoveAt(6); // Ejemplo de eliminación de columnas
            // dgv.Columns.RemoveAt(7);

            // Bordes de las celdas para dar un aspecto más limpio
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(224, 224, 224);

            // Deshabilitar el resaltado azul al seleccionar una celda
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Alternar colores de fila para mejor legibilidad
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Ajustar automáticamente el ancho de las columnas para que el contenido se muestre completo
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Permitir ajuste automático de la altura de las filas para texto largo
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ocultar el encabezado de filas
            dgv.RowHeadersVisible = false;
            #endregion
        }

        private void CargarAnuncios()
        {
            Logica logica = new Logica();
            List<AnuncioDTO> anuncios = logica.ObtenerAnunciosPorCorreoEmpresa(Principal.principal.Correo);
            dgvPromociones.DataSource = anuncios;
            ConfigurarDataGridView(dgvPromociones);
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

        private void FrmListaPromociones_Load(object sender, EventArgs e)
        {
            CargarAnuncios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPromociones.SelectedRows.Count > 0)
            {
                AnuncioDTO anuncioSeleccionado = (AnuncioDTO)dgvPromociones.SelectedRows[0].DataBoundItem;
                this.Close();
                FrmPromociones form = new FrmPromociones(anuncioSeleccionado);
                form.Show();
            } 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPromociones form = new FrmPromociones();
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPromociones.SelectedRows.Count > 0)  
            {
                int idanuncio = Convert.ToInt32(dgvPromociones.SelectedRows[0].Cells[0].Value);
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este anuncio?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Logica logica = new Logica();
                    int filasAfectadas = logica.EliminarAnuncio(idanuncio); // Llama al método que devuelve un int

                    if (filasAfectadas > 0) // Verifica si se eliminaron filas
                    {
                        MessageBox.Show("Anuncio eliminado exitosamente.");
                        CargarAnuncios(); // Recarga los anuncios para reflejar los cambios
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un anuncio para eliminar.");
            }
        }

        private void dgvPromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
