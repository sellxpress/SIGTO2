using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;


namespace CapaLogica
{
    public class Carrito
    {
        private string idcliente;
        private string cantidadartciulos;
        private string montototal;
        private string idarticulo;

        public Carrito(string idcliente, string cantidadartciulos, string montototal, string idarticulo)
        {
            this.idcliente = idcliente;
            this.cantidadartciulos = cantidadartciulos;
            this.montototal = montototal;
            this.idarticulo = idarticulo;
         
        }
        public void insertarCarrito()
        {
            CarritoDTO cDto = MapearCarritoDTO();
            Datos d = new Datos();
            /*  int filas = d.insertarCarrito(cDto);
               if (filas > 0)
              {
                  //Se logro la consulta
              } 
              else
              {
                  //No se logro
              } */
        }
        public CarritoDTO MapearCarritoDTO()
        {
            CarritoDTO cDTO = new CarritoDTO(this.idcliente, this.cantidadartciulos,  this.montototal, this.idarticulo);
            return cDTO;

        }
    }
}