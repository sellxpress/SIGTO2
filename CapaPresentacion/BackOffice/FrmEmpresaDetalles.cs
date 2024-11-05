using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmEmpresaDetalles : Form
    {
        private EmpresaDTO empresa;
        public FrmEmpresaDetalles(EmpresaDTO empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            CargarDatos();
        }
        private void CargarDatos()
        {
            txtRUT.Text = empresa.Rut;
            txtNombre.Text = empresa.Nombre;
            txtEmail.Text = empresa.Correo;
            txtNroVentas.Text = empresa.Nroventas.ToString();
            txtDescripcion.Text = empresa.Descripcion;
            // Cargar el logo si existe
            if (!string.IsNullOrEmpty(empresa.Logo))
            {
                try
                {
                    pbLogo.Image = Image.FromFile(empresa.Logo);
                    txtRutaLogo.Text = empresa.Logo;
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaEmpresas formulario = new FrmListaEmpresas();
            formulario.Show();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtRutaLogo_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmMiEmpresaDatos_Load(object sender, EventArgs e)
        {
            txtNombre.Enter += (s, args) => { this.ActiveControl = null; };
            txtRUT.Enter += (s, args) => { this.ActiveControl = null; };
            txtNroVentas.Enter += (s, args) => { this.ActiveControl = null; };
            txtEmail.Enter += (s, args) => { this.ActiveControl = null; };
            txtDescripcion.Enter += (s, args) => { this.ActiveControl = null; };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaEmpresas formulario = new FrmListaEmpresas();
            formulario.Show();
        }
    }
}
