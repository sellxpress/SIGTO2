using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class EmpresaDTO
    {
        private string rut;
        private string nombre;
        private string correo;
        private string contra;
        private string nroventas;
        private string logo;
        private string descripcion;

        public EmpresaDTO(string rut, string nombre, string correo,string contra,string nroventas,string logo,string descripcion)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.correo = correo;
            this.contra = contra;
            this.nroventas = nroventas;
            this.logo = logo;
            this.descripcion = descripcion;

        }

        public string Rut { get { return this.rut; } }
        public string Nombre { get { return this.nombre; } }
        public string Correo { get { return this.correo; } }
        public string Contra { get { return this.contra; } }
        public string Nroventas { get { return this.nroventas; } }
        public string Logo { get { return this.logo; } }
        public string Descripcion { get { return this.descripcion; } }



    }
}
