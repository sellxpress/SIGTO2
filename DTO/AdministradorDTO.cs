using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;

namespace CapaLogica
{
    public class AdministradorDTO
    {
        private string personacorreo;
        private string idadministrador;
        public AdministradorDTO(string personacorreo, string idadministrador)
        {
            this.personacorreo = personacorreo;
            this.idadministrador = idadministrador;
        }
    }
}
