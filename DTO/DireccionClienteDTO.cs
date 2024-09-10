using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace CapaLogica
{
    public class DireccionClienteDTO
    {
        private string idcliente;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;
        private string referencia;

        public DireccionClienteDTO(string idcliente, string calle, string numero, string localidad, string departamento, string referencia)
        {
            this.idcliente = idcliente;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
            this.referencia = referencia;
        }
    }
}