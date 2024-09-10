using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaDTO
    {
        private string idventa;
        private string estado;
        private string fechayhora;
        private string importefinal;
        private string importetotal;
        private string descuento;
        private string costoenvio;
        private string idcliente;
        private string idpickup;

        public VentaDTO(string idventa, string estado, string fechayhora, string importefinal, string importetotal, string descuento, string costoenvio, string idcliente, string idpickup)
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
    }
}
