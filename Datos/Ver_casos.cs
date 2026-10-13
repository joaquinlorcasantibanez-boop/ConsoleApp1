using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using ConsoleApp1.Negocio;

namespace TuProyecto
{
    public class Ver_Casos_Por_Estado
    {
        public static void MostrarCasos()
        {
            try
            {
                Console.Write(
                    "Ingrese el estado del caso: ");

                if (!int.TryParse(
                    Console.ReadLine(),
                    out int estado))
                {
                    return;
                }

                if (estado != 0 &&
                    estado != 1)
                {
                    return;
                }

                Conexion conexion =
                    new Conexion();

                using (SqlConnection cn =
                    conexion.Conectar())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "sp_CasosPorEstado",
                            cn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@Estado",
                        estado);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        Console.WriteLine(
                            "\nNo se encontraron casos.");

                        return;
                    }

                    string estadoTexto =
                        estado == 1
                        ? "En Proceso"
                        : "Terminado";

                    List<string> listado =
                        new List<string>();

                    Console.WriteLine(
                        "\n===== LISTADO DE CASOS =====");

                    while (dr.Read())
                    {
                        string linea =
                            $"ID:{dr["IdCaso"]} | Cliente:{dr["IdCliente"]} | {dr["Descripcion"]}";

                        listado.Add(linea);

                        Console.WriteLine(
                            $"\nID Caso: {dr["IdCaso"]}");

                        Console.WriteLine(
                            $"Descripción: {dr["Descripcion"]}");

                        Console.WriteLine(
                            $"ID Cliente: {dr["IdCliente"]}");

                        Console.WriteLine(
                            $"Estado: {estadoTexto}");
                    }

                    GeneradorPDF.PDFCasosPorEstado(
                        estadoTexto,
                        listado);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(
                    "Error SQL: " +
                    ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Error: " +
                    ex.Message);
            }
        }
    }
}