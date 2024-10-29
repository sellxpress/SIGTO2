using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReseñas : Form
    {
        public FrmReseñas()
        {
            InitializeComponent();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new FrmLogin();
            formulario.Show();
            
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

        private void lbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmListaReseñas form = new FrmListaReseñas();
            form.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void lbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}