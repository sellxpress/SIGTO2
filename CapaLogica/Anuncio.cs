using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    class Anuncio
    {
        private string idanuncio;
        private string nombre;
        private string fechainicio;
        private string fechafin;
        private string descuento;
        private string imagen;
        private string empresarut;

        public Anuncio(string idanuncio, string nombre, string fechainicio, string fechafin, string descuento, string imagen, string empresarut)
        {
            this.idanuncio = idanuncio;
            this.nombre = nombre;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
            this.descuento = descuento;
            this.imagen = imagen;
            this.empresarut = empresarut;
        }
        public void insertarAnuncio()
        {
            AnuncioDTO aDto = MapearAnuncioDTO();
            Datos d = new Datos();
            int filas = d.insertarAnuncio(aDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public AnuncioDTO MapearAnuncioDTO()
        {
            AnuncioDTO aDTO = new AnuncioDTO(this.idanuncio,this.nombre,this.fechainicio,this.fechafin,this.descuento,this.imagen,this.empresarut);
            return aDTO;

        }
    }
}