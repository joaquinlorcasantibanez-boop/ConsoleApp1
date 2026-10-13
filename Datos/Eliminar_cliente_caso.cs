using Microsoft.Data.SqlClient;
using System.Data;

namespace TuProyecto
{
    public class Eliminar_Cliente_y_Casos
    {
        public static void EliminarClienteYCasos()
        {
            try
            {
                Console.Write(
                    "Ingrese el ID del cliente a eliminar: ");

                int idCliente =
                    int.Parse(Console.ReadLine());

                Conexion conexion =
                    new Conexion();

                using (SqlConnection cn =
                    conexion.Conectar())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_EliminarClienteYCasos",
                            cn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@IdCliente",
                        idCliente);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine(
                        "Cliente y casos eliminados correctamente.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(
                    "Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Error: " + ex.Message);
            }
        }
    }
}