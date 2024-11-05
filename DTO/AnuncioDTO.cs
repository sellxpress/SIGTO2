using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class AnuncioDTO
    {
        private int idanuncio;
        private string nombre;
        private DateTime fechainicio;
        private DateTime fechafin;
        private int descuento;
        private string imagen;
        private string empresarut;

        public AnuncioDTO(int idanuncio, string nombre, DateTime fechainicio, DateTime fechafin, int descuento, string imagen, string empresarut)
        {
            this.idanuncio = idanuncio;
            this.nombre = nombre;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
            this.descuento = descuento;
            this.imagen = imagen;
            this.empresarut = empresarut;
        }
        public int Idanuncio { get { return this.idanuncio; } }
        public string Nombre { get { return this.nombre; } }
        public DateTime Fechainicio { get { return this.fechainicio; } }
        public DateTime Fechafin { get { return this.fechafin; } }
        public int Descuento { get { return this.descuento; } }
        public string Imagen { get { return this.imagen; } }
        public string Empresarut { get { return this.empresarut; } }
    }
}
