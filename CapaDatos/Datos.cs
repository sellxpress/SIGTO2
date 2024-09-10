using MySqlConnector;
using DTO;
using CapaLogica;
using System;

namespace CapaDatos
{
    public class Datos
    {
       private string cadenaConexion = "server=localhost;db=proyecto;uid=root;pwd=root;";

      public int insertarEmpresa(EmpresaDTO unaEmpresa)
         {
      int filasAfectadas = 0;
          try
           {
       
        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
        conexion.Open();
           string consulta = "INSERT INTO Empresa values (@RUT,@Nombre,@Correo,@Contraseña,@NroVentas,@Logo,@Descripcion)";
         using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
             {
          comando.Parameters.AddWithValue("@RUT".unaEmpresa.rut);
          comando.Parameters.AddWithValue("@Nombre".unaEmpresa.Nombre);
          comando.Parameters.AddWithValue("@Correo".unaEmpresa.Correo);
          comando.Parameters.AddWithValue("@Contraseña".unaEmpresa.Contraseña);
          comando.Parameters.AddWithValue("@NroVentas".unaEmpresa.NroVentas);
          comando.Parameters.AddWithValue("@Logo".unaEmpresa.Logo);
          comando.Parameters.AddWithValue("@Descripcion".unaEmpresa.Descripcion);
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