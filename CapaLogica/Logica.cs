using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CapaDatos;

namespace CapaLogica
{
    public class Logica
    {
        private Datos datos;
        public Logica()
        {
            datos = new Datos();
        }
        public bool IniciarSesion(string correo, string contrasena, out string tipoUsuario)
        {
            tipoUsuario = datos.VerificarUsuario(correo, contrasena);
            return tipoUsuario != null;
        }

        public (string Nombre, string Apellido, string NombreEmpresa, string RutEmpresa, int? IdCliente) ObtenerInformacionUsuario(string correo, string tipoUsuario)
        {
            return datos.ObtenerInformacionUsuario(correo, tipoUsuario);
        }
        public List<ArticuloDTO> ObtenerArticulosPorCorreo(string correoEmpresa, string nombreArticulo)
        {
            // Llamar al método de la capa de datos
            return datos.ObtenerArticulosPorCorreo(correoEmpresa, nombreArticulo);
        }
        public bool EliminarArticulo(int idArticulo)
        {
            return datos.EliminarArticulo(idArticulo);
        }
        public EmpresaDTO ObtenerEmpresaPorCorreo(string correo)
        {
            return datos.ObtenerEmpresaPorCorreo(correo);
        }
        public List<ArticuloDTO> ObtenerTodosLosArticulos(string nombreArticulo)
        {
            return datos.ObtenerTodosLosArticulos(nombreArticulo);
        }
    }
}
