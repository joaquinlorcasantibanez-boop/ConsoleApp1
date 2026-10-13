using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace TuProyecto
{
    public class Sesion
    {
        public string Validar_Datos(
            string correo,
            string contrasena)
        {
            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.Conectar())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "sp_Validacion_datos",
                        cn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@Correo",
                    correo);

                cmd.Parameters.AddWithValue(
                    "@Contrasena",
                    contrasena);

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    SesionActual.IdTrabajador =
                        Convert.ToInt32(
                            dr["IdTrabajador"]);

                    SesionActual.Nombre =
                        dr["Nombre"].ToString();

                    SesionActual.Cargo =
                        dr["Cargo"].ToString();

                    if (SesionActual.Cargo == "Administrador")
                        return "Administrador";

                    return "Usuario";
                }

                return "NoExiste";
            }
        }
    }
}