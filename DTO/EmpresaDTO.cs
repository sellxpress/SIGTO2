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
       
    }
}
