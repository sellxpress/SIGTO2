using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class Administrador
    {
        private string personacorreo;
        private string idadministrador;
        public Administrador(string personacorreo, string idadministrador)
        {
            this.personacorreo = personacorreo;
            this.idadministrador = idadministrador;
        }
        public void insertarAdministrador()
        {
            AdministradorDTO aDto = MapearAdministradorDTO();
            Datos d = new Datos();
            int filas = d.insertarAdministrador(aDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public AdministradorDTO MapearAdministradorDTO()
        {
            AdministradorDTO aDTO = new AdministradorDTO(this.personacorreo, this.idadministrador);
            return aDTO;

        }
    }
}