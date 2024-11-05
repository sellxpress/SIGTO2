using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;


namespace CapaLogica
{
    public class Anuncio
    {
        private int idanuncio;
        private string nombre;
        private DateTime fechainicio;
        private DateTime fechafin;
        private int descuento;
        private string imagen;
        private string empresarut;

        public Anuncio(int idanuncio, string nombre, DateTime fechainicio, DateTime fechafin, int descuento, string imagen, string empresarut)
        {
            this.idanuncio = idanuncio;
            this.nombre = nombre;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
            this.descuento = descuento;
            this.imagen = imagen;
            this.empresarut = empresarut;
        }
        public Anuncio()
        {

        }
        public void insertarAnuncio()
        {
            AnuncioDTO aDto = MapearAnuncioDTO();
            Datos d = new Datos();
            int filas = d.insertarAnuncio(aDto);
            if (filas > 0)
            {

            }
            else
            {

            }
        }
        public void actualizarAnuncio()
        {
            AnuncioDTO aDto = MapearAnuncioDTO();
            Datos d = new Datos();
            int filas = d.actualizarAnuncio(aDto,idanuncio);
            if (filas > 0)
            {

            }
            else
            {

            }
        }

        public AnuncioDTO MapearAnuncioDTO()
        {
            AnuncioDTO aDTO = new AnuncioDTO(this.idanuncio,this.nombre,this.fechainicio,this.fechafin,this.descuento,this.imagen,this.empresarut);
            return aDTO;

        }
    }
}
