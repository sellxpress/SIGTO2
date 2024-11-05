
namespace CapaPresentacion
{
    partial class FrmMiUsuarioEleccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiUsuarioEleccion));
            this.IlMiUsuarioEleccion = new System.Windows.Forms.ImageList(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.btnMiDireccion = new System.Windows.Forms.Button();
            this.lblMiUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // IlMiUsuarioEleccion
            // 
            this.IlMiUsuarioEleccion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IlMiUsuarioEleccion.ImageStream")));
            this.IlMiUsuarioEleccion.TransparentColor = System.Drawing.Color.Transparent;
            this.IlMiUsuarioEleccion.Images.SetKeyName(0, "EditarDireccion.png");
            this.IlMiUsuarioEleccion.Images.SetKeyName(1, "EditarPerfil.png");
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnSalir);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(676, 45);
            this.pnlTitulo.TabIndex = 13;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitulo_Paint);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.IconoMinimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(616, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 63;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.IconoCerrar;
            this.btnSalir.Location = new System.Drawing.Point(648, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(16, 16);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSalir.TabIndex = 64;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 225);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(676, 17);
            this.pnlPie.TabIndex = 65;
            this.pnlPie.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPie_Paint);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnMiPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiPerfil.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMiPerfil.ImageKey = "editarPerfil.png";
            this.btnMiPerfil.ImageList = this.IlMiUsuarioEleccion;
            this.btnMiPerfil.Location = new System.Drawing.Point(26, 65);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(293, 146);
            this.btnMiPerfil.TabIndex = 68;
            this.btnMiPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMiPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMiPerfil.UseVisualStyleBackColor = false;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // btnMiDireccion
            // 
            this.btnMiDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnMiDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiDireccion.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMiDireccion.ImageKey = "EditarDireccion.png";
            this.btnMiDireccion.ImageList = this.IlMiUsuarioEleccion;
            this.btnMiDireccion.Location = new System.Drawing.Point(361, 65);
            this.btnMiDireccion.Name = "btnMiDireccion";
            this.btnMiDireccion.Size = new System.Drawing.Size(293, 146);
            this.btnMiDireccion.TabIndex = 67;
            this.btnMiDireccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMiDireccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMiDireccion.UseVisualStyleBackColor = false;
            this.btnMiDireccion.Click += new System.EventHandler(this.btnMiDireccion_Click);
            // 
            // lblMiUsuario
            // 
            this.lblMiUsuario.AutoSize = true;
            this.lblMiUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMiUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMiUsuario.Location = new System.Drawing.Point(33, 185);
            this.lblMiUsuario.Name = "lblMiUsuario";
            this.lblMiUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMiUsuario.Size = new System.Drawing.Size(68, 19);
            this.lblMiUsuario.TabIndex = 85;
            this.lblMiUsuario.Text = "Mi Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(367, 185);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "Mi Direccion";
            // 
            // FrmMiUsuarioEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(676, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMiUsuario);
            this.Controls.Add(this.btnMiPerfil);
            this.Controls.Add(this.btnMiDireccion);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMiUsuarioEleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmRegistroEleccion_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList IlMiUsuarioEleccion;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.Button btnMiDireccion;
        private System.Windows.Forms.Label lblMiUsuario;
        private System.Windows.Forms.Label label1;
    }
}