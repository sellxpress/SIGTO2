using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
   public  class ArticuloDTO
    {
        private int idarticulo;
        private string nombre;
        private string categoria;
        private decimal precio;
        private int stock;
        private string estado;
        private string imagen;
        private string descripcion;
        private string empresarut;

        public ArticuloDTO(int idarticulo, string nombre, string categoria, decimal precio, int stock, string estado, string imagen, string descripcion, string empresarut)
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
        public ArticuloDTO(int idarticulo, string nombre, string categoria, decimal precio, int stock, string estado)
        {
            this.idarticulo = idarticulo;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.estado = estado;
        }

        public int Idarticulo { get { return this.idarticulo; } }
        public string Nombre { get { return this.nombre; } }
        public string Categoria { get { return this.categoria; } }
        public decimal Precio { get { return this.precio; } }
        public int Stock { get { return this.stock; } }
        public string Estado { get { return this.estado; } }
        public string Imagen { get { return this.imagen; } }
        public string Descripcion { get { return this.descripcion; } }
        public string Empresarut { get { return this.empresarut; } }
    }
}
