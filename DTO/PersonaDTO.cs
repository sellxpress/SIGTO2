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
        public string Correo { get { return this.correo; } }
        public string Ci { get { return this.ci; } }
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string Contra { get { return this.contra; } }
        public string Fechanac { get { return this.fechanac; } }
        public string Nrocelular { get { return this.nrocelular; } }
        public string Foto { get { return this.foto; } }

    }
}
