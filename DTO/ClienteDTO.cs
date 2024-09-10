using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClienteDTO
    {
        private string personacorreo;
        private string idcliente;
        private string nrocompras;

        public ClienteDTO(string personacorreo, string idcliente, string nrocompras)
        {
            this.personacorreo = personacorreo;
            this.idcliente = idcliente;
            this.nrocompras = nrocompras;
        }
    }
}
