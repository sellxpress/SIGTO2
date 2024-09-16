using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
     public  class Persona
    {
        private string correo;
        private string ci;
        private string nombre;
        private string apellido;
        private string contra;
        private string fechanac;
        private string nrocelular;
        private string foto;


        public Persona(string correo, string ci, string nombre, string apellido, string contra, string fechanac, string nrocelular, string foto = "0")
        {
            this.correo = correo;
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contra = contra;
            this.fechanac = fechanac;
            this.nrocelular = nrocelular;
            this.foto = foto;
        }
        public void insertarPersona()
        {
            PersonaDTO pDto = MapearPersonaDTO();
            Datos d = new Datos();
            int filas = d.insertarPersona(pDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public PersonaDTO MapearPersonaDTO()
        {
            PersonaDTO pDTO = new PersonaDTO(this.correo, this.ci , this.nombre , this.apellido ,this.contra ,this.fechanac, this.nrocelular, this.foto);
            return pDTO;

        }
}
}