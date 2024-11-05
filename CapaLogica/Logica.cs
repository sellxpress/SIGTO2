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
            return datos.ObtenerArticulosPorCorreo(correoEmpresa, nombreArticulo);
        }
        public List<ArticuloDTO> ObtenerArticulosCompradosPorCliente(int idCliente)
        {
            return datos.ObtenerArticulosCompradosPorCliente(idCliente);
        }
        public List<VentaDTO> ObtenerVentasEnProcesoPorCorreoEmpresa(string correoEmpresa)
        {
            return datos.ObtenerVentasEnProcesoPorCorreoEmpresa(correoEmpresa);
                }
        public List<VentaDetalleDTO> ObtenerDetallesVentaPorCorreoEmpresa(string correoEmpresa, int idventa)
        {
            return datos.ObtenerDetallesVentaPorCorreoEmpresa(correoEmpresa, idventa);
        }
        public int CrearVenta(VentaDTO ventaDTO, List<CarritoDTO> articulosCarrito)
        {
            return datos.CrearVenta(ventaDTO, articulosCarrito);
        }
        public bool EliminarArticulo(int idArticulo)
        {
            return datos.EliminarArticulo(idArticulo);
        }
        public int EliminarCarritoCliente(int idcliente)
        {
            return datos.EliminarCarritoCliente(idcliente);
        }
        public EmpresaDTO ObtenerEmpresaPorCorreo(string correo)
        {
            return datos.ObtenerEmpresaPorCorreo(correo);
        }
        public PersonaDTO ObtenerPersonaPorCorreo(string correo)
        {
            return datos.ObtenerPersonaPorCorreo(correo);
        }
        public List<ArticuloDTO> ObtenerTodosLosArticulos(string nombreArticulo)
        {
            return datos.ObtenerTodosLosArticulos(nombreArticulo);
        }
        public DireccionClienteDTO ObtenerDireccionPorIdCliente(int idCliente)
        {
            return datos.ObtenerDireccionPorIdCliente(idCliente);
        }
        public List<PersonaDTO> ObtenerPersonasConIdCliente(string correoBusqueda)
        {
            return datos.ObtenerPersonasConIdCliente(correoBusqueda);
        }
        public List<EmpresaDTO> ObtenerEmpresasPorCorreo(string correoBusqueda)
        {
            return datos.ObtenerEmpresasPorCorreo(correoBusqueda);
        }
        public List<ValoracionDTO> ObtenerValoracionesPorCliente( int idCliente)
        {

            return datos.ObtenerValoracionesPorCliente(idCliente);
        }
        public int EliminarValoracion(int idValoracion)
        {
            return datos.EliminarValoracion(idValoracion);
        }
        public List<CarritoDTO> ObtenerArticulosDelCarrito(int idCliente)
        {
            return datos.ObtenerArticulosDelCarrito(idCliente);
        }
        public int ActualizarEstadoVenta(int idVenta, string nuevoEstado)
        {
            return datos.ActualizarEstadoVenta(idVenta, nuevoEstado);
        }
        public List<VentaDTO> ObtenerVentasPorCorreoEmpresa(string correoEmpresa)
        {
            return datos.ObtenerVentasPorCorreoEmpresa(correoEmpresa);
        }
        public List<AnuncioDTO> ObtenerAnunciosPorCorreoEmpresa(string correoEmpresa)
        {
            return datos.ObtenerAnunciosPorCorreoEmpresa(correoEmpresa);
        }
        public List<VentaDTO> ObtenerVentasPorClienteId(int idcliente)
        {
            return datos.ObtenerVentasPorClienteId(idcliente);
        }
        public int EliminarCarrito(int idArticulo)
        {
            return datos.EliminarCarrito(idArticulo);
        }
        public int EliminarAnuncio(int idAnuncio)
        {
            return datos.EliminarAnuncio(idAnuncio);
        }
        public int ActualizarCantidadCarrito(int idArticulo, int nuevaCantidad, decimal montotal)
        {
            return datos.ActualizarCantidadCarrito(idArticulo, nuevaCantidad, montotal);
            }
        }
}
