using Microsoft.Data.SqlClient;
using System.Data;

namespace TuProyecto
{
    public class Eliminar_Caso
    {
        public static void EliminarCaso()
        {
            try
            {
                Console.Write(
                    "Ingrese el ID del caso a eliminar: ");

                int idCaso =
                    int.Parse(Console.ReadLine());

                Conexion conexion =
                    new Conexion();

                using (SqlConnection cn =
                    conexion.Conectar())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_EliminarCaso",
                            cn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@IdCaso",
                        idCaso);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine(
                        "Caso eliminado correctamente.");
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