using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmListaUsuarios : Form
    {
        private bool buscando = false;
        public FrmListaUsuarios()
        {
            InitializeComponent();
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            string textoBusqueda = txtBuscar.Text.Trim();
            Logica logica = new Logica();
            List<PersonaDTO> personas = logica.ObtenerPersonasConIdCliente(textoBusqueda); 
            dgvUsuarios.DataSource = personas;
            ConfigurarDataGridView(dgvUsuarios);
            CalcularCantidadTotal(dgvUsuarios);
        }
        private void CalcularCantidadTotal(DataGridView dgvUsuarios)
        {
            int totalCantidad = 0;
            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                // Asegurarse de que la fila no sea la fila nueva de DataGridView
                if (!fila.IsNewRow)
                {
                    totalCantidad++;
                }
            }
            lblCantidad.Text = $"Usuarios: {totalCantidad}";
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            #region Apariencia DGV

            // Ocultar columnas innecesarias
            dgv.Columns[4].Visible = false;
            dgv.Columns[7].Visible = false;

            // Cambiar el nombre de las columnas según los campos de PersonaDTO
            dgv.Columns[0].HeaderText = "Correo electronico";
            dgv.Columns[1].HeaderText = "Cedula de identidad";
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[3].HeaderText = "Apellido";
            dgv.Columns[5].HeaderText = "Fecha Nac.";
            dgv.Columns[6].HeaderText = "Nro. Celular";
            dgv.Columns[8].HeaderText = "ID Cliente";

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
            FrmMenuBackOffice form = new FrmMenuBackOffice();
            form.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (buscando && txtBuscar.Text != "Buscar por correo...")
            {
                CargarPersonas();
            }
        }

        private void FrmNavegar_Load(object sender, EventArgs e)
        {
            CargarPersonas();
            txtBuscar.Text = "Buscar por correo...";
            txtBuscar.ForeColor = Color.DarkGray;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                PersonaDTO personaSeleccionada = (PersonaDTO)dgvUsuarios.SelectedRows[0].DataBoundItem;
                this.Close();
                FrmPersonaDetalles form = new FrmPersonaDetalles(personaSeleccionada);  
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