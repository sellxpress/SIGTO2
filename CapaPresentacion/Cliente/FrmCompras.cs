using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
        int? idcliente;
        public FrmCompras()
        {
            InitializeComponent();
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            List<VentaDTO>  compras = logica.ObtenerVentasPorClienteId(idcliente.Value); 
            dgvCompras.DataSource = compras;
            ConfigurarDataGridView(dgvCompras);
            CalcularCantidadTotal(dgvCompras);
        }

        private void CalcularCantidadTotal(DataGridView dgvUsuarios)
        {
            int totalCantidad = 0;
            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                if (!fila.IsNewRow)
                {
                    totalCantidad++;
                }
            }
            lblCantidad.Text = $"Compras realizadas: {totalCantidad}";
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV

            // Ocultar columnas innecesarias
            dgv.Columns[0].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;

            // Cambiar el nombre de las columnas según los campos de PersonaDTO
            dgvCompras.Columns[1].HeaderText = "Estado";
            dgvCompras.Columns[2].HeaderText = "Fecha de realizacion";
            dgvCompras.Columns[3].HeaderText = "Monto final";
            dgvCompras.Columns[4].HeaderText = "Monto total";
            dgvCompras.Columns[5].HeaderText = "Descuento";
            dgvCompras.Columns[6].HeaderText = "Costo de envio";

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
            FrmMenuCliente form = new FrmMenuCliente();
            form.Show();
        }

        private void FrmNavegar_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }
    }
    }