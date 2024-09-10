using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public  class AnuncioDTO
    {
        private string idanuncio;
        private string nombre;
        private string fechainicio;
        private string fechafin;
        private string descuento;
        private string imagen;
        private string empresarut;

        public AnuncioDTO(string idanuncio, string nombre, string fechainicio, string fechafin, string descuento, string imagen, string empresarut)
        {
            this.idanuncio = idanuncio;
            this.nombre = nombre;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
            this.descuento = descuento;
            this.imagen = imagen;
            this.empresarut = empresarut;
        }
    }
}
