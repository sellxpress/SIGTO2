using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace CapaLogica
{
    public class Administrador
    {
        private string personacorreo;
        private int idadministrador;
        public Administrador(string personacorreo, int idadministrador)
        {
            this.personacorreo = personacorreo;
            this.idadministrador = idadministrador;
        }
        public AdministradorDTO MapearAdministradorDTO()
        {
            AdministradorDTO aDTO = new AdministradorDTO(this.personacorreo, this.idadministrador);
            return aDTO;

        }
    }
}
