using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListaReseñas : Form
    {
        public FrmListaReseñas()
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



        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmReseñas form = new FrmReseñas();
            form.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmReseñas form = new FrmReseñas();
            form.ShowDialog();

        }
    }
}