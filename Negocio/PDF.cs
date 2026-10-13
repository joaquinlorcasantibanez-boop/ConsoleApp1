using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1.Negocio
{
    public class GeneradorPDF
    {
        static GeneradorPDF()
        {
            QuestPDF.Settings.License =
                LicenseType.Community;
        }

        public static void PDFClienteCaso(
            int idCliente,
            string nombre,
            string celular,
            string correo,
            string descripcion)
        {
            string carpetaPDF =
                Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "PDF");

            Directory.CreateDirectory(
                carpetaPDF);

            string rutaArchivo =
                Path.Combine(
                    carpetaPDF,
                    $"Cliente_{idCliente}.pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);

                    page.Header()
                        .Text("COMPROBANTE DE REGISTRO")
                        .FontSize(20)
                        .Bold();

                    page.Content()
                        .Column(col =>
                        {
                            col.Item().Text(
                                $"ID Cliente: {idCliente}");

                            col.Item().Text(
                                $"Nombre: {nombre}");

                            col.Item().Text(
                                $"Celular: {celular}");

                            col.Item().Text(
                                $"Correo: {correo}");

                            col.Item().Text(
                                $"Descripción: {descripcion}");
                        });
                });
            })
            .GeneratePdf(rutaArchivo);

            Console.WriteLine(
                $"\nPDF generado en:\n{rutaArchivo}");
        }

        public static void PDFCasosPorEstado(
            string estado,
            List<string> casos)
        {
            string carpetaPDF =
                Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "PDF");

            Directory.CreateDirectory(
                carpetaPDF);

            string rutaArchivo =
                Path.Combine(
                    carpetaPDF,
                    $"Casos_{estado}.pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);

                    page.Header()
                        .Text($"CASOS {estado}")
                        .FontSize(20)
                        .Bold();

                    page.Content()
                        .Column(col =>
                        {
                            foreach (string caso in casos)
                            {
                                col.Item()
                                    .Text(caso);
                            }
                        });
                });
            })
            .GeneratePdf(rutaArchivo);

            Console.WriteLine(
                $"\nPDF generado en:\n{rutaArchivo}");
        }
    }
}