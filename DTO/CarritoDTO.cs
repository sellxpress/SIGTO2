using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CarritoDTO
    {
        private string idcliente;
        private string cantidadartciulos;
        private string montototal;
        private string idarticulo;

        public CarritoDTO(string idcliente, string cantidadartciulos, string montototal, string idarticulo)
        {
            this.idcliente = idcliente;
            this.cantidadartciulos = cantidadartciulos;
            this.montototal = montototal;
            this.idarticulo = idarticulo;

        }
    }
}
