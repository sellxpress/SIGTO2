using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AdministradorDTO
    {
        private string personacorreo;
        private int idadministrador;
        public AdministradorDTO(string personacorreo, int idadministrador)
        {
            this.personacorreo = personacorreo;
            this.idadministrador = idadministrador;
        }
        public string PersonaCorreo { get { return this.personacorreo; } }
        public int Idadministrador { get { return this.idadministrador; } }
    }
}
