using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPromociones : Form
    {
        public FrmPromociones()
        {
            InitializeComponent();
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


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }


        private void lblRUT_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmListaProductos form = new FrmListaProductos();
            form.ShowDialog();
            this.Close();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}