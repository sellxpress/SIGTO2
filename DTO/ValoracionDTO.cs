using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ValoracionDTO
    {
        private int idvaloracion;
        private string calificacion;
        private string comentario;
        private int idarticulo;
        private int idcliente;
        private string nombrearticulo;

        public ValoracionDTO(int idvaloracion, string calificacion, string comentario, int idarticulo, int idcliente)
        {
            this.idvaloracion = idvaloracion;
            this.calificacion = calificacion;
            this.comentario = comentario;
            this.idarticulo = idarticulo;
            this.idcliente = idcliente;
        }
        public ValoracionDTO(int idvaloracion, string calificacion, string comentario, string nombrearticulo, int idarticulo, int idcliente)
        {
            this.idvaloracion = idvaloracion;
            this.calificacion = calificacion;
            this.comentario = comentario;
            this.idarticulo = idarticulo;
            this.idcliente = idcliente;
            this.nombrearticulo = nombrearticulo;
        }
        public int Idvaloracion { get { return this.idvaloracion; } }
        public string Calificacion { get { return this.calificacion; } }
        public string Comentario { get { return this.comentario; } }
        public int Idarticulo { get { return this.idarticulo; } }
        public int Idcliente { get { return this.idcliente; } }
        public string NombreArticulo { get { return this.nombrearticulo; } }

    }
}