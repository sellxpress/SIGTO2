using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    class Articulo
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

            public Articulo(string idarticulo, string nombre, string categoria, string precio, string stock, string estado, string imagen, string descripcion, string empresarut)
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
            public void insertarArticulo()
            {
                ArticuloDTO aDto = MapearArticuloDTO();
                Datos d = new Datos();
                int filas = d.insertarArticulo(aDto);
                if (filas > 0)
                {
                    //Se logro la consulta
                }
                else
                {
                    //No se logro
                }
            }
            public ArticuloDTO MapearArticuloDTO()
            {
               ArticuloDTO aDTO = new ArticuloDTO(this.idarticulo,  this.nombre,  this.categoria,this.precio, this.stock,this.estado,  this.imagen,  this.descripcion,  this.empresarut);
                return aDTO;

            }
        }
}
