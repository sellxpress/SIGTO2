﻿
namespace CapaPresentacion
{
    partial class FrmMenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCliente));
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.ilPrincipalCliente = new System.Windows.Forms.ImageList(this.components);
            this.btnMiUsuario = new System.Windows.Forms.Button();
            this.btnReseñas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlContenido.Controls.Add(this.btnCerrarSesion);
            this.pnlContenido.Controls.Add(this.btnMiUsuario);
            this.pnlContenido.Controls.Add(this.btnReseñas);
            this.pnlContenido.Controls.Add(this.btnCompras);
            this.pnlContenido.Controls.Add(this.btnCarrito);
            this.pnlContenido.Controls.Add(this.btnNavegar);
            this.pnlContenido.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlContenido.Location = new System.Drawing.Point(0, 70);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1084, 441);
            this.pnlContenido.TabIndex = 6;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCerrarSesion.ImageKey = "cerrarsesion.png";
            this.btnCerrarSesion.ImageList = this.ilPrincipalCliente;
            this.btnCerrarSesion.Location = new System.Drawing.Point(746, 246);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 135);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // ilPrincipalCliente
            // 
            this.ilPrincipalCliente.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPrincipalCliente.ImageStream")));
            this.ilPrincipalCliente.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPrincipalCliente.Images.SetKeyName(0, "carro.png");
            this.ilPrincipalCliente.Images.SetKeyName(1, "cerrarsesion.png");
            this.ilPrincipalCliente.Images.SetKeyName(2, "configuracion.png");
            this.ilPrincipalCliente.Images.SetKeyName(3, "contraseña.png");
            this.ilPrincipalCliente.Images.SetKeyName(4, "notificacion.png");
            this.ilPrincipalCliente.Images.SetKeyName(5, "notificacion1.png");
            this.ilPrincipalCliente.Images.SetKeyName(6, "usuario.png");
            this.ilPrincipalCliente.Images.SetKeyName(7, "resenas.png");
            this.ilPrincipalCliente.Images.SetKeyName(8, "micuenta.png");
            this.ilPrincipalCliente.Images.SetKeyName(9, "ventas.png");
            this.ilPrincipalCliente.Images.SetKeyName(10, "comprar3.png");
            this.ilPrincipalCliente.Images.SetKeyName(11, "compras.png");
            // 
            // btnMiUsuario
            // 
            this.btnMiUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnMiUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiUsuario.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMiUsuario.ImageKey = "micuenta.png";
            this.btnMiUsuario.ImageList = this.ilPrincipalCliente;
            this.btnMiUsuario.Location = new System.Drawing.Point(381, 246);
            this.btnMiUsuario.Name = "btnMiUsuario";
            this.btnMiUsuario.Size = new System.Drawing.Size(250, 135);
            this.btnMiUsuario.TabIndex = 5;
            this.btnMiUsuario.Text = "Mi Usuario";
            this.btnMiUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMiUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMiUsuario.UseVisualStyleBackColor = false;
            this.btnMiUsuario.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // btnReseñas
            // 
            this.btnReseñas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnReseñas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReseñas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReseñas.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseñas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnReseñas.ImageKey = "resenas.png";
            this.btnReseñas.ImageList = this.ilPrincipalCliente;
            this.btnReseñas.Location = new System.Drawing.Point(42, 246);
            this.btnReseñas.Name = "btnReseñas";
            this.btnReseñas.Size = new System.Drawing.Size(250, 135);
            this.btnReseñas.TabIndex = 3;
            this.btnReseñas.Text = "Reseñas";
            this.btnReseñas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReseñas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReseñas.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCompras.ImageKey = "compras.png";
            this.btnCompras.ImageList = this.ilPrincipalCliente;
            this.btnCompras.Location = new System.Drawing.Point(746, 36);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(250, 135);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCarrito.ImageKey = "carro.png";
            this.btnCarrito.ImageList = this.ilPrincipalCliente;
            this.btnCarrito.Location = new System.Drawing.Point(381, 36);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(250, 135);
            this.btnCarrito.TabIndex = 1;
            this.btnCarrito.Text = "Carrito";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNavegar
            // 
            this.btnNavegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNavegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavegar.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavegar.ImageKey = "comprar3.png";
            this.btnNavegar.ImageList = this.ilPrincipalCliente;
            this.btnNavegar.Location = new System.Drawing.Point(42, 36);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(250, 135);
            this.btnNavegar.TabIndex = 0;
            this.btnNavegar.Text = "Navegar";
            this.btnNavegar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavegar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNavegar.UseVisualStyleBackColor = false;
            this.btnNavegar.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 511);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(1084, 50);
            this.pnlPie.TabIndex = 5;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnSalir);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1084, 70);
            this.pnlTitulo.TabIndex = 4;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lblTitulo.Location = new System.Drawing.Point(414, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(206, 35);
            this.lblTitulo.TabIndex = 62;
            this.lblTitulo.Text = "Menu Principal";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(1023, 32);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 67;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.Close_Icon;
            this.btnSalir.Location = new System.Drawing.Point(1056, 32);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(16, 16);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSalir.TabIndex = 68;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnMiUsuario;
        private System.Windows.Forms.Button btnReseñas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.ImageList ilPrincipalCliente;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblTitulo;
    }
}