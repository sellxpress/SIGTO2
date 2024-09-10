using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
   public class PersonaDTO
    {
        private string correo;
        private string ci;
        private string nombre;
        private string apellido;
        private string contra;
        private string fechanac;
        private string nrocelular;
        private string foto;

        public PersonaDTO(string correo, string ci, string nombre, string apellido, string contra, string fechanac, string nrocelular, string foto)
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
    }
}
