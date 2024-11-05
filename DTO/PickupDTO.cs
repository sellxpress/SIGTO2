using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PickupDTO
    {
        private int idpickup;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;

        public PickupDTO(int idpickup, string calle, string numero, string localidad, string departamento)
        {
            this.idpickup = idpickup;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
        }
        public int Idpickup { get { return this.idpickup; } }
        public string Calle { get { return this.calle; } }
        public string Numero { get { return this.numero; } }
        public string Localidad { get { return this.localidad; } }
        public string Departamento { get { return this.departamento; } }

    }
}
