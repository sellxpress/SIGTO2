using MySqlConnector;
using DTO;
using CapaLogica;
using System;
using System.Collections.Generic;

namespace CapaDatos
{
    public class Datos
    {
        private string cadenaConexion = "server=localhost;database=ecommerce;uid=root;pwd=root;port=3306";

        public int insertarEmpresa(EmpresaDTO unaEmpresa)
        {
            int filasAfectadas = 0;
            try
            {

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO empresa values (@RUT,@Nombre,@Correo,@Contrasena,@NroVentas,@Logo,@Descripcion)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@RUT", unaEmpresa.Rut);
                        comando.Parameters.AddWithValue("@Nombre", unaEmpresa.Nombre);
                        comando.Parameters.AddWithValue("@Correo", unaEmpresa.Correo);
                        comando.Parameters.AddWithValue("@Contrasena", unaEmpresa.Contra);
                        comando.Parameters.AddWithValue("@NroVentas", unaEmpresa.Nroventas);
                        comando.Parameters.AddWithValue("@Logo", unaEmpresa.Logo);
                        comando.Parameters.AddWithValue("@Descripcion", unaEmpresa.Descripcion);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        } 
        public int insertarPersona(PersonaDTO unaPersona)
        {
            int filasAfectadas = 0;
            try
            {

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO persona values (@Correo,@CI,@Nombre,@Apellido,@Contrasena,@FechaNac,@NroCelular,@Foto)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", unaPersona.Correo);
                        comando.Parameters.AddWithValue("@CI", unaPersona.Ci);
                        comando.Parameters.AddWithValue("@Nombre", unaPersona.Nombre);
                        comando.Parameters.AddWithValue("@Apellido", unaPersona.Apellido);
                        comando.Parameters.AddWithValue("@Contrasena", unaPersona.Contra);
                        comando.Parameters.AddWithValue("@FechaNac", unaPersona.Fechanac);
                        comando.Parameters.AddWithValue("@NroCelular", unaPersona.Nrocelular);
                        comando.Parameters.AddWithValue("@Foto", unaPersona.Foto);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }
        public int insertarCliente(ClienteDTO unCliente)
        {
            int filasAfectadas = 0;
            try
            {

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO cliente (Persona_Correo, NroCompras) values (@Persona_Correo,@NroCompras)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Persona_Correo", unCliente.PersonaCorreo);
                        comando.Parameters.AddWithValue("@NroCompras", unCliente.NroCompras);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return filasAfectadas;
        }
        public int insertarAnuncio(AnuncioDTO unAnuncio)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO anuncio (Nombre, FechaInicio, FechaFin, Descuento, Imagen, Empresa_RUT) VALUES (@Nombre, @FechaInicio, @FechaFin, @Descuento, @Imagen, @Empresa_RUT)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unAnuncio.Nombre);
                        comando.Parameters.AddWithValue("@FechaInicio", unAnuncio.Fechainicio);
                        comando.Parameters.AddWithValue("@FechaFin", unAnuncio.Fechafin);
                        comando.Parameters.AddWithValue("@Descuento", unAnuncio.Descuento);
                        comando.Parameters.AddWithValue("@Imagen", unAnuncio.Imagen);
                        comando.Parameters.AddWithValue("@Empresa_RUT", unAnuncio.Empresarut);

                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }

        public string VerificarUsuario(string correo, string contrasena)
        {
            string tipoUsuario = null;
            string consulta = @"
    SELECT 
        CASE 
            WHEN EXISTS (SELECT 1 FROM cliente c JOIN Persona p ON c.Persona_Correo = p.Correo WHERE p.Correo = @correo AND BINARY p.Contrasena = @contrasena) THEN 'Cliente'
            WHEN EXISTS (SELECT 1 FROM administrador a JOIN Persona p ON a.Persona_Correo = p.Correo WHERE p.Correo = @correo AND BINARY p.Contrasena = @contrasena) THEN 'Administrador'
            WHEN EXISTS (SELECT 1 FROM empresa e WHERE e.Correo = @correo AND BINARY e.Contrasena = @contrasena) THEN 'Empresa'
            ELSE NULL 
        END AS TipoUsuario";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);
                        tipoUsuario = comando.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
            }

            return tipoUsuario;
        }
        public (string Nombre, string Apellido, string NombreEmpresa, string RutEmpresa, int? IdCliente) ObtenerInformacionUsuario(string correo, string tipoUsuario)
        {
            string consulta = string.Empty;
            // Determinar la consulta según el tipo de usuario
            if (tipoUsuario == "Cliente" || tipoUsuario == "Administrador")
            {
                consulta = @"
            SELECT p.Nombre, p.Apellido, c.IdCliente 
            FROM persona p
            JOIN Cliente c ON p.Correo = c.Persona_Correo 
            WHERE p.Correo = @correo"; // Unir con la tabla Cliente
            }
            else if (tipoUsuario == "Empresa")
            {
                consulta = "SELECT Nombre, RUT FROM Empresa WHERE Correo = @correo"; // Modificación para incluir el RUT
            }

            string nombre = null;
            string apellido = null;
            string nombreEmpresa = null;
            string rutEmpresa = null; // Variable para almacenar el RUT
            int? idCliente = null; // Variable para almacenar el ID del cliente

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@correo", correo);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (tipoUsuario == "Cliente" || tipoUsuario == "Administrador")
                                {
                                    nombre = reader["Nombre"].ToString();
                                    apellido = reader["Apellido"].ToString();
                                    idCliente = reader.IsDBNull(reader.GetOrdinal("IdCliente")) ? (int?)null : reader.GetInt32("IdCliente"); // Obtener IDCliente
                                }
                                else if (tipoUsuario == "Empresa")
                                {
                                    nombreEmpresa = reader["Nombre"].ToString();
                                    rutEmpresa = reader["RUT"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al obtener la información del usuario: " + ex.Message);
            }

            return (nombre, apellido, nombreEmpresa, rutEmpresa, idCliente);
        }
        public List<ArticuloDTO> ObtenerArticulosPorCorreo(string correoEmpresa, string nombreArticulo)
         {
             List<ArticuloDTO> listaArticulos = new List<ArticuloDTO>();
             string consulta = @"
         SELECT a.IdArticulo, a.Nombre, a.Categoria, a.Precio, a.Stock, a.Estado, a.Imagen, a.Descripcion, a.Empresa_RUT
         FROM articulo a
         INNER JOIN empresa e ON a.Empresa_RUT = e.RUT
         WHERE e.Correo = @Correo AND a.Nombre LIKE @Nombre";

             try
             {
                 using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                 {
                     conexion.Open();
                     using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                     {
                         comando.Parameters.AddWithValue("@Correo", correoEmpresa);
                         comando.Parameters.AddWithValue("@Nombre", "%" + nombreArticulo + "%");  // Para buscar por nombre

                         using (MySqlDataReader reader = comando.ExecuteReader())
                         {
                             while (reader.Read())
                             {
                                 int idarticulo = reader.GetInt32("IdArticulo");
                                 string nombre = reader.GetString("Nombre");
                                 string categoria = reader.GetString("Categoria");
                                 decimal precio = reader.GetDecimal("Precio");
                                 int stock = reader.GetInt32("Stock");
                                 string estado = reader.GetString("Estado");
                                 string imagen = reader.GetString("Imagen");
                                 string descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString("Descripcion");
                                 string empresarut = reader.GetString("Empresa_RUT");
                                 ArticuloDTO articulo = new ArticuloDTO(idarticulo, nombre, categoria, precio, stock, estado, imagen, descripcion, empresarut);
                                 listaArticulos.Add(articulo);
                             }
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
             }

             return listaArticulos;
         }
        public bool EliminarArticulo(int idArticulo)
        {
            string consulta = "DELETE FROM articulo WHERE IdArticulo = @IdArticulo";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdArticulo", idArticulo);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;  // Devuelve true si se eliminó algún registro
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el artículo: " + ex.Message);
                return false;  // En caso de error, devuelve false
            }
        }
         public int insertarArticulo(ArticuloDTO unArticulo)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO articulo (Nombre, Categoria, Precio, Stock, Estado, Imagen, Descripcion, Empresa_RUT) VALUES (@Nombre, @Categoria, @Precio, @Stock, @Estado, @Imagen, @Descripcion, @Empresa_RUT)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unArticulo.Nombre);
                        comando.Parameters.AddWithValue("@Categoria", unArticulo.Categoria);
                        comando.Parameters.AddWithValue("@Precio", unArticulo.Precio);
                        comando.Parameters.AddWithValue("@Stock", unArticulo.Stock);
                        comando.Parameters.AddWithValue("@Estado", unArticulo.Estado);
                        comando.Parameters.AddWithValue("@Imagen", unArticulo.Imagen);
                        comando.Parameters.AddWithValue("@Descripcion", unArticulo.Descripcion);
                        comando.Parameters.AddWithValue("@Empresa_RUT", unArticulo.Empresarut);  // Aquí usas el RUT de la empresa actual
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }
        public int actualizarArticulo(ArticuloDTO unArticulo)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE articulo SET Nombre = @Nombre, Categoria = @Categoria, Precio = @Precio, Stock = @Stock, Estado = @Estado, Imagen = @Imagen, Descripcion = @Descripcion, Empresa_RUT = @Empresa_RUT WHERE IdArticulo = @IdArticulo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unArticulo.Nombre);
                        comando.Parameters.AddWithValue("@Categoria", unArticulo.Categoria);
                        comando.Parameters.AddWithValue("@Precio", unArticulo.Precio);
                        comando.Parameters.AddWithValue("@Stock", unArticulo.Stock);
                        comando.Parameters.AddWithValue("@Estado", unArticulo.Estado);
                        comando.Parameters.AddWithValue("@Imagen", unArticulo.Imagen);
                        comando.Parameters.AddWithValue("@Descripcion", unArticulo.Descripcion);
                        comando.Parameters.AddWithValue("@Empresa_RUT", unArticulo.Empresarut);  
                        comando.Parameters.AddWithValue("@IdArticulo", unArticulo.Idarticulo);  // Asegúrate de que el ID esté presente en el objeto DTO
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }
        public EmpresaDTO ObtenerEmpresaPorCorreo(string correoEmpresa)
        {
            EmpresaDTO empresa = null;
            string consulta = @"
    SELECT e.RUT, e.Nombre, e.Correo, e.Contrasena, e.Nroventas, e.Logo, e.Descripcion
    FROM empresa e
    WHERE e.Correo = @Correo";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", correoEmpresa);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string rut = reader.GetString("RUT");
                                string nombre = reader.GetString("Nombre");
                                string correo = reader.GetString("Correo");
                                string contrasena = reader.GetString("Contrasena"); 
                                long nroVentas = reader.GetInt64("Nroventas");
                                string logo = reader.IsDBNull(reader.GetOrdinal("Logo")) ? null : reader.GetString("Logo");
                                string descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString("Descripcion");

                                // Comprobar si la contraseña es nula (opcional)
                                if (string.IsNullOrEmpty(contrasena))
                                {
                                    throw new Exception("La contraseña no puede ser nula o vacía.");
                                }

                                empresa = new EmpresaDTO(rut, nombre, correo, contrasena, nroVentas, logo, descripcion);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la empresa: " + ex.Message);
            }

            return empresa;
        }
        public int actualizarEmpresa(EmpresaDTO unaEmpresa)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE empresa SET Nombre = @Nombre, Correo = @Correo, Contrasena = @Contrasena, Nroventas = @NroVentas, Logo = @Logo, Descripcion = @Descripcion WHERE RUT = @RUT";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@RUT", unaEmpresa.Rut);
                        comando.Parameters.AddWithValue("@Nombre", unaEmpresa.Nombre);
                        comando.Parameters.AddWithValue("@Correo", unaEmpresa.Correo);
                        comando.Parameters.AddWithValue("@Contrasena", unaEmpresa.Contra);
                        comando.Parameters.AddWithValue("@NroVentas", unaEmpresa.Nroventas);
                        comando.Parameters.AddWithValue("@Logo", unaEmpresa.Logo);
                        comando.Parameters.AddWithValue("@Descripcion", unaEmpresa.Descripcion);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }
        public List<ArticuloDTO> ObtenerTodosLosArticulos(string nombreArticulo)
        {
            List<ArticuloDTO> listaArticulos = new List<ArticuloDTO>();
            string consulta = @"
        SELECT a.IdArticulo, a.Nombre, a.Categoria, a.Precio, a.Stock, a.Estado, a.Imagen, a.Descripcion, a.Empresa_RUT
        FROM articulo a
        WHERE a.Nombre LIKE @Nombre";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", "%" + nombreArticulo + "%"); // Para buscar coincidencias parciales

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idArticulo = reader.GetInt32("IdArticulo");
                                string nombre = reader.GetString("Nombre");
                                string categoria = reader.GetString("Categoria");
                                decimal precio = reader.GetDecimal("Precio");
                                int stock = reader.GetInt32("Stock");
                                string estado = reader.GetString("Estado");
                                string imagen = reader.GetString("Imagen");
                                string descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString("Descripcion");
                                string empresaRUT = reader.GetString("Empresa_RUT");

                                ArticuloDTO articulo = new ArticuloDTO(idArticulo, nombre, categoria, precio, stock, estado, imagen, descripcion, empresaRUT);
                                listaArticulos.Add(articulo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: logueo o mensaje de error opcional
                Console.WriteLine("Error al obtener los artículos: " + ex.Message);
            }
            return listaArticulos;
        }
        public int InsertarCarrito(CarritoDTO carrito)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO carrito (IdCliente, CantidadArticulos, MontoTotal, IdArticulo) VALUES (@IdCliente, @CantidadArticulos, @MontoTotal, @IdArticulo)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", carrito.IdCliente);
                        comando.Parameters.AddWithValue("@CantidadArticulos", carrito.Cantidadarticulos);
                        comando.Parameters.AddWithValue("@MontoTotal", carrito.Montotal);
                        comando.Parameters.AddWithValue("@IdArticulo", carrito.Idarticulo);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }

    }
}
    
  