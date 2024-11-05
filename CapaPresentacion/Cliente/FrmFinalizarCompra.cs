using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CapaLogica;
using DTO;

namespace CapaPresentacion
{
    public partial class FrmFinalizarCompra : Form
    {
        int? idcliente;
        private List<CarritoDTO> carrito;
        public FrmFinalizarCompra()
        {
            InitializeComponent();
            // Ocultar las opciones de tipo de envío inicialmente
            gbAuto.Visible = false;
            lblAutoElectrico.Visible = false;
            lblAutoGasolina.Visible = false;
            // Asociar los eventos CheckedChanged a los radio buttons
            rbDomicilio.CheckedChanged += rbDomicilio_CheckedChanged;
            rbPickup.CheckedChanged += rbPickup_CheckedChanged;
            CargarCarrito();
        }
        private void CargarCarrito()
        {
            Logica logica = new Logica();
            string correo = Principal.principal.Correo;
            string tipoUsuario = "Cliente";
            var info = logica.ObtenerInformacionUsuario(correo, tipoUsuario);
            idcliente = info.IdCliente;
            carrito = logica.ObtenerArticulosDelCarrito(idcliente.Value);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCarrtitoC SellXpress = new FrmCarrtitoC();
            SellXpress.Show();
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        private void FrmMiUsuarioDatos_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblErrorCarrito.Visible = false;
            lblErrorFecha.Visible = false;
            lblErrorFecha1.Visible = false;
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCarrtitoC SellXpress = new FrmCarrtitoC();
            SellXpress.Show();
        }

        private void rbDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            gbAuto.Visible = rbDomicilio.Checked;
            lblAutoElectrico.Visible = true;
            lblAutoGasolina.Visible = true;
        }

        private void rbPickup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPickup.Checked)
            {
                gbAuto.Visible = false;
                lblAutoElectrico.Visible = false;
                lblAutoGasolina.Visible = false;
            }
        }
        private decimal CalcularTotalCompra()
        {
            decimal total = 0;

            // Asegúrate de que 'carrito' no sea nulo
            if (carrito != null)
            {
                foreach (var item in carrito)
                {
                    total += item.Montotal; // Asumiendo que 'MontoTotal' es una propiedad de CarritoDTO
                }
            }

            return total;
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            // Validar selección de opción de entrega
            if (!rbPickup.Checked && !rbDomicilio.Checked)
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

            if (rbDomicilio.Checked && !rbAutoElectrico.Checked && !rbAuto.Checked)
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

            // Validar el carrito
            if (carrito == null || carrito.Count == 0)
            {
                lblErrorCarrito.Visible = true;
                return;
            }
            else
            {
                lblErrorCarrito.Visible = false;
            }

            // Validar campos de pago
            if (string.IsNullOrWhiteSpace(txtCVC.Text) || string.IsNullOrWhiteSpace(txtNroTarjeta.Text) || string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
            // Validar formato de fecha
            if (!DateTime.TryParseExact(txtFecha.Text, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaCaducidad))
            {
                lblErrorFecha.Visible = true;
                return;
            }
            else
            {
                lblErrorFecha.Visible = false;
            }

            // Validar que la fecha no sea pasada
            if (fechaCaducidad < DateTime.Now)
            {
                lblErrorFecha1.Visible = true;
                return;
            }
            else
            {
                lblErrorFecha1.Visible = false;
            }

            // Calcular el total de la compra
            decimal importeTotal = CalcularTotalCompra();

            // Crear variables para los datos del objeto VentaDTO
            string estado = "Pendiente"; // o el estado que desees
            DateTime fechaYHora = DateTime.Now;

            // Inicializar el costo de envío
            decimal costoEnvio = 0;

            // Costo de envío dependiendo de la opción elegida
            if (rbDomicilio.Checked)
            {
                costoEnvio = rbAutoElectrico.Checked ? 100 : 200; // Costo para autos eléctricos o normales
            }

            // Inicializar el descuento
            decimal descuento = 0;

            // Verificar si hay un descuento aplicable por fecha festiva o comercial
            if (EsFechaFestiva(fechaYHora))
            {
                descuento = importeTotal * 0.10m; // 10% de descuento
                MessageBox.Show("Se ha aplicado un descuento del 10% por ser una fecha especial.");
            }

            // Calcular el importe final
            decimal importeFinal = importeTotal + costoEnvio - descuento;
            int idPickup = 1;

            try
            {
                // Crear el DTO con los valores establecidos
                VentaDTO ventaDTO = new VentaDTO(estado, fechaYHora, importeFinal, importeTotal, (int)descuento, costoEnvio, idcliente.Value, idPickup);

                // Crear venta
                Logica logica = new Logica();
                int idVenta = logica.CrearVenta(ventaDTO, carrito);

                MessageBox.Show($"Compra realizada con éxito");

                logica.EliminarCarritoCliente(idcliente.Value);

                this.Close();
                FrmCarrtitoC SellXpress = new FrmCarrtitoC();
                SellXpress.Show();
            }
            catch (Exception ex)
            {
            }
        }
        // Método para verificar si la fecha actual es festiva o comercial
        private bool EsFechaFestiva(DateTime fecha)
        {
            // Definir las fechas festivas
            var festividades = new List<DateTime>
    {
        new DateTime(fecha.Year, 10, 31), // Halloween
        new DateTime(fecha.Year, 12, 25), // Navidad
        new DateTime(fecha.Year, 1, 6),   // Reyes Magos
        new DateTime(fecha.Year, 1, 1),   // Año Nuevo
        new DateTime(fecha.Year, 2, 14),  // Día de San Valentín
        new DateTime(fecha.Year, 11, 24)  // Black Friday (cuarto viernes de noviembre, puede variar)
    };
            // Calcular la fecha de Black Friday (cuarto viernes de noviembre)
            DateTime blackFriday = new DateTime(fecha.Year, 11, 1).AddDays(21); // Comenzamos en noviembre 1
            blackFriday = blackFriday.AddDays((int)DayOfWeek.Friday - (int)blackFriday.DayOfWeek); // Lleva al primer viernes
            blackFriday = blackFriday.AddDays(21); // Lleva al cuarto viernes
            festividades.Add(blackFriday); // Agregar Black Friday a la lista
            // Agregar Cyber Monday (el lunes después del Black Friday)
            festividades.Add(blackFriday.AddDays(3));
            return festividades.Contains(fecha.Date);
        }

        private void txtNroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es un dígito
            }
            if (txtNroTarjeta.Text.Length >= 16 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si se supera el límite
            }
        }

        private void txtCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y controlar la longitud
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es un dígito
            }
            if ((txtCVC.Text.Length >= 4 && txtCVC.Text.Length != 3) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, barra (/) y controlar la longitud
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true; // Cancela la entrada si no es un dígito o barra
            }

            // Limitar a 7 caracteres (MM/AAAA)
            if (txtFecha.Text.Length >= 7 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si se supera el límite
            }
        }
    }
        }