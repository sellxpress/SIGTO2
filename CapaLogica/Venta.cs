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
        private int idventa;
        private string estado;
        private DateTime fechayhora;
        private decimal importefinal;
        private decimal importetotal;
        private int descuento;
        private decimal costoenvio;
        private int idcliente;
        private int idpickup;

        public Venta(int idventa, string estado, DateTime fechayhora, decimal importefinal, decimal importetotal, int descuento, decimal costoenvio, int idcliente, int idpickup)
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
           /*  int filas = d.insertarVenta(vDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }  */
        }
        public VentaDTO MapearVentaDTO()
        {
            VentaDTO vDTO = new VentaDTO(this.idventa, this.estado, this.fechayhora, this.importefinal, this.importetotal, this.descuento, this.costoenvio,this.idcliente,this.idpickup);
            return vDTO;

        }
    }
}