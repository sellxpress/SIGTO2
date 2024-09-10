using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ValoracionDTO
    {
        private string idvaloracion;
        private string calificacion;
        private string comentario;
        private string idarticulo;
        private string idcliente;

        public ValoracionDTO(string idvaloracion, string calificacion, string comentario, string idarticulo, string idcliente)
        {
            this.idvaloracion = idvaloracion;
            this.calificacion = calificacion;
            this.comentario = comentario;
            this.idarticulo = idarticulo;
            this.idcliente = idcliente;
        }
    }
}