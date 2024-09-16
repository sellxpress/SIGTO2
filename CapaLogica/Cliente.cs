using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


/*namespace CapaLogica
{
    public class Cliente
    {
        private string personacorreo;
        private string idcliente;
        private string nrocompras;

        public Cliente(string personacorreo, string idcliente, string nrocompras)
        {
            this.personacorreo = personacorreo;
            this.idcliente = idcliente;
            this.nrocompras = nrocompras;
        }
        public void insertarCliente()
        {
            ClienteDTO cDto = MapearClienteDTO();
            Datos d = new Datos();
            int filas = d.insertarCliente(cDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }
        }
        public ClienteDTO MapearClienteDTO()
        {
            ClienteDTO cDTO = new ClienteDTO(this.personacorreo, this.idcliente, this.nrocompras);
            return cDTO;

        }
    }
}
*/