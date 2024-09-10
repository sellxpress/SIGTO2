using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class Venta
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

        public Venta(string idventa, string estado, string fechayhora, string importefinal, string importetotal, string descuento, string costoenvio, string idcliente, string idpickup)
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
        public void insertarVenta()
        {
            VentaDTO vDto = MapearVentaDTO();
            Datos d = new Datos();
            int filas = d.insertarVenta(vDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public VentaDTO MapearVentaDTO()
        {
            VentaDTO vDTO = new VentaDTO(this.idventa, this.estado, this.fechayhora, this.importefinal, this.importetotal, this.descuento, this.costoenvio,this.idcliente,this.idpickup);
            return vDTO;

        }
    }
}
