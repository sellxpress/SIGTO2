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
        public Carrito()
        { }
        public void InsertarOActualizarCarrito(int idCliente, int cantidadArticulos, decimal montoTotal, int idArticulo)
        {
            CarritoDTO cDto = new CarritoDTO(idCliente, cantidadArticulos, montoTotal, idArticulo);
            Datos d = new Datos();
            int filas = d.InsertarOActualizarCarrito(cDto);
            if (filas > 0)
            {

            }
            else
            {

            }
        }
        public CarritoDTO MapearCarritoDTO()
        {
            CarritoDTO cDTO = new CarritoDTO(this.idcliente, this.cantidadarticulos,  this.montototal, this.idarticulo);
            return cDTO;

        }
    }
}