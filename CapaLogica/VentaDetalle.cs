using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class VentaDetalle
    {
        private int idventadetalle;
        private decimal preciounitario;
        private int nroarticulos;
        private int idventa;
        private int idarticulo;

        public VentaDetalle(int idventadetalle, decimal preciounitario, int nroarticulos, int idventa, int idarticulo)
        {
            this.idventadetalle = idventadetalle;
            this.preciounitario = preciounitario;
            this.nroarticulos = nroarticulos;
            this.idventa = idventa;
            this.idarticulo = idarticulo;

        }
        public void insertarVentaDetalle()
        {
            VentaDetalleDTO vDto = MapearVentaDetalleDTO();
            Datos d = new Datos();
            /* int filas = d.insertarVentaDetalle(vDto);
             if (filas > 0)
             {
                 //Se logro la consulta
             }
             else
             {
                 //No se logro
             }*/
        }
        public VentaDetalleDTO MapearVentaDetalleDTO()
        {
            VentaDetalleDTO vDTO = new VentaDetalleDTO( this.idventadetalle, this.preciounitario, this.nroarticulos, this.idventa, this.idarticulo);
            return vDTO;

        }
    }
}
