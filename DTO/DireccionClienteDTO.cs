using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTO
{
    public class DireccionClienteDTO
    {
        private int idcliente;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;
        private string referencia;

        public DireccionClienteDTO(int idcliente, string calle, string numero, string localidad, string departamento, string referencia)
        {
            this.idcliente = idcliente;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
            this.referencia = referencia;
        }
        public int Idcliente { get { return this.idcliente; } }
        public string Calle { get { return this.calle; } }
        public string Numero { get { return this.numero; } }
        public string Localidad { get { return this.localidad; } }
        public string Departamento { get { return this.departamento; } }
        public string Referencia { get { return this.referencia; } }

    }
}