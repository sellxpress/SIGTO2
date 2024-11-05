using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CarritoDTO
    {
        private int idcliente;
        private int cantidadarticulos;
        private decimal montototal;
        private int idarticulo;
        private string nombre;
        private decimal precio;
        private int stock;

        public CarritoDTO(int idcliente, int cantidadarticulos, decimal montototal, int idarticulo)
        {
            this.idcliente = idcliente;
            this.cantidadarticulos = cantidadarticulos;
            this.montototal = montototal;
            this.idarticulo = idarticulo;
        }
        public  CarritoDTO(int idcliente, int idarticulo, string nombre, decimal precio, int cantidadarticulos, decimal montototal,int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.idcliente = idcliente;
            this.cantidadarticulos = cantidadarticulos;
            this.montototal = montototal;
            this.idarticulo = idarticulo;
        }
        public int IdCliente { get { return this.idcliente; } }
        public int Cantidadarticulos { get { return this.cantidadarticulos; } }
        public decimal Montotal { get { return this.montototal; } }
        public int Idarticulo { get { return this.idarticulo; } }
        public int Stock { get { return this.stock; } }
        public decimal Precio { get { return this.precio; } }
        public string Nombre { get { return this.nombre; } }

    }
}
