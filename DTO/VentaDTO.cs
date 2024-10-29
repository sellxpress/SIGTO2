using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
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

        public int Idventa { get { return this.idventa; } }
        public string Estado { get { return this.estado; } }
        public DateTime Fechayhora { get { return this.fechayhora; } }
        public decimal Importefinal { get { return this.importefinal; } }
        public decimal Importetotal { get { return this.importetotal; } }
        public int Descuento { get { return this.descuento; } }
        public decimal Costoenvio { get { return this.costoenvio; } }
        public int Idcliente { get { return this.idcliente; } }
        public int Idpickup { get { return this.idpickup; } }
    }
}
