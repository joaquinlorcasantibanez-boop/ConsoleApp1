using Microsoft.Data.SqlClient;
using System.Data;

namespace TuProyecto
{
    public class Casos
    {
        public static void ActualizarEstadoCaso()
        {
            int intentos = 0;
            int maxIntentos = 3;

            while (intentos < maxIntentos)
            {
                try
                {
                    Console.Write("Ingrese el registro del caso: ");

                    int idCaso = int.Parse(
                        Console.ReadLine());

                    Conexion conexion = new Conexion();

                    using (SqlConnection cn =
                        conexion.Conectar())
                    {
                        SqlCommand cmd =
                            new SqlCommand(
                                "SP_ActualizarEstadoCaso",
                                cn);

                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue(
                            "@IdCaso",
                            idCaso);

                        cmd.ExecuteNonQuery();

                        Console.WriteLine(
                            "Estado actualizado correctamente.");

                        return;
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("El caso no existe"))
                    {
                        intentos++;

                        Console.ForegroundColor =
                            ConsoleColor.Red;

                        Console.WriteLine(
                            $"El caso no existe. Intento {intentos}/{maxIntentos}");

                        Console.ResetColor();

                        if (intentos >= maxIntentos)
                        {
                            Console.WriteLine(
                                "\nNo quedan más intentos.");

                            Thread.Sleep(3000);
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine(
                            "Error SQL: " + ex.Message);

                        return;
                    }
                }
                catch
                {
                    Console.WriteLine(
                        "Debe ingresar un número válido.");

                    return;
                }
            }
        }
    }
}