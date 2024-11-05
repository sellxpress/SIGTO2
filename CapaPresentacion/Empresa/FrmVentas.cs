using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            CargarVentas();
        }
        private void CargarVentas()
        {
            string correoEmpresa = Principal.principal.Correo;
            Logica logica = new Logica();
            List<VentaDTO> ventas = logica.ObtenerVentasPorCorreoEmpresa(correoEmpresa); 
            dgvVentas.DataSource = ventas;
            ConfigurarDataGridView(dgvVentas);
            CalcularCantidadTotal(dgvVentas);
        }
        private void CalcularCantidadTotal(DataGridView dgvVentas)
        {
            int totalVentasCompletadas = 0;
            int totalVentasCanceladas = 0;

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Asumiendo que la columna "Estado" es la columna donde se encuentra el estado de la venta
                    string estado = fila.Cells[1].Value?.ToString(); 

                    if (estado == "Completada")
                    {
                        totalVentasCompletadas++;
                    }
                    else if (estado == "Cancelada")
                    {
                        totalVentasCanceladas++;
                    }
                }
            }
            lblVentasCompletadas.Text = $"Ventas completadas: {totalVentasCompletadas}";
            lblVentasCanceladas.Text = $"Ventas canceladas: {totalVentasCanceladas}";
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV

            // Ocultar columnas innecesarias
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].Visible = false;

            // Cambiar el nombre de las columnas según los campos de PersonaDTO
            dgv.Columns[0].HeaderText = "ID Venta";
            dgv.Columns[1].HeaderText = "Estado de venta";
            dgv.Columns[2].HeaderText = "Fecha de realizacion";
            dgv.Columns[3].HeaderText = "Importe final";
            dgv.Columns[4].HeaderText = "Importe total";
            dgv.Columns[5].HeaderText = "Descuento";
            dgv.Columns[6].HeaderText = "Costo de envio";
            dgv.Columns[9].HeaderText = "Nombre del cliente";
            dgv.Columns[10].HeaderText = "Correo del cliente";

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

            // Bordes de las celdas y colores alternos
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(224, 224, 224);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Configuración de selección
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Ajuste automático de altura de filas para texto largo
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
            FrmMenuEmpresa form = new FrmMenuEmpresa();
            form.Show();
        }

        private void FrmNavegar_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }
    }
    }