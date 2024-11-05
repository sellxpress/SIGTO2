using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VentaDTO
    {
        private int idventa;
        private string estado;
        private DateTime fechayhora;
        private decimal importefinal;
        private decimal importetotal;
        private int descuento;
        private decimal costoenvio;
        private int idcliente;
        private int idpickup;
        string nombrecliente;
        string correocliente;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;
        private string referencia;

        public VentaDTO(int idventa, string estado, DateTime fechayhora, decimal importefinal, decimal importetotal, int descuento, decimal costoenvio, int idcliente, int idpickup)
        {
            this.idventa = idventa;
            this.estado = estado;
            this.fechayhora = fechayhora;
            this.importefinal = importefinal;
            this.importetotal = importetotal;
            this.descuento = descuento;
            this.costoenvio = costoenvio;
            this.idcliente = idcliente;
            this.idpickup = idpickup;
        }
        public VentaDTO(string estado, DateTime fechayhora, decimal importefinal, decimal importetotal, int descuento, decimal costoenvio, int idcliente, int idpickup)
        {
            this.estado = estado;
            this.fechayhora = fechayhora;
            this.importefinal = importefinal;
            this.importetotal = importetotal;
            this.descuento = descuento;
            this.costoenvio = costoenvio;
            this.idcliente = idcliente;
            this.idpickup = idpickup;
        }
        public VentaDTO(int idventa,string estado, DateTime fechayhora, decimal importefinal, decimal importetotal, int descuento, decimal costoenvio,string nombrecliente,string correocliente, int idcliente, string calle, string numero, string localidad, string departamento, string referencia)
        {
            this.idventa = idventa;
            this.estado = estado;
            this.fechayhora = fechayhora;
            this.importefinal = importefinal;
            this.importetotal = importetotal;
            this.descuento = descuento;
            this.costoenvio = costoenvio;
            this.idcliente = idcliente;
            this.nombrecliente = nombrecliente;
            this.correocliente = correocliente;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
            this.referencia = referencia;
        }
        public VentaDTO(int idventa, string estado, DateTime fechayhora, decimal importefinal, decimal importetotal, int descuento, decimal costoenvio, string nombrecliente, string correocliente, int idcliente)
        {
            this.idventa = idventa;
            this.estado = estado;
            this.fechayhora = fechayhora;
            this.importefinal = importefinal;
            this.importetotal = importetotal;
            this.descuento = descuento;
            this.costoenvio = costoenvio;
            this.idcliente = idcliente;
            this.nombrecliente = nombrecliente;
            this.correocliente = correocliente;
        }

        public int Idventa { get { return this.idventa; } }
        public string Estado { get { return this.estado; } }
        public DateTime Fechayhora { get { return this.fechayhora; } }
        public decimal Importefinal { get { return this.importefinal; } }
        public decimal Importetotal { get { return this.importetotal; } }
        public int Descuento { get { return this.descuento; } }
        public decimal Costoenvio { get { return this.costoenvio; } }
        public int Idcliente { get { return this.idcliente; } }
        public int Idpickup { get { return this.idpickup; } }
        public string NombreCliente { get { return this.nombrecliente; } }
        public string CorreoCliente { get { return this.correocliente; } }
        public string Calle { get { return this.calle; } }
        public string Numero { get { return this.numero; } }
        public string Localidad { get { return this.localidad; } }
        public string Departamento { get { return this.departamento; } }
        public string Referencia { get { return this.referencia; } }


    }
}
