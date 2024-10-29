using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaLogica
{
    public class DireccionCliente
    {
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
        }
        public void insertarDireccionCliente()
        {
            DireccionClienteDTO dDto = MapearDireccionClienteDTO();
            Datos d = new Datos();
           /* int filas = d.insertarDireccionCliente(dDto);
            if (filas > 0)
            {
                //Se logro la consulta
            }
            else
            {
                //No se logro
            }*/
        }
        public DireccionClienteDTO MapearDireccionClienteDTO()
        {
            DireccionClienteDTO dDTO = new DireccionClienteDTO(this.idcliente, this.calle, this.numero, this.localidad, this.departamento, this.referencia);
            return dDTO;
        }
    }
}
