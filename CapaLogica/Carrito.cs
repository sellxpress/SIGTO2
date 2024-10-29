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
        private int idcliente;
        private int cantidadarticulos;
        private decimal montototal;
        private int idarticulo;

        public Carrito(int idcliente, int cantidadarticulos, decimal montototal, int idarticulo)
        {
            this.idcliente = idcliente;
            this.cantidadarticulos = cantidadarticulos;
            this.montototal = montototal;
            this.idarticulo = idarticulo;
         
        }
        public void insertarCarrito()
        {
            CarritoDTO cDto = MapearCarritoDTO();
            Datos d = new Datos();
              int filas = d.InsertarCarrito(cDto);
               if (filas > 0)
              {
                  //Se logro la consulta
              } 
              else
              {
                  //No se logro
              } 
        }
        public CarritoDTO MapearCarritoDTO()
        {
            CarritoDTO cDTO = new CarritoDTO(this.idcliente, this.cantidadarticulos,  this.montototal, this.idarticulo);
            return cDTO;

        }
    }
}