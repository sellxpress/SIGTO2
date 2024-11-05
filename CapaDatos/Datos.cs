using MySqlConnector;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class Datos
    {
        private string cadenaConexion = "server=localhost;database=ecommerce;uid=root;pwd=root;port=3306;Allow User Variables=true;";
        /*private string cadenaConexion = "server=192.168.2.106;database=ecommerce;uid=Administrador;pwd=Administrador;port=33060";*/
        /*private string cadenaConexionAdmin = "server=192.168.2.106;database=ecommerce;uid=Administrador;pwd=Administrador;port=33060";*/

        #region Consultas Persona
        public int insertarPersona(PersonaDTO unaPersona)
        {
            int filasAfectadas = 0;
            try
            {

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO `persona` values (@Correo,@CI,@Nombre,@Apellido,@Contrasena,@FechaNac,@NroCelular,@Foto)";
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
            }
            return filasAfectadas;
        }
        public PersonaDTO ObtenerPersonaPorCorreo(string correoPersona)
        {
            PersonaDTO persona = null;
           string consulta = @"
    SELECT `p`.`Correo`, `p`.`CI`, `p`.`Nombre`, `p`.`Apellido`, `p`.`Contrasena`, `p`.`FechaNac`, `p`.`NroCelular`, `p`.`Foto`
    FROM `persona` p
    WHERE `p`.`Correo` = @Correo";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", correoPersona);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string correo = reader.GetString("Correo");
                                string ci = reader.GetString("CI");
                                string nombre = reader.GetString("Nombre");
                                string apellido = reader.GetString("Apellido");
                                string contra = reader.GetString("Contrasena");
                                DateTime fechaNacimiento = reader.GetDateTime("FechaNac");
                                string nroCelular = reader.GetString("NroCelular");
                                string foto = reader.IsDBNull(reader.GetOrdinal("Foto")) ? null : reader.GetString("Foto");
                                persona = new PersonaDTO(correo, ci, nombre, apellido, contra, fechaNacimiento, nroCelular, foto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return persona;
        }
        public int actualizarPersona(PersonaDTO unaPersona)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE `persona` SET `Nombre` = @Nombre, `Apellido` = @Apellido, `Contrasena` = @Contrasena, `FechaNac` = @FechaNac, `Foto` = @Foto WHERE `Correo` = @Correo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Correo", unaPersona.Correo);
                        comando.Parameters.AddWithValue("@Nombre", unaPersona.Nombre);
                        comando.Parameters.AddWithValue("@Apellido", unaPersona.Apellido);
                        comando.Parameters.AddWithValue("@Contrasena", unaPersona.Contra);
                        comando.Parameters.AddWithValue("@FechaNac", unaPersona.Fechanac.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@Foto", unaPersona.Foto ?? (object)DBNull.Value);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
            }
            return filasAfectadas;
        }
        #endregion

        #region Consultas Empresa
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
            }
            return filasAfectadas;
        }
        public EmpresaDTO ObtenerEmpresaPorCorreo(string correoEmpresa)
        {
            EmpresaDTO empresa = null;
          string consulta = @"
    SELECT e.`RUT`, e.`Nombre`, e.`Correo`, e.`Contrasena`, e.`NroVentas`, e.`Logo`, e.`Descripcion`
    FROM `empresa` e
    WHERE e.`Correo` = @Correo";
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
                                empresa = new EmpresaDTO(rut, nombre, correo, contrasena, nroVentas, logo, descripcion);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
                    string consulta = "UPDATE `empresa` SET `Nombre` = @Nombre, `Contrasena` = @Contrasena, `Logo` = @Logo, `Descripcion` = @Descripcion WHERE `RUT` = @RUT";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@RUT", unaEmpresa.Rut);
                        comando.Parameters.AddWithValue("@Nombre", unaEmpresa.Nombre);
                        comando.Parameters.AddWithValue("@Contrasena", unaEmpresa.Contra);
                        comando.Parameters.AddWithValue("@Logo", string.IsNullOrEmpty(unaEmpresa.Logo) ? (object)DBNull.Value : unaEmpresa.Logo);
                        comando.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(unaEmpresa.Descripcion) ? (object)DBNull.Value : unaEmpresa.Descripcion);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }
        #endregion

        #region Consultas Articulo
        public List<ArticuloDTO> ObtenerArticulosPorCorreo(string correoEmpresa, string nombreArticulo)
        {
            List<ArticuloDTO> listaArticulos = new List<ArticuloDTO>();
           string consulta = @"
    SELECT `a`.`IdArticulo`, `a`.`Nombre`, `a`.`Categoria`, `a`.`Precio`, `a`.`Stock`, `a`.`Estado`, `a`.`Imagen`, `a`.`Descripcion`, `a`.`Empresa_RUT`
    FROM `articulo` `a`
    INNER JOIN `empresa` `e` ON `a`.`Empresa_RUT` = `e`.`RUT`
    WHERE `e`.`Correo` = @Correo AND `a`.`Nombre` LIKE @Nombre";

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
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
            }

            return listaArticulos;
        }
        public List<ArticuloDTO> ObtenerArticulosCompradosPorCliente(int idCliente)
        {
            List<ArticuloDTO> listaArticulos = new List<ArticuloDTO>();
            string consulta = @"
        SELECT `a`.`IdArticulo`, `a`.`Nombre`
        FROM `Venta` `v`
        INNER JOIN `VentaDetalle` `vd` ON `v`.`IdVenta` = `vd`.`Venta_IdVenta`
        INNER JOIN `Articulo` `a` ON `vd`.`Articulo_IdArticulo` = `a`.`IdArticulo`
        WHERE `v`.`Cliente_IdCliente` = @IdCliente
        AND `a`.`IdArticulo` NOT IN (
            SELECT `Articulo_IdArticulo` 
            FROM `Valoracion` 
            WHERE `Cliente_IdCliente` = @IdCliente
        )";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idCliente);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idarticulo = reader.GetInt32("IdArticulo");
                                string nombre = reader.GetString("Nombre");
                                ArticuloDTO articulo = new ArticuloDTO(idarticulo, nombre);
                                listaArticulos.Add(articulo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción si es necesario
            }
            return listaArticulos;
        }
        public bool EliminarArticulo(int idArticulo)
        {
            string consulta = "DELETE FROM `articulo` WHERE `IdArticulo` = @IdArticulo";
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
                return false;  // Devuelve false si ocurre un error
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
                    string consulta = @"
    INSERT INTO `articulo` (`Nombre`, `Categoria`, `Precio`, `Stock`, `Estado`, `Imagen`, `Descripcion`, `Empresa_RUT`)
    VALUES (@Nombre, @Categoria, @Precio, @Stock, @Estado, @Imagen, @Descripcion, @Empresa_RUT)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unArticulo.Nombre);
                        comando.Parameters.AddWithValue("@Categoria", unArticulo.Categoria);
                        comando.Parameters.AddWithValue("@Precio", unArticulo.Precio);
                        comando.Parameters.AddWithValue("@Stock", unArticulo.Stock);
                        comando.Parameters.AddWithValue("@Estado", unArticulo.Estado);
                        comando.Parameters.AddWithValue("@Imagen", unArticulo.Imagen); 
                        comando.Parameters.AddWithValue("@Descripcion", (object)unArticulo.Descripcion ?? DBNull.Value); 
                        comando.Parameters.AddWithValue("@Empresa_RUT", unArticulo.Empresarut);  
              filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
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
                    string consulta = "UPDATE `articulo` SET `Nombre` = @Nombre, `Categoria` = @Categoria, `Precio` = @Precio, `Stock` = @Stock, `Estado` = @Estado, `Imagen` = @Imagen, `Descripcion` = @Descripcion WHERE `IdArticulo` = @IdArticulo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unArticulo.Nombre);
                        comando.Parameters.AddWithValue("@Categoria", unArticulo.Categoria);
                        comando.Parameters.AddWithValue("@Precio", unArticulo.Precio);
                        comando.Parameters.AddWithValue("@Stock", unArticulo.Stock);
                        comando.Parameters.AddWithValue("@Estado", unArticulo.Estado);
                        comando.Parameters.AddWithValue("@Imagen", unArticulo.Imagen);
                        comando.Parameters.AddWithValue("@Descripcion", unArticulo.Descripcion ?? (object)DBNull.Value); 
                        comando.Parameters.AddWithValue("@IdArticulo", unArticulo.Idarticulo);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }
        public List<ArticuloDTO> ObtenerTodosLosArticulos(string nombreArticulo)
        {
            List<ArticuloDTO> listaArticulos = new List<ArticuloDTO>();
            string consulta = "SELECT `a`.`IdArticulo`, `a`.`Nombre`, `a`.`Categoria`, `a`.`Precio`, `a`.`Stock`, `a`.`Estado`, `a`.`Imagen`, `a`.`Descripcion`, `a`.`Empresa_RUT` FROM `articulo` `a` WHERE `a`.`Nombre` LIKE @Nombre";
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

        #endregion

        #region Consultas Cliente
        public int insertarCliente(ClienteDTO unCliente)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO `cliente` (`Persona_Correo`, `NroCompras`) VALUES (@Persona_Correo, @NroCompras)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Persona_Correo", unCliente.PersonaCorreo);
                        comando.Parameters.AddWithValue("@NroCompras", unCliente.NroCompras);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {

            }
            return filasAfectadas;
        }
        public DireccionClienteDTO ObtenerDireccionPorIdCliente(int idCliente)
        {
            DireccionClienteDTO direccionCliente = null;
            string consulta = @"
    SELECT `d`.`Calle`, `d`.`Numero`, `d`.`Localidad`, `d`.`Departamento`, `d`.`Referencia`
    FROM `direccioncliente` `d`
    WHERE `d`.`Cliente_IdCliente` = @IdCliente";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idCliente);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string calle = reader.GetString("Calle");
                                string numero = reader.GetString("Numero");
                                string localidad = reader.GetString("Localidad");
                                string departamento = reader.GetString("Departamento");
                                string referencia = reader.IsDBNull(reader.GetOrdinal("Referencia")) ? null : reader.GetString("Referencia");
                                direccionCliente = new DireccionClienteDTO(idCliente, calle, numero, localidad, departamento, referencia);
                            }
                        }
                        }
                    }
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
            }
            return direccionCliente;
        }
        public void GuardarDireccionCliente(DireccionClienteDTO direccionCliente)
        {
            string consultaInsertar = @"
    INSERT INTO `direccioncliente` (`Cliente_IdCliente`, `Calle`, `Numero`, `Localidad`, `Departamento`, `Referencia`)
    VALUES (@IdCliente, @Calle, @Numero, @Localidad, @Departamento, @Referencia)";

            string consultaActualizar = @"
    UPDATE `direccioncliente` 
    SET `Calle` = @Calle, `Numero` = @Numero, `Localidad` = @Localidad, `Departamento` = @Departamento, `Referencia` = @Referencia
    WHERE `Cliente_IdCliente` = @IdCliente";

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@IdCliente", direccionCliente.Idcliente);
                    comando.Parameters.AddWithValue("@Calle", direccionCliente.Calle);
                    comando.Parameters.AddWithValue("@Numero", direccionCliente.Numero);
                    comando.Parameters.AddWithValue("@Localidad", direccionCliente.Localidad);
                    comando.Parameters.AddWithValue("@Departamento", direccionCliente.Departamento);
                    comando.Parameters.AddWithValue("@Referencia", direccionCliente.Referencia);
                    string consultaVerificar = "SELECT COUNT(*) FROM `direccioncliente` WHERE `Cliente_IdCliente` = @IdCliente";
                    comando.CommandText = consultaVerificar;
                    int existe = Convert.ToInt32(comando.ExecuteScalar());
                    if (existe > 0)
                    {
                        // Actualiza
                        comando.CommandText = consultaActualizar;
                    }
                    else
                    {
                        // Inserta
                        comando.CommandText = consultaInsertar;
                    }
                    comando.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Consultas Valoracion
        public List<ValoracionDTO> ObtenerValoracionesPorCliente(int idCliente)
        {
            List<ValoracionDTO> listaValoraciones = new List<ValoracionDTO>();
            string consulta = @"
    SELECT v.`IdValoracion`, v.`Calificación`, v.`Comentario`, a.`IdArticulo`, a.`Nombre` AS `NombreArticulo`
    FROM `valoracion` v
    INNER JOIN `articulo` a ON v.`Articulo_IdArticulo` = a.`IdArticulo`
    WHERE v.`Cliente_IdCliente` = @IdCliente";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idCliente);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idValoracion = reader.GetInt32("IdValoracion");
                                string calificacion = reader.GetString("Calificación");
                                string comentario = reader.GetString("Comentario");
                                int idArticulo = reader.GetInt32("IdArticulo");
                                string nombreArticulo = reader.GetString("NombreArticulo");
                                ValoracionDTO valoracion = new ValoracionDTO(idValoracion, calificacion, comentario, nombreArticulo, idArticulo, idCliente);
                                listaValoraciones.Add(valoracion);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return listaValoraciones;
        }
        public int insertarValoracion(ValoracionDTO valoracion)
        {
            int filasAfectadas = 0;
            string consulta = @"
        INSERT INTO `valoracion` (`Calificación`, `Comentario`, `Articulo_IdArticulo`, `Cliente_IdCliente`)
        VALUES (@Calificacion, @Comentario, @IdArticulo, @IdCliente)";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Calificacion", valoracion.Calificacion);
                        comando.Parameters.AddWithValue("@Comentario", valoracion.Comentario);
                        comando.Parameters.AddWithValue("@IdArticulo", valoracion.Idarticulo); 
                        comando.Parameters.AddWithValue("@IdCliente", valoracion.Idcliente); 
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }

        public int actualizarValoracion(ValoracionDTO valoracion, int idValoracion)
        {
            int filasAfectadas = 0; 
            string consulta = @"
        UPDATE `valoracion`
        SET `Calificacion` = @Calificacion, `Comentario` = @Comentario
        WHERE `IdValoracion` = @IdValoracion";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Calificacion", valoracion.Calificacion);
                        comando.Parameters.AddWithValue("@Comentario", valoracion.Comentario);
                        comando.Parameters.AddWithValue("@IdValoracion", idValoracion);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }

        public int EliminarValoracion(int idValoracion)
        {
            int filasAfectadas = 0;
            string consulta = "DELETE FROM `valoracion` WHERE `IdValoracion` = @IdValoracion";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdValoracion", idValoracion);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return filasAfectadas;
        }

        #endregion

        #region Consultas Carrito
        public int InsertarOActualizarCarrito(CarritoDTO carrito)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consultaExistente = @"
    SELECT `CantidadArticulos` 
    FROM `carrito` 
    WHERE `Cliente_IdCliente` = @IdCliente 
    AND `Articulo_IdArticulo` = @IdArticulo";
                    using (MySqlCommand comandoExistente = new MySqlCommand(consultaExistente, conexion))
                    {
                        comandoExistente.Parameters.AddWithValue("@IdCliente", carrito.IdCliente);
                        comandoExistente.Parameters.AddWithValue("@IdArticulo", carrito.Idarticulo);

                        object resultado = comandoExistente.ExecuteScalar();

                        if (resultado != null) // El artículo ya está en el carrito
                        {
                            int cantidadExistente = Convert.ToInt32(resultado);

                            // Actualizar la cantidad y el monto total
                            string actualizarConsulta = @"
    UPDATE `carrito` 
    SET `CantidadArticulos` = @NuevaCantidad, 
        `MontoTotal` = @NuevoMontoTotal 
    WHERE `Cliente_IdCliente` = @IdCliente 
    AND `Articulo_IdArticulo` = @IdArticulo";
                            using (MySqlCommand comandoActualizar = new MySqlCommand(actualizarConsulta, conexion))
                            {
                                int nuevaCantidad = cantidadExistente + carrito.Cantidadarticulos;
                                decimal nuevoMontoTotal = nuevaCantidad * carrito.Montotal;
                                comandoActualizar.Parameters.AddWithValue("@NuevaCantidad", nuevaCantidad);
                                comandoActualizar.Parameters.AddWithValue("@NuevoMontoTotal", nuevoMontoTotal);
                                comandoActualizar.Parameters.AddWithValue("@IdCliente", carrito.IdCliente);
                                comandoActualizar.Parameters.AddWithValue("@IdArticulo", carrito.Idarticulo);

                                filasAfectadas = comandoActualizar.ExecuteNonQuery();
                            }
                        }
                        else  // El artículo no está en el carrito, entonces insertar
                        {
                            string insertarConsulta = @"
    INSERT INTO `carrito` (`Cliente_IdCliente`, `CantidadArticulos`, `MontoTotal`, `Articulo_IdArticulo`) 
    VALUES (@IdCliente, @CantidadArticulos, @MontoTotal, @IdArticulo)";
                            using (MySqlCommand comandoInsertar = new MySqlCommand(insertarConsulta, conexion))
                            {
                                comandoInsertar.Parameters.AddWithValue("@IdCliente", carrito.IdCliente);
                                comandoInsertar.Parameters.AddWithValue("@CantidadArticulos", carrito.Cantidadarticulos);
                                comandoInsertar.Parameters.AddWithValue("@MontoTotal", carrito.Montotal);
                                comandoInsertar.Parameters.AddWithValue("@IdArticulo", carrito.Idarticulo);
                                filasAfectadas = comandoInsertar.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }
        public List<CarritoDTO> ObtenerArticulosDelCarrito(int idCliente)
        {
            List<CarritoDTO> listaArticulos = new List<CarritoDTO>();
            string consulta = @"SELECT 
    `c`.`Articulo_IdArticulo`,
    `a`.`Nombre`,
    `a`.`Precio`,
    `c`.`CantidadArticulos`,
    `c`.`MontoTotal`,
    `a`.`Stock`
FROM 
    `carrito` `c`
INNER JOIN 
    `articulo` `a` ON `c`.`Articulo_IdArticulo` = `a`.`IdArticulo`
WHERE 
    `c`.`Cliente_IdCliente` = @IdCliente";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idCliente);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idArticulo = reader.GetInt32("Articulo_IdArticulo");
                                string nombre = reader.GetString("Nombre");
                                decimal precio = reader.GetDecimal("Precio");
                                int cantidad = reader.GetInt32("CantidadArticulos");
                                decimal montoTotal = reader.GetDecimal("MontoTotal");
                                int stock = reader.GetInt32("Stock");
                                CarritoDTO articulo = new CarritoDTO(idCliente, idArticulo, nombre, precio, cantidad, montoTotal, stock);
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
        public int EliminarCarrito(int idArticulo)
        {
            int filasAfectadas = 0;
            string consulta = "DELETE FROM `carrito` WHERE `Articulo_IdArticulo` = @IdArticulo";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdArticulo", idArticulo);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }
        public int EliminarCarritoCliente(int idCliente)
        {
            int filasAfectadas = 0;
            string consulta = "DELETE FROM `carrito` WHERE `Cliente_IdCliente` = @IdCliente";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idCliente);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el carrito: " + ex.Message);
            }
            return filasAfectadas;
        }

        public int ActualizarCantidadCarrito(int idArticulo, int nuevaCantidad, decimal montoTotal)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE `carrito` SET `CantidadArticulos` = @Cantidad, `MontoTotal` = @MontoTotal WHERE `Articulo_IdArticulo` = @IdArticulo";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdArticulo", idArticulo);
                        comando.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
                        comando.Parameters.AddWithValue("@MontoTotal", montoTotal); // Pasar el monto total
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (puedes logear el error si lo deseas)
            }
            return filasAfectadas;
        }
        #endregion

        #region Consultas Ventas
        public int ActualizarEstadoVenta(int idVenta, string nuevoEstado)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE `venta` SET `Estado` = @NuevoEstado WHERE `IdVenta` = @IdVenta";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdVenta", idVenta);
                        comando.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return filasAfectadas;
        }

        public int CrearVenta(VentaDTO ventaDTO, List<CarritoDTO> articulosCarrito)
        {
            int idVentaGenerada = 0;

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (MySqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar en la tabla 'venta'
                        string consultaVenta = "INSERT INTO `venta` (`Estado`, `FechaYHora`, `ImporteFinal`, `ImporteTotal`, `Descuento`, `CostoEnvio`, `Cliente_IdCliente`, `Pickup_IdPickup`) VALUES (@Estado, @FechaYHora, @ImporteFinal, @ImporteTotal, @Descuento, @CostoEnvio, @Cliente_IdCliente, @Pickup_IdPickup)";

                        using (MySqlCommand comandoVenta = new MySqlCommand(consultaVenta, conexion, transaction))
                        {
                            comandoVenta.Parameters.AddWithValue("@Estado", ventaDTO.Estado);
                            comandoVenta.Parameters.AddWithValue("@FechaYHora", ventaDTO.Fechayhora);
                            comandoVenta.Parameters.AddWithValue("@ImporteFinal", ventaDTO.Importefinal);
                            comandoVenta.Parameters.AddWithValue("@ImporteTotal", ventaDTO.Importetotal);
                            comandoVenta.Parameters.AddWithValue("@Descuento", ventaDTO.Descuento);
                            comandoVenta.Parameters.AddWithValue("@CostoEnvio", ventaDTO.Costoenvio);
                            comandoVenta.Parameters.AddWithValue("@Cliente_IdCliente", ventaDTO.Idcliente);
                            comandoVenta.Parameters.AddWithValue("@Pickup_IdPickup", ventaDTO.Idpickup);
                            comandoVenta.ExecuteNonQuery();
                            idVentaGenerada = (int)comandoVenta.LastInsertedId; // Obtener el IdVenta generado
                        }
                        // 2. Insertar en la tabla 'ventadetalle' para cada artículo del carrito
                        foreach (var articulo in articulosCarrito)
                        {
                            string consultaDetalle = "INSERT INTO `ventadetalle` (`PrecioUnitario`, `NroArticulos`, `Venta_IdVenta`, `Articulo_IdArticulo`) VALUES (@PrecioUnitario, @NroArticulos, @Venta_IdVenta, @Articulo_IdArticulo)";
                            using (MySqlCommand comandoDetalle = new MySqlCommand(consultaDetalle, conexion, transaction))
                            {
                                comandoDetalle.Parameters.AddWithValue("@PrecioUnitario", articulo.Precio);
                                comandoDetalle.Parameters.AddWithValue("@NroArticulos", articulo.Cantidadarticulos);
                                comandoDetalle.Parameters.AddWithValue("@Venta_IdVenta", idVentaGenerada);
                                comandoDetalle.Parameters.AddWithValue("@Articulo_IdArticulo", articulo.Idarticulo);
                                comandoDetalle.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Manejar excepciones, por ejemplo, revertir la transacción
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            return idVentaGenerada; // Retornar el IdVenta generado
        }
       
        public List<VentaDTO> ObtenerVentasPorClienteId(int idcliente)
        {
            List<VentaDTO> ventas = new List<VentaDTO>();
            string consulta = @"
        SELECT `v`.`IdVenta`, `v`.`Estado`, `v`.`FechaYHora`, `v`.`ImporteFinal`, `v`.`ImporteTotal`, `v`.`Descuento`, `v`.`CostoEnvio`, 
               `v`.`Cliente_IdCliente`, `v`.`Pickup_IdPickup`
        FROM `venta` v
        WHERE `v`.`Cliente_IdCliente` = @IdCliente";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idcliente);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idVenta = reader.GetInt32("IdVenta");
                                string estado = reader.GetString("Estado");
                                DateTime fechaYHora = reader.GetDateTime("FechaYHora");
                                decimal importeFinal = reader.GetDecimal("ImporteFinal");
                                decimal importeTotal = reader.GetDecimal("ImporteTotal");
                                int descuento = reader.GetInt32("Descuento");
                                decimal costoEnvio = reader.GetDecimal("CostoEnvio");
                                int idCliente = reader.GetInt32("Cliente_IdCliente");
                                int idPickup = reader.GetInt32("Pickup_IdPickup");
                                VentaDTO venta = new VentaDTO(idVenta, estado, fechaYHora, importeFinal, importeTotal, descuento, costoEnvio, idcliente, idPickup);
                                ventas.Add(venta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return ventas;
        }
        public List<VentaDTO> ObtenerVentasPorCorreoEmpresa(string correoEmpresa)
        {
            List<VentaDTO> ventas = new List<VentaDTO>();
            string consulta = @"
        SELECT 
            `v`.`IdVenta`, 
            `v`.`Estado`, 
            `v`.`FechaYHora`, 
            `v`.`ImporteFinal`, 
            `v`.`ImporteTotal`, 
            `v`.`Descuento`, 
            `v`.`CostoEnvio`, 
            c.`IdCliente`, 
            `p`.`Nombre` AS `NombreCliente`,  
            `p`.`Correo` AS `CorreoCliente`
        FROM 
            `venta` v
        INNER JOIN 
            `cliente` c ON v.`Cliente_IdCliente` = c.`IdCliente`
        INNER JOIN 
            `persona` p ON c.`Persona_Correo` = p.`Correo`
        INNER JOIN 
            `ventadetalle` vd ON `v`.`IdVenta` = `vd`.`Venta_IdVenta`
        INNER JOIN 
            `articulo` a ON `vd`.`Articulo_IdArticulo` = `a`.`IdArticulo`
        INNER JOIN 
            `empresa` e ON `a`.`Empresa_RUT` = `e`.`RUT`
        WHERE 
            `e`.`Correo` = @CorreoEmpresa AND 
            `v`.`Estado` IN ('Completada', 'Cancelada')";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CorreoEmpresa", correoEmpresa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idventa = reader.GetInt32("IdVenta");
                                string estado = reader.GetString("Estado");
                                DateTime fechayhora = reader.GetDateTime("FechaYHora");
                                decimal importefinal = reader.GetDecimal("ImporteFinal");
                                decimal importetotal = reader.GetDecimal("ImporteTotal");
                                int descuento = reader.GetInt32("Descuento");
                                decimal costoenvio = reader.GetDecimal("CostoEnvio");
                                int idcliente = reader.GetInt32("IdCliente");
                                string correocliente = reader.GetString("CorreoCliente");
                                string nombrecliente = reader.GetString("NombreCliente");
                                VentaDTO venta = new VentaDTO(idventa, estado, fechayhora, importefinal, importetotal, descuento, costoenvio, nombrecliente, correocliente, idcliente);
                                ventas.Add(venta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return ventas;
        }
        public List<VentaDTO> ObtenerVentasEnProcesoPorCorreoEmpresa(string correoEmpresa)
        {
            List<VentaDTO> ventas = new List<VentaDTO>();
            string consulta = @"
        SELECT 
            v.`IdVenta`, 
            v.`Estado`, 
            v.`FechaYHora`, 
            v.`ImporteFinal`, 
            v.`ImporteTotal`, 
            v.`Descuento`, 
            v.`CostoEnvio`,
            c.`IdCliente`, 
            p.`Nombre` AS `NombreCliente`, 
            p.`Correo` AS `CorreoCliente`,
            CASE 
                WHEN v.`CostoEnvio` > 0 THEN d.`Calle`
            END AS `Calle`,
            CASE 
                WHEN v.`CostoEnvio` > 0 THEN d.`Numero`
            END AS `Numero`,
            CASE 
                WHEN v.`CostoEnvio` > 0 THEN d.`Localidad`
            END AS `Localidad`,
            CASE 
                WHEN v.`CostoEnvio` > 0 THEN d.`Departamento`
            END AS `Departamento`,
            CASE 
                WHEN v.`CostoEnvio` > 0 THEN d.`Referencia`
            END AS `Referencia`
        FROM 
            `venta` v
        INNER JOIN 
            `cliente` c ON v.`Cliente_IdCliente` = c.`IdCliente`
        INNER JOIN 
            `persona` p ON c.`Persona_Correo` = p.`Correo`
        INNER JOIN 
            `ventadetalle` vd ON v.`IdVenta` = vd.`Venta_IdVenta`
        INNER JOIN 
            `articulo` a ON vd.`Articulo_IdArticulo` = a.`IdArticulo`
        INNER JOIN 
            `empresa` e ON a.`Empresa_RUT` = e.`RUT`
        LEFT JOIN 
            `direccioncliente` d ON c.`IdCliente` = d.`Cliente_IdCliente`
        WHERE 
            e.`Correo` = @CorreoEmpresa AND 
            v.`Estado` IN ('Pendiente', 'Confirmada', 'En preparacion', 'Enviada')";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CorreoEmpresa", correoEmpresa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idventa = reader.GetInt32("IdVenta");
                                string estado = reader.GetString("Estado");
                                DateTime fechayhora = reader.GetDateTime("FechaYHora");
                                decimal importefinal = reader.GetDecimal("ImporteFinal");
                                decimal importetotal = reader.GetDecimal("ImporteTotal");
                                int descuento = reader.GetInt32("Descuento");
                                decimal costoenvio = reader.GetDecimal("CostoEnvio");
                                int idcliente = reader.GetInt32("IdCliente");
                                string nombrecliente = reader.GetString("NombreCliente");
                                string correocliente = reader.GetString("CorreoCliente");

                                // Información de la dirección del cliente
                                string calle = costoenvio > 0 && !reader.IsDBNull(reader.GetOrdinal("Calle")) ? reader.GetString("Calle") : null;
                                string numero = costoenvio > 0 && !reader.IsDBNull(reader.GetOrdinal("Numero")) ? reader.GetString("Numero") : null;
                                string localidad = costoenvio > 0 && !reader.IsDBNull(reader.GetOrdinal("Localidad")) ? reader.GetString("Localidad") : null;
                                string departamento = costoenvio > 0 && !reader.IsDBNull(reader.GetOrdinal("Departamento")) ? reader.GetString("Departamento") : null;
                                string referencia = costoenvio > 0 && !reader.IsDBNull(reader.GetOrdinal("Referencia")) ? reader.GetString("Referencia") : null;

                                VentaDTO venta = new VentaDTO(idventa, estado, fechayhora, importefinal, importetotal, descuento, costoenvio, nombrecliente, correocliente, idcliente, calle, numero, localidad, departamento, referencia);
                                ventas.Add(venta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return ventas;
        }
        public List<VentaDetalleDTO> ObtenerDetallesVentaPorCorreoEmpresa(string correoEmpresa, int idventa)
        {
            List<VentaDetalleDTO> detalles = new List<VentaDetalleDTO>();
            string consulta = @"
        SELECT 
            vd.`IdVentaDetalle`, 
            vd.`Articulo_IdArticulo`, 
            a.`Nombre` AS `NombreArticulo`, 
            a.`Precio` AS `PrecioUnitario`, 
            a.`Stock` AS `Stock`, 
            vd.`NroArticulos`
        FROM 
            `ventadetalle` vd
        INNER JOIN 
            `articulo` a ON vd.`Articulo_IdArticulo` = a.`IdArticulo`
        INNER JOIN 
            `venta` v ON vd.`Venta_IdVenta` = v.`IdVenta`
        INNER JOIN 
            `empresa` e ON a.`Empresa_RUT` = e.`RUT`
        WHERE 
            e.`Correo` = @CorreoEmpresa AND 
            v.`IdVenta` LIKE CONCAT('%', @IdVenta, '%')";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CorreoEmpresa", correoEmpresa);
                        comando.Parameters.AddWithValue("@IdVenta", idventa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idventadetalle = reader.GetInt32("IdVentaDetalle");
                                int idarticulo = reader.GetInt32("Articulo_IdArticulo");
                                string nombrearticulo = reader.GetString("NombreArticulo");
                                int nroarticulos = reader.GetInt32("NroArticulos");
                                int preciounitario = reader.GetInt32("PrecioUnitario");
                                int stock = reader.GetInt32("Stock");
                                VentaDetalleDTO detalle = new VentaDetalleDTO(idventadetalle, nombrearticulo, nroarticulos,preciounitario,stock, idventa, idarticulo);
                                detalles.Add(detalle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return detalles;
        }
        #endregion

        #region Consultas BackOffice
        public List<PersonaDTO> ObtenerPersonasConIdCliente(string correoBusqueda)
        {
            List<PersonaDTO> listaPersonas = new List<PersonaDTO>();
            string consulta = @"
        SELECT `p`.`Correo`, `p`.`CI`, `p`.`Nombre`, `p`.`Apellido`, `p`.`FechaNac`, `p`.`NroCelular`, `p`.`Foto`, `c`.`IdCliente`
        FROM `persona` `p`
        INNER JOIN `cliente` `c` ON `p`.`Correo` = `c`.`Persona_Correo`
        WHERE `p`.`Correo` LIKE @Correo;";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        // Se utiliza LIKE para permitir búsquedas parciales por correo
                        comando.Parameters.AddWithValue("@Correo", "%" + correoBusqueda + "%");
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string correo = reader.GetString("Correo");
                                string ci = reader.GetString("CI");
                                string nombre = reader.GetString("Nombre");
                                string apellido = reader.GetString("Apellido");
                                DateTime fechanac = reader.GetDateTime("FechaNac");
                                string nrocelular = reader.GetString("NroCelular");
                                string foto = reader.IsDBNull(reader.GetOrdinal("Foto")) ? null : reader.GetString("Foto");
                                int idcliente = reader.GetInt32("IdCliente");
                                PersonaDTO persona = new PersonaDTO(correo, ci, nombre, apellido, fechanac, nrocelular, foto, idcliente);
                                listaPersonas.Add(persona);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return listaPersonas;
        }
        public List<EmpresaDTO> ObtenerEmpresasPorCorreo(string correoBusqueda)
        {
            List<EmpresaDTO> listaEmpresas = new List<EmpresaDTO>();
            string consulta = @"
         SELECT 
             e.`RUT`, 
             e.`Nombre`, 
             e.`Correo`, 
             e.`NroVentas`, 
             e.`Logo`, 
             e.`Descripcion`
          FROM 
                `empresa` e
           WHERE 
                 e.`Correo` LIKE @Correo";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        // Se utiliza LIKE para permitir búsquedas parciales por correo
                        comando.Parameters.AddWithValue("@Correo", "%" + correoBusqueda + "%");

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string rut = reader.GetString("RUT");
                                string nombre = reader.GetString("Nombre");
                                string correo = reader.GetString("Correo");
                                long nroVentas = reader.GetInt64("Nroventas");
                                string logo = reader.IsDBNull(reader.GetOrdinal("Logo")) ? null : reader.GetString("Logo");
                                string descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString("Descripcion");
                                EmpresaDTO empresa = new EmpresaDTO(rut, nombre, correo, null, nroVentas, logo, descripcion);
                                listaEmpresas.Add(empresa);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (puedes registrar el error si lo deseas)
            }
            return listaEmpresas;
        }

        #endregion

        #region Consultas anuncios
        public List<AnuncioDTO> ObtenerAnunciosPorCorreoEmpresa(string correoEmpresa)
        {
            List<AnuncioDTO> anuncios = new List<AnuncioDTO>();
            string consulta = @"
        SELECT a.IdAnuncio, a.Nombre, a.FechaInicio, a.FechaFin, a.Descuento, a.Imagen, e.RUT AS Empresa_RUT
        FROM anuncio a
        INNER JOIN empresa e ON a.Empresa_RUT = e.RUT
        WHERE e.Correo = @CorreoEmpresa";
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@CorreoEmpresa", correoEmpresa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idAnuncio = reader.GetInt32("IdAnuncio");
                                string nombre = reader.GetString("Nombre");
                                DateTime fechaInicio = reader.GetDateTime("FechaInicio");
                                DateTime fechaFin = reader.GetDateTime("FechaFin");
                                int descuento = reader.GetInt32("Descuento");
                                string imagen = reader.GetString("Imagen");
                                string empresaRut = reader.GetString("Empresa_RUT");
                                AnuncioDTO anuncio = new AnuncioDTO(idAnuncio, nombre, fechaInicio, fechaFin, descuento, imagen, empresaRut);
                                anuncios.Add(anuncio);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return anuncios;
        }
        public int insertarAnuncio(AnuncioDTO unAnuncio)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO `anuncio` (`Nombre`, `FechaInicio`, `FechaFin`, `Descuento`, `Imagen`, `Empresa_RUT`) " +
                                      "VALUES (@Nombre, @FechaInicio, @FechaFin, @Descuento, @Imagen, @Empresa_RUT)";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unAnuncio.Nombre);
                        comando.Parameters.AddWithValue("@FechaInicio", unAnuncio.Fechainicio.ToString("yyyy-MM-dd HH:mm:ss")); 
                        comando.Parameters.AddWithValue("@FechaFin", unAnuncio.Fechafin.ToString("yyyy-MM-dd HH:mm:ss")); 
                        comando.Parameters.AddWithValue("@Descuento", unAnuncio.Descuento);
                        comando.Parameters.AddWithValue("@Imagen", unAnuncio.Imagen);
                        comando.Parameters.AddWithValue("@Empresa_RUT", unAnuncio.Empresarut);

                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return filasAfectadas;
        }
        public int actualizarAnuncio(AnuncioDTO unAnuncio, int idAnuncio)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE `anuncio` SET `Nombre` = @Nombre, `FechaInicio` = @FechaInicio, " +
                                      "`FechaFin` = @FechaFin, `Descuento` = @Descuento, `Imagen` = @Imagen " +
                                      "WHERE `IdAnuncio` = @IdAnuncio";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", unAnuncio.Nombre);
                        comando.Parameters.AddWithValue("@FechaInicio", unAnuncio.Fechainicio.ToString("yyyy-MM-dd HH:mm:ss")); // Formato a insertar
                        comando.Parameters.AddWithValue("@FechaFin", unAnuncio.Fechafin.ToString("yyyy-MM-dd HH:mm:ss")); // Formato a insertar
                        comando.Parameters.AddWithValue("@Descuento", unAnuncio.Descuento);
                        comando.Parameters.AddWithValue("@Imagen", unAnuncio.Imagen);
                        comando.Parameters.AddWithValue("@IdAnuncio", idAnuncio); // ID del anuncio a actualizar
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return filasAfectadas;
        }
        public int EliminarAnuncio(int idAnuncio)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM `anuncio` WHERE `IdAnuncio` = @IdAnuncio"; 

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAnuncio", idAnuncio);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return filasAfectadas; // Devuelve el número de filas afectadas
        }
        #endregion

        #region Otras Consultas
        public string VerificarUsuario(string correo, string contrasena)
        {
            string tipoUsuario = null;
            string consulta = @"
    SELECT 
        CASE 
            WHEN EXISTS (
                SELECT 1 
                FROM `cliente` c 
                JOIN `persona` p ON c.`Persona_Correo` = p.`Correo` 
                WHERE p.`Correo` = @correo 
                AND BINARY p.`Contrasena` = @contrasena
            ) THEN 'Cliente'
            WHEN EXISTS (
                SELECT 1 
                FROM `administrador` a 
                JOIN `persona` p ON a.`Persona_Correo` = p.`Correo` 
                WHERE p.`Correo` = @correo 
                AND BINARY p.`Contrasena` = @contrasena
            ) THEN 'Administrador'
            WHEN EXISTS (
                SELECT 1 
                FROM `empresa` e 
                WHERE e.`Correo` = @correo 
                AND BINARY e.`Contrasena` = @contrasena
            ) THEN 'Empresa'
            ELSE NULL 
        END AS `TipoUsuario`";
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
            }
            return tipoUsuario;
        }
        public (string Nombre, string Apellido, string NombreEmpresa, string RutEmpresa, int? IdCliente) ObtenerInformacionUsuario(string correo, string tipoUsuario)
        {
            string consulta = string.Empty;
            if (tipoUsuario == "Cliente" || tipoUsuario == "Administrador")
            {
                consulta = @"
        SELECT 
            p.`Nombre`, 
            p.`Apellido`, 
            c.`IdCliente` 
        FROM `persona` p
        LEFT JOIN `cliente` c ON p.`Correo` = c.`Persona_Correo` 
        WHERE p.`Correo` = @correo";
        }
            else if (tipoUsuario == "Empresa")
            {
                consulta = @"
        SELECT 
            `Nombre`, 
            `RUT` 
        FROM `empresa` 
        WHERE `Correo` = @correo";
            }
            string nombre = null;
            string apellido = null;
            string nombreEmpresa = null;
            string rutEmpresa = null;
            int? idCliente = null;
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
                                    idCliente = reader.IsDBNull(reader.GetOrdinal("IdCliente")) ? (int?)null : reader.GetInt32("IdCliente");
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
            }
            return (nombre, apellido, nombreEmpresa, rutEmpresa, idCliente);
        }
        #endregion

    }
}