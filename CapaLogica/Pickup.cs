using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class Pickup
    {
        private int idpickup;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;

        public Pickup(int idpickup, string calle, string numero, string localidad, string departamento)
        {
            this.idpickup = idpickup;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
        }
    
        public PickupDTO MapearPickupDTO()
        {
            PickupDTO pDTO = new PickupDTO( this.idpickup, this.calle, this.numero, this.localidad, this.departamento);
            return pDTO;

        }
    }
}
