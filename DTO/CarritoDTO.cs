using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CarritoDTO
    {
        private int idcliente;
        private int cantidadarticulos;
        private decimal montototal;
        private int idarticulo;

        public CarritoDTO(int idcliente, int cantidadarticulos, decimal montototal, int idarticulo)
        {
            this.idcliente = idcliente;
            this.cantidadarticulos = cantidadarticulos;
            this.montototal = montototal;
            this.idarticulo = idarticulo;
        }
        public int IdCliente { get { return this.idcliente; } }
        public int Cantidadarticulos { get { return this.cantidadarticulos; } }
        public decimal Montotal { get { return this.montototal; } }
        public int Idarticulo { get { return this.idarticulo; } }

    }
}
