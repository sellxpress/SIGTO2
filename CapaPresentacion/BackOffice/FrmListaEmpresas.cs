using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmListaEmpresas : Form
    {
        private bool buscando = false;

        public FrmListaEmpresas()
        {
            InitializeComponent();
            CargarEmpresas();
        }

        private void CargarEmpresas()
        {
            string textoBusqueda = txtBuscar.Text.Trim();
            Logica logica = new Logica();
            List<EmpresaDTO> empresas = logica.ObtenerEmpresasPorCorreo(textoBusqueda);
            dgvEmpresas.DataSource = empresas;
            ConfigurarDataGridView(dgvEmpresas);
            CalcularCantidadTotal(dgvEmpresas);
        }

        private void CalcularCantidadTotal(DataGridView dgvEmpresas)
        {
            int totalCantidad = 0;
            foreach (DataGridViewRow fila in dgvEmpresas.Rows)
            {
                // Asegurarse de que la fila no sea la fila nueva de DataGridView
                if (!fila.IsNewRow)
                {
                    totalCantidad++;
                }
            }
            lblCantidad.Text = $"Empresas: {totalCantidad}";
        }
        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV
            // Ocultar columnas innecesarias
            dgv.Columns[3].Visible = false;
            dgv.Columns[5].Visible = false;

            // Cambiar el nombre de las columnas según los campos
            dgv.Columns[0].HeaderText = "Nro. RUT";
            dgv.Columns[1].HeaderText = "Nombre";
            dgv.Columns[2].HeaderText = "Correo electronico";
            dgv.Columns[4].HeaderText = "Nro. Ventas";
            dgv.Columns[6].HeaderText = "Descripcion";

            // Establecer la fuente del DataGridView
            dgv.DefaultCellStyle.Font = new Font("Trebuchet MS", 12);

            // Apariencia del encabezado
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 71, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajuste automático de tamaño y altura del encabezado
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False; // No permite que el texto se divida en varias líneas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 35; // Altura del encabezado, ajustable si es necesario

            // Apariencia de las celdas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 50, 56);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Ajuste de filas
            dgv.RowTemplate.Height = 30;

            // Configurar la columna de descripción para que ajuste su tamaño
            dgv.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite que el texto se divida en varias líneas
            dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // La columna de descripción se expandirá

            // Bordes de las celdas y colores alternos
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(224, 224, 224);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Configuración de selección
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Ajuste automático de altura de filas para texto largo
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            FrmMenuBackOffice form = new FrmMenuBackOffice();
            form.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (buscando && txtBuscar.Text != "Buscar por correo...")
            {
                CargarEmpresas();
            }
        }

        private void FrmNavegar_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            txtBuscar.Text = "Buscar por correo...";
            txtBuscar.ForeColor = Color.DarkGray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows.Count > 0)
            {
                EmpresaDTO empresaSeleccionada = (EmpresaDTO)dgvEmpresas.SelectedRows[0].DataBoundItem;
                this.Close();
                FrmEmpresaDetalles form = new FrmEmpresaDetalles(empresaSeleccionada);
                form.Show();
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por correo...")
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
                txtBuscar.Text = "Buscar por correo...";
                txtBuscar.ForeColor = Color.DarkGray;
                buscando = false;
            }
        }
    }
}