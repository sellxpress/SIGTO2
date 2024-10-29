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
        private int idcliente;
        private long nrocompras;

        public ClienteDTO(string personacorreo, int idcliente, long nrocompras)
        {
            this.personacorreo = personacorreo;
            this.idcliente = idcliente;
            this.nrocompras = nrocompras;
        }
        public string PersonaCorreo { get { return this.personacorreo; } }
        public int IdCliente { get { return this.idcliente; } }
        public long NroCompras { get { return this.nrocompras; } }
    }
}
