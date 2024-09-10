using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class Valoracion
    {
        private string idvaloracion;
        private string calificacion;
        private string comentario;
        private string idarticulo;
        private string idcliente;
   
        public Valoracion(string idvaloracion, string calificacion, string comentario, string idarticulo, string idcliente)
        {
            this.idvaloracion = idvaloracion;
            this.calificacion = calificacion;
            this.comentario = comentario;
            this.idarticulo = idarticulo;
            this.idcliente = idcliente;
        }
        public void insertarValoracion()
        {
            ValoracionDTO vDto = MapearValoracionDTO();
            Datos d = new Datos();
            int filas = d.insertarValoracion(vDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public ValoracionDTO MapearValoracionDTO()
        {
            ValoracionDTO vDTO = new ValoracionDTO(this.idvaloracion, this.calificacion, this.comentario, this.idarticulo, this.idcliente);
            return vDTO;

        }
    }
}
