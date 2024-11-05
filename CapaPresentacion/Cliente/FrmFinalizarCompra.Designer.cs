
namespace CapaPresentacion
{
    partial class FrmFinalizarCompra
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.rbDomicilio = new System.Windows.Forms.RadioButton();
            this.rbPickup = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.gbEntrega = new System.Windows.Forms.GroupBox();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.rbAutoElectrico = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCostoFijo = new System.Windows.Forms.Label();
            this.lblAutoElectrico = new System.Windows.Forms.Label();
            this.lblAutoGasolina = new System.Windows.Forms.Label();
            this.lblErrorCarrito = new System.Windows.Forms.Label();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.lblErrorFecha1 = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.gbEntrega.SuspendLayout();
            this.gbAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlContenido.Controls.Add(this.lblErrorFecha1);
            this.pnlContenido.Controls.Add(this.lblErrorFecha);
            this.pnlContenido.Controls.Add(this.lblErrorCarrito);
            this.pnlContenido.Controls.Add(this.lblAutoGasolina);
            this.pnlContenido.Controls.Add(this.lblAutoElectrico);
            this.pnlContenido.Controls.Add(this.lblDireccion);
            this.pnlContenido.Controls.Add(this.lblCostoFijo);
            this.pnlContenido.Controls.Add(this.gbAuto);
            this.pnlContenido.Controls.Add(this.gbEntrega);
            this.pnlContenido.Controls.Add(this.label3);
            this.pnlContenido.Controls.Add(this.txtFecha);
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.txtDomicilio);
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Controls.Add(this.txtCVC);
            this.pnlContenido.Controls.Add(this.lblError);
            this.pnlContenido.Controls.Add(this.btnRealizarCompra);
            this.pnlContenido.Controls.Add(this.lblTarjeta);
            this.pnlContenido.Controls.Add(this.btnVolver);
            this.pnlContenido.Controls.Add(this.lblNombre);
            this.pnlContenido.Controls.Add(this.txtNroTarjeta);
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlContenido.Location = new System.Drawing.Point(0, 64);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(504, 458);
            this.pnlContenido.TabIndex = 9;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // rbDomicilio
            // 
            this.rbDomicilio.AutoSize = true;
            this.rbDomicilio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDomicilio.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDomicilio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.rbDomicilio.Location = new System.Drawing.Point(6, 10);
            this.rbDomicilio.Name = "rbDomicilio";
            this.rbDomicilio.Size = new System.Drawing.Size(173, 23);
            this.rbDomicilio.TabIndex = 103;
            this.rbDomicilio.TabStop = true;
            this.rbDomicilio.Text = "Envio a domicilio ($)";
            this.rbDomicilio.UseVisualStyleBackColor = true;
            this.rbDomicilio.CheckedChanged += new System.EventHandler(this.rbDomicilio_CheckedChanged);
            // 
            // rbPickup
            // 
            this.rbPickup.AutoSize = true;
            this.rbPickup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPickup.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPickup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.rbPickup.Location = new System.Drawing.Point(6, 39);
            this.rbPickup.Name = "rbPickup";
            this.rbPickup.Size = new System.Drawing.Size(144, 23);
            this.rbPickup.TabIndex = 102;
            this.rbPickup.TabStop = true;
            this.rbPickup.Text = "Retiro en pickup";
            this.rbPickup.UseVisualStyleBackColor = true;
            this.rbPickup.CheckedChanged += new System.EventHandler(this.rbPickup_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "MM/AA";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtFecha.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(17, 167);
            this.txtFecha.MaxLength = 50;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(182, 21);
            this.txtFecha.TabIndex = 95;
            this.txtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFecha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtDomicilio.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(251, 43);
            this.txtDomicilio.MaxLength = 50;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(182, 21);
            this.txtDomicilio.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(247, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "CVC";
            // 
            // txtCVC
            // 
            this.txtCVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtCVC.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.Location = new System.Drawing.Point(251, 103);
            this.txtCVC.MaxLength = 4;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(182, 21);
            this.txtCVC.TabIndex = 91;
            this.txtCVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVC_KeyPress);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.lblError.Location = new System.Drawing.Point(14, 438);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(452, 16);
            this.lblError.TabIndex = 89;
            this.lblError.Text = "Debe rellenar todos los campos y seleccionar las opciones correspondientes";
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(116)))));
            this.btnRealizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarCompra.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRealizarCompra.Location = new System.Drawing.Point(252, 395);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(204, 40);
            this.btnRealizarCompra.TabIndex = 72;
            this.btnRealizarCompra.Text = "Realizar Compra";
            this.btnRealizarCompra.UseVisualStyleBackColor = false;
            this.btnRealizarCompra.Click += new System.EventHandler(this.btnRealizarCompra_Click);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblTarjeta.Location = new System.Drawing.Point(13, 81);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(142, 19);
            this.lblTarjeta.TabIndex = 55;
            this.lblTarjeta.Text = "Numero de tarjeta";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnVolver.Location = new System.Drawing.Point(19, 395);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(204, 40);
            this.btnVolver.TabIndex = 69;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblNombre.Location = new System.Drawing.Point(14, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 19);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "Nombre del titular";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtNroTarjeta.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroTarjeta.Location = new System.Drawing.Point(17, 103);
            this.txtNroTarjeta.MaxLength = 16;
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(182, 21);
            this.txtNroTarjeta.TabIndex = 60;
            this.txtNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtNombre.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(17, 43);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 21);
            this.txtNombre.TabIndex = 50;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo1);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnSalir);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(504, 64);
            this.pnlTitulo.TabIndex = 7;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo1.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(116)))));
            this.lblTitulo1.Location = new System.Drawing.Point(84, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo1.Size = new System.Drawing.Size(323, 48);
            this.lblTitulo1.TabIndex = 81;
            this.lblTitulo1.Text = "Finalizar compra";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.IconoMinimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(443, 29);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 65;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.IconoCerrar;
            this.btnSalir.Location = new System.Drawing.Point(476, 29);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(16, 16);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSalir.TabIndex = 66;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbEntrega
            // 
            this.gbEntrega.Controls.Add(this.rbDomicilio);
            this.gbEntrega.Controls.Add(this.rbPickup);
            this.gbEntrega.Location = new System.Drawing.Point(18, 210);
            this.gbEntrega.Name = "gbEntrega";
            this.gbEntrega.Size = new System.Drawing.Size(181, 68);
            this.gbEntrega.TabIndex = 104;
            this.gbEntrega.TabStop = false;
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.rbAutoElectrico);
            this.gbAuto.Controls.Add(this.rbAuto);
            this.gbAuto.Location = new System.Drawing.Point(17, 284);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Size = new System.Drawing.Size(180, 68);
            this.gbAuto.TabIndex = 105;
            this.gbAuto.TabStop = false;
            // 
            // rbAutoElectrico
            // 
            this.rbAutoElectrico.AutoSize = true;
            this.rbAutoElectrico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAutoElectrico.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutoElectrico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.rbAutoElectrico.Location = new System.Drawing.Point(6, 10);
            this.rbAutoElectrico.Name = "rbAutoElectrico";
            this.rbAutoElectrico.Size = new System.Drawing.Size(156, 23);
            this.rbAutoElectrico.TabIndex = 103;
            this.rbAutoElectrico.TabStop = true;
            this.rbAutoElectrico.Text = "Vehiculo electrico";
            this.rbAutoElectrico.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAuto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.rbAuto.Location = new System.Drawing.Point(6, 39);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(167, 23);
            this.rbAuto.TabIndex = 102;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Vehiculo a gasolina";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDireccion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(116)))));
            this.lblDireccion.Location = new System.Drawing.Point(210, 256);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDireccion.Size = new System.Drawing.Size(115, 16);
            this.lblDireccion.TabIndex = 82;
            this.lblDireccion.Text = "Av Libertador 1234";
            // 
            // lblCostoFijo
            // 
            this.lblCostoFijo.AutoSize = true;
            this.lblCostoFijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCostoFijo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoFijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblCostoFijo.Location = new System.Drawing.Point(210, 225);
            this.lblCostoFijo.Name = "lblCostoFijo";
            this.lblCostoFijo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCostoFijo.Size = new System.Drawing.Size(205, 16);
            this.lblCostoFijo.TabIndex = 106;
            this.lblCostoFijo.Text = "Costo fijo sin importar tu ubicacion";
            // 
            // lblAutoElectrico
            // 
            this.lblAutoElectrico.AutoSize = true;
            this.lblAutoElectrico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAutoElectrico.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoElectrico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblAutoElectrico.Location = new System.Drawing.Point(210, 288);
            this.lblAutoElectrico.Name = "lblAutoElectrico";
            this.lblAutoElectrico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAutoElectrico.Size = new System.Drawing.Size(109, 64);
            this.lblAutoElectrico.TabIndex = 108;
            this.lblAutoElectrico.Text = "Vehiculo electrico\r\n- Costo ($100)\r\n- Contaminacion\r\n+ Demora";
            // 
            // lblAutoGasolina
            // 
            this.lblAutoGasolina.AutoSize = true;
            this.lblAutoGasolina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAutoGasolina.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoGasolina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblAutoGasolina.Location = new System.Drawing.Point(341, 288);
            this.lblAutoGasolina.Name = "lblAutoGasolina";
            this.lblAutoGasolina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAutoGasolina.Size = new System.Drawing.Size(118, 64);
            this.lblAutoGasolina.TabIndex = 109;
            this.lblAutoGasolina.Text = "Vehiculo a gasolina\r\n+ Costo ($200)\r\n+ Contaminacion\r\n- Demora";
            // 
            // lblErrorCarrito
            // 
            this.lblErrorCarrito.AutoSize = true;
            this.lblErrorCarrito.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.lblErrorCarrito.Location = new System.Drawing.Point(45, 374);
            this.lblErrorCarrito.Name = "lblErrorCarrito";
            this.lblErrorCarrito.Size = new System.Drawing.Size(145, 18);
            this.lblErrorCarrito.TabIndex = 110;
            this.lblErrorCarrito.Text = "Su carrito esta vacio";
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.lblErrorFecha.Location = new System.Drawing.Point(14, 189);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(237, 16);
            this.lblErrorFecha.TabIndex = 111;
            this.lblErrorFecha.Text = "El formato de fecha debe ser MM/AAAA.";
            // 
            // lblErrorFecha1
            // 
            this.lblErrorFecha1.AutoSize = true;
            this.lblErrorFecha1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFecha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.lblErrorFecha1.Location = new System.Drawing.Point(18, 189);
            this.lblErrorFecha1.Name = "lblErrorFecha1";
            this.lblErrorFecha1.Size = new System.Drawing.Size(137, 16);
            this.lblErrorFecha1.TabIndex = 112;
            this.lblErrorFecha1.Text = "La tarjeta ha caducado";
            // 
            // FrmFinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 522);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFinalizarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMiUsuarioDatos_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.gbEntrega.ResumeLayout(false);
            this.gbEntrega.PerformLayout();
            this.gbAuto.ResumeLayout(false);
            this.gbAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.RadioButton rbDomicilio;
        private System.Windows.Forms.RadioButton rbPickup;
        private System.Windows.Forms.GroupBox gbEntrega;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.RadioButton rbAutoElectrico;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label lblAutoGasolina;
        private System.Windows.Forms.Label lblAutoElectrico;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCostoFijo;
        private System.Windows.Forms.Label lblErrorCarrito;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.Label lblErrorFecha1;
    }
}