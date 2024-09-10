using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class PickupDTO
    {
        private string idpickup;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;

        public PickupDTO(string idpickup, string calle, string numero, string localidad, string departamento)
        {
            this.idpickup = idpickup;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
        }
    }
}
