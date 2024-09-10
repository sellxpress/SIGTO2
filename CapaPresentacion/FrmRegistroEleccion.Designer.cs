﻿
namespace CapaPresentacion
{
    partial class FrmRegistroEleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEleccion));
            this.IlRegistroEleccion = new System.Windows.Forms.ImageList(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblRedireccion = new System.Windows.Forms.LinkLabel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // IlRegistroEleccion
            // 
            this.IlRegistroEleccion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IlRegistroEleccion.ImageStream")));
            this.IlRegistroEleccion.TransparentColor = System.Drawing.Color.Transparent;
            this.IlRegistroEleccion.Images.SetKeyName(0, "comprador.png");
            this.IlRegistroEleccion.Images.SetKeyName(1, "empresa.png");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lblTitulo.Location = new System.Drawing.Point(119, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(449, 33);
            this.lblTitulo.TabIndex = 61;
            this.lblTitulo.Text = "Selecciona como deseas registrarte";
            this.lblTitulo.Click += new System.EventHandler(this.lblContraseña_Click);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnSalir);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(676, 50);
            this.pnlTitulo.TabIndex = 13;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitulo_Paint);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 278);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(676, 17);
            this.pnlPie.TabIndex = 65;
            this.pnlPie.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPie_Paint);
            // 
            // lblRedireccion
            // 
            this.lblRedireccion.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.lblRedireccion.AutoSize = true;
            this.lblRedireccion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedireccion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            this.lblRedireccion.Location = new System.Drawing.Point(274, 259);
            this.lblRedireccion.Name = "lblRedireccion";
            this.lblRedireccion.Size = new System.Drawing.Size(122, 16);
            this.lblRedireccion.TabIndex = 69;
            this.lblRedireccion.TabStop = true;
            this.lblRedireccion.Text = "Ya tengo una cuenta";
            this.lblRedireccion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRedireccion_LinkClicked);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCliente.ImageKey = "comprador.png";
            this.btnCliente.ImageList = this.IlRegistroEleccion;
            this.btnCliente.Location = new System.Drawing.Point(29, 84);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(293, 146);
            this.btnCliente.TabIndex = 68;
            this.btnCliente.Text = "Deseo comprar";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEmpresa.ImageKey = "empresa.png";
            this.btnEmpresa.ImageList = this.IlRegistroEleccion;
            this.btnEmpresa.Location = new System.Drawing.Point(356, 84);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(293, 146);
            this.btnEmpresa.TabIndex = 67;
            this.btnEmpresa.Text = "Deseo vender";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(611, 21);
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
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.Close_Icon;
            this.btnSalir.Location = new System.Drawing.Point(643, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(16, 16);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSalir.TabIndex = 64;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FrmRegistroEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(676, 295);
            this.Controls.Add(this.lblRedireccion);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroEleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Eleccion";
            this.Load += new System.EventHandler(this.FrmRegistroEleccion_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList IlRegistroEleccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.LinkLabel lblRedireccion;
    }
}