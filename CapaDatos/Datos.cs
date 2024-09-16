using MySqlConnector;
using DTO;
using CapaLogica;
using System;

namespace CapaDatos
{
    public class Datos
    {
        private string cadenaConexion = "server=localhost;db=ecommerce;uid=root;pwd=root;";

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
                        comando.Parameters.AddWithValue("@Contraseña", unaEmpresa.Contra);
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
                        comando.Parameters.AddWithValue("@RUT", unaPersona.Correo);
                        comando.Parameters.AddWithValue("@Nombre", unaPersona.Ci);
                        comando.Parameters.AddWithValue("@Correo", unaPersona.Nombre);
                        comando.Parameters.AddWithValue("@Contraseña", unaPersona.Apellido);
                        comando.Parameters.AddWithValue("@NroVentas", unaPersona.Contra);
                        comando.Parameters.AddWithValue("@Logo", unaPersona.Fechanac);
                        comando.Parameters.AddWithValue("@Descripcion", unaPersona.Nrocelular);
                        comando.Parameters.AddWithValue("@Descripcion", unaPersona.Foto);
                        filasAfectadas = comando.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return filasAfectadas;
        }
    }
}