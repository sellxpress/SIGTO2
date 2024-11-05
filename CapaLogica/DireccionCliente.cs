using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using DTO;


namespace CapaLogica
{
    public class DireccionCliente
    {
        private Datos datos; 

        private int idcliente;
        private string calle;
        private string numero;
        private string localidad;
        private string departamento;
        private string referencia;

        public DireccionCliente(int idcliente, string calle, string numero, string localidad, string departamento, string referencia)
        {
            this.idcliente = idcliente;
            this.calle = calle;
            this.numero = numero;
            this.localidad = localidad;
            this.departamento = departamento;
            this.referencia = referencia;

            datos = new Datos();
        }
        public DireccionCliente()
        {   datos = new Datos(); }
        public void GuardarDireccionCliente()
        {
            DireccionClienteDTO direccionClienteDTO = MapearDireccionClienteDTO();
            datos.GuardarDireccionCliente(direccionClienteDTO);
        }

        public DireccionClienteDTO MapearDireccionClienteDTO()
        {
            DireccionClienteDTO dDTO = new DireccionClienteDTO(this.idcliente, this.calle, this.numero, this.localidad, this.departamento, this.referencia);
            return dDTO;
        }
    }
}
