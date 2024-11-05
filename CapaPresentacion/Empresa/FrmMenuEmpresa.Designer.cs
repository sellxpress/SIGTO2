
namespace CapaPresentacion
{
    partial class FrmMenuEmpresa

    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEmpresa));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblMiEmpresa = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.ilPrincipalEmpresa = new System.Windows.Forms.ImageList(this.components);
            this.btnMiEmpresa = new System.Windows.Forms.Button();
            this.btnPromociones = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.lblTitulo1);
            this.pnlTitulo.Controls.Add(this.btnSalir);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1228, 70);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lblTitulo.Location = new System.Drawing.Point(478, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(109, 58);
            this.lblTitulo.TabIndex = 77;
            this.lblTitulo.Text = "Sell";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.IconoMinimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1178, 31);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 67;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(116)))));
            this.lblTitulo1.Location = new System.Drawing.Point(576, 12);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo1.Size = new System.Drawing.Size(174, 58);
            this.lblTitulo1.TabIndex = 78;
            this.lblTitulo1.Text = "Xpress";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.IconoCerrar;
            this.btnSalir.Location = new System.Drawing.Point(1200, 31);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(16, 16);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSalir.TabIndex = 68;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlPie.Controls.Add(this.lblInfo);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 325);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(1228, 50);
            this.pnlPie.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblInfo.Location = new System.Drawing.Point(509, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInfo.Size = new System.Drawing.Size(142, 29);
            this.lblInfo.TabIndex = 73;
            this.lblInfo.Text = "Informacion";
            this.lblInfo.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlContenido.Controls.Add(this.lblCerrarSesion);
            this.pnlContenido.Controls.Add(this.lblMiEmpresa);
            this.pnlContenido.Controls.Add(this.lblPedidos);
            this.pnlContenido.Controls.Add(this.lblProductos);
            this.pnlContenido.Controls.Add(this.lblVentas);
            this.pnlContenido.Controls.Add(this.lblPromociones);
            this.pnlContenido.Controls.Add(this.btnCerrarSesion);
            this.pnlContenido.Controls.Add(this.btnMiEmpresa);
            this.pnlContenido.Controls.Add(this.btnPromociones);
            this.pnlContenido.Controls.Add(this.btnVentas);
            this.pnlContenido.Controls.Add(this.btnPedidos);
            this.pnlContenido.Controls.Add(this.btnProductos);
            this.pnlContenido.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlContenido.Location = new System.Drawing.Point(0, 70);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1228, 255);
            this.pnlContenido.TabIndex = 3;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(116)))));
            this.lblCerrarSesion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCerrarSesion.Location = new System.Drawing.Point(1042, 192);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCerrarSesion.Size = new System.Drawing.Size(111, 19);
            this.lblCerrarSesion.TabIndex = 79;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // lblMiEmpresa
            // 
            this.lblMiEmpresa.AutoSize = true;
            this.lblMiEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblMiEmpresa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMiEmpresa.Location = new System.Drawing.Point(836, 192);
            this.lblMiEmpresa.Name = "lblMiEmpresa";
            this.lblMiEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMiEmpresa.Size = new System.Drawing.Size(95, 19);
            this.lblMiEmpresa.TabIndex = 78;
            this.lblMiEmpresa.Text = "Mi Empresa";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPedidos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPedidos.Location = new System.Drawing.Point(225, 192);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPedidos.Size = new System.Drawing.Size(66, 19);
            this.lblPedidos.TabIndex = 77;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductos.Location = new System.Drawing.Point(20, 192);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductos.Size = new System.Drawing.Size(83, 19);
            this.lblProductos.TabIndex = 76;
            this.lblProductos.Text = "Productos";
            this.lblProductos.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVentas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVentas.Location = new System.Drawing.Point(432, 192);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVentas.Size = new System.Drawing.Size(57, 19);
            this.lblVentas.TabIndex = 75;
            this.lblVentas.Text = "Ventas";
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPromociones.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromociones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPromociones.Location = new System.Drawing.Point(634, 192);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPromociones.Size = new System.Drawing.Size(105, 19);
            this.lblPromociones.TabIndex = 74;
            this.lblPromociones.Text = "Promociones";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(116)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.ImageKey = "Apagar.png";
            this.btnCerrarSesion.ImageList = this.ilPrincipalEmpresa;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1036, 45);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 173);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCs_Click);
            // 
            // ilPrincipalEmpresa
            // 
            this.ilPrincipalEmpresa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPrincipalEmpresa.ImageStream")));
            this.ilPrincipalEmpresa.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPrincipalEmpresa.Images.SetKeyName(0, "tienda1.png");
            this.ilPrincipalEmpresa.Images.SetKeyName(1, "Apagar.png");
            this.ilPrincipalEmpresa.Images.SetKeyName(2, "Promociones.png");
            this.ilPrincipalEmpresa.Images.SetKeyName(3, "Ventas.png");
            this.ilPrincipalEmpresa.Images.SetKeyName(4, "Pedidos.png");
            this.ilPrincipalEmpresa.Images.SetKeyName(5, "Productos.png");
            // 
            // btnMiEmpresa
            // 
            this.btnMiEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnMiEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiEmpresa.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMiEmpresa.ImageKey = "tienda1.png";
            this.btnMiEmpresa.ImageList = this.ilPrincipalEmpresa;
            this.btnMiEmpresa.Location = new System.Drawing.Point(830, 45);
            this.btnMiEmpresa.Name = "btnMiEmpresa";
            this.btnMiEmpresa.Size = new System.Drawing.Size(180, 173);
            this.btnMiEmpresa.TabIndex = 5;
            this.btnMiEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMiEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMiEmpresa.UseVisualStyleBackColor = false;
            this.btnMiEmpresa.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnPromociones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromociones.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromociones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPromociones.ImageKey = "Promociones.png";
            this.btnPromociones.ImageList = this.ilPrincipalEmpresa;
            this.btnPromociones.Location = new System.Drawing.Point(625, 45);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(180, 173);
            this.btnPromociones.TabIndex = 3;
            this.btnPromociones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPromociones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPromociones.UseVisualStyleBackColor = false;
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVentas.ImageKey = "Ventas.png";
            this.btnVentas.ImageList = this.ilPrincipalEmpresa;
            this.btnVentas.Location = new System.Drawing.Point(425, 45);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(180, 173);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPedidos.ImageKey = "Pedidos.png";
            this.btnPedidos.ImageList = this.ilPrincipalEmpresa;
            this.btnPedidos.Location = new System.Drawing.Point(218, 45);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(180, 173);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProductos.ImageKey = "Productos.png";
            this.btnProductos.ImageList = this.ilPrincipalEmpresa;
            this.btnProductos.Location = new System.Drawing.Point(12, 45);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(180, 173);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 375);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipalEmpresa_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.ImageList ilPrincipalEmpresa;
        private System.Windows.Forms.Button btnMiEmpresa;
        private System.Windows.Forms.Button btnPromociones;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblMiEmpresa;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblPromociones;
    }
}

