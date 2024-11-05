using System;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmMiUsuarioDireccion : Form
    {
        int? idcliente;
        private DireccionClienteDTO direccionCliente;
        public FrmMiUsuarioDireccion(DireccionClienteDTO direccionCliente)
        {
            InitializeComponent();
            this.direccionCliente = direccionCliente;
            if (direccionCliente != null)
            {
                CargarDatos();
            }
        }
        public FrmMiUsuarioDireccion()
        {
            InitializeComponent();
            string correo = Principal.principal.Correo;
            Logica logica = new Logica();
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            int idClienteInt = idcliente.Value; 
            direccionCliente = logica.ObtenerDireccionPorIdCliente(idClienteInt);
            if (direccionCliente != null)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            txtLocalidad.Text = direccionCliente.Localidad;
            txtCalle.Text = direccionCliente.Calle;
            txtNumero.Text = direccionCliente.Numero;
            txtReferencia.Text = direccionCliente.Referencia;
            if (lbDepartamentos.Items.Contains(direccionCliente.Departamento))
            {
                lbDepartamentos.SelectedItem = direccionCliente.Departamento; 
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new FrmMiUsuarioEleccion();
            formulario.Show();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
            if (lbDepartamentos.SelectedItem == null)
            {
                lblError.Visible = true; 
                return;
            }
            else
            {
                lblError.Visible = false; 
            }
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;
            string localidad = txtLocalidad.Text;
            string departamento = lbDepartamentos.SelectedItem.ToString();
            string referencia = txtReferencia.Text;

            DireccionCliente nuevaDireccion = new DireccionCliente(idcliente.Value, calle, numero, localidad, departamento, referencia);
            nuevaDireccion.GuardarDireccionCliente();
            this.Close();
            FrmMiUsuarioEleccion form = new FrmMiUsuarioEleccion();
            form.Show();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void FrmMiUsuarioDireccion_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMiUsuarioEleccion form = new FrmMiUsuarioEleccion();
            form.Show();
        }
    }
}