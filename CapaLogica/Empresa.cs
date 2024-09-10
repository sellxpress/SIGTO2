using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class Empresa
    {
        private string rut;
        private string nombre;
        private string correo;
        private string contra;
        private string nroventas;
        private string logo;
        private string descripcion;

        public Empresa(string rut, string nombre, string correo, string contra, string nroventas, string logo, string descripcion)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.correo = correo;
            this.contra = contra;
            this.nroventas = nroventas;
            this.logo = logo;
            this.descripcion = descripcion;
        }
         public void insertarEmpresa()
        {
            EmpresaDTO eDto = MapearEmpresaDTO();
            Datos d = new Datos();
            int filas = d.insertarEmpresa(eDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public EmpresaDTO MapearEmpresaDTO()
        {
            EmpresaDTO eDTO = new EmpresaDTO(this.rut, this.nombre, this.correo, this.contra, this.nroventas, this.logo, this.descripcion);
            return eDTO;
          
        }
    }
}
