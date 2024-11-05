using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmListaPedidos : Form
    {
        private bool buscando = false;
        public FrmListaPedidos()
        {
            InitializeComponent();
            CargarVentas();
            timer = new Timer();
            timer.Interval = 30000; 
            timer.Tick += timer_Tick; 
            gbInfo.Visible = false;
        }
        private void CargarVentas()
        {
            string correoEmpresa = Principal.principal.Correo;
            Logica logica = new Logica();
            List<VentaDTO> ventas = logica.ObtenerVentasEnProcesoPorCorreoEmpresa(correoEmpresa);
            dgvPedidos.DataSource = ventas;
            ConfigurarDataGridView(dgvPedidos);
            CalcularCantidadTotal(dgvPedidos);
        }
        private void CargarVentasDetalles(int? idventa = null)
        {
            string correoEmpresa = Principal.principal.Correo;
            Logica logica = new Logica();
            List<VentaDetalleDTO> ventasdetalles;
            if (idventa.HasValue)
            {
                // Cargar detalles solo si se proporciona un ID de venta
                ventasdetalles = logica.ObtenerDetallesVentaPorCorreoEmpresa(correoEmpresa, idventa.Value);
            }
            else
            {
                // Cargar todos los detalles si no se proporciona un ID
                ventasdetalles = logica.ObtenerDetallesVentaPorCorreoEmpresa(correoEmpresa, 0); // Asegúrate de manejar correctamente este caso en la lógica
            }
            dgvPedidosDetalles.DataSource = ventasdetalles;
            ConfigurarDataGridView2(dgvPedidosDetalles);
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
            lblCantidad.Text = $"Pedidos en curso: {totalCantidad}";
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV

            // Ocultar columnas innecesarias
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;

            // Cambiar el nombre de las columnas según los campos de PersonaDTO
            dgvPedidos.Columns[0].HeaderText = "Venta | ID ";
            dgvPedidos.Columns[1].HeaderText = "Venta | Estado";
            dgvPedidos.Columns[2].HeaderText = "Venta | Fecha de realizacion";
            dgvPedidos.Columns[3].HeaderText = "Venta | Importe final";
            dgvPedidos.Columns[4].HeaderText = "Venta | Importe total";
            dgvPedidos.Columns[5].HeaderText = "Venta | Descuento";
            dgvPedidos.Columns[6].HeaderText = "Venta | Costo de envio";
            dgvPedidos.Columns[9].HeaderText = "Cliente | Nombre";
            dgvPedidos.Columns[10].HeaderText = "Cliente | Correo electronico";
            dgvPedidos.Columns[11].HeaderText = "Domicilio | Calle";
            dgvPedidos.Columns[12].HeaderText = "Domicilio | Numero";
            dgvPedidos.Columns[13].HeaderText = "Domicilio | Localidad";
            dgvPedidos.Columns[14].HeaderText = "Domicilio | Departamento";
            dgvPedidos.Columns[15].HeaderText = "Domicilio | Referencia";

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
        private void ConfigurarDataGridView2(DataGridView dgv)
        {
            #region Apariencia DGV

            // Ocultar columnas innecesarias
            dgv.Columns[0].Visible = false;
            dgv.Columns[3].Visible = false;

            // Cambiar el nombre de las columnas según los campos de PersonaDTO
            dgvPedidosDetalles.Columns[1].HeaderText = "Precio unitario ";
            dgvPedidosDetalles.Columns[2].HeaderText = "Cantidad de articulos";
            dgvPedidosDetalles.Columns[4].HeaderText = "Stock";
            dgvPedidosDetalles.Columns[5].HeaderText = "ID de la venta";
            dgvPedidosDetalles.Columns[6].HeaderText = "Nombre del articulo";

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
            gbInfo.Visible = false;
            CargarVentas();
            CargarVentasDetalles();
            txtBuscar.Text = "Buscar por ID de venta...";
            txtBuscar.ForeColor = Color.DarkGray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas
            {
                VentaDTO ventaSeleccionada = (VentaDTO)dgvPedidos.SelectedRows[0].DataBoundItem;
                FrmGestionarEstado frmGestionar = new FrmGestionarEstado(ventaSeleccionada.Idventa);
                // Cargar el estado actual en el ComboBox
                frmGestionar.EstadoActual = ventaSeleccionada.Estado; // Asumiendo que tienes una propiedad Estado en VentaDTO
                frmGestionar.ShowDialog(); // Muestra el formulario como un diálogo
                CargarVentas();
                CargarVentasDetalles();
                    }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido para gestionar su estado.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(textoBuscar) || textoBuscar == "Buscar por ID de venta...")
            {
                // Si el campo está vacío o es el placeholder, cargar todas las ventas
                CargarVentasDetalles();
            }
            else
            {
                // Intenta convertir el texto a un entero
                if (int.TryParse(textoBuscar, out int idventa))
                {
                    // Cargar solo los detalles que coinciden con el ID
                    CargarVentasDetalles(idventa);
                }
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por ID de venta...")
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
                txtBuscar.Text = "Buscar por ID de venta...";
                txtBuscar.ForeColor = Color.DarkGray;
                buscando = false;
            }
    }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmVentas form = new FrmVentas();
            form.Show();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            gbInfo.Visible = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gbInfo.Visible = false; 
            timer.Stop(); 
        }
    }
    }