using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

/*namespace CapaLogica
{
    public class VentaDetalle
    {
        private string idventadetalle;
        private string preciounitario;
        private string nroarticulos;
        private string idventa;
        private string idarticulo;

        public VentaDetalle(string idventadetalle, string preciounitario, string nroarticulos, string idventa, string idarticulo)
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
            int filas = d.insertarVentaDetalle(vDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public VentaDetalleDTO MapearVentaDetalleDTO()
        {
            VentaDetalleDTO vDTO = new VentaDetalleDTO( this.idventadetalle, this.preciounitario, this.nroarticulos, this.idventa, this.idarticulo);
            return vDTO;

        }
    }
}
*/