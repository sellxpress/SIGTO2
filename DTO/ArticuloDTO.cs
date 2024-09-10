using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
   public  class ArticuloDTO
    {
        private string idarticulo;
        private string nombre;
        private string categoria;
        private string precio;
        private string stock;
        private string estado;
        private string imagen;
        private string descripcion;
        private string empresarut;

        public ArticuloDTO(string idarticulo, string nombre, string categoria, string precio, string stock, string estado, string imagen, string descripcion, string empresarut)
        {
            this.idarticulo = idarticulo;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.estado = estado;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.empresarut = empresarut;
        }
    }
}
