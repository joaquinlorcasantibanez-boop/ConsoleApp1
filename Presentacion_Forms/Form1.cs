using Microsoft.Data.SqlClient;
using System.Data;
using ConsoleApp1.Negocio;
using TuProyecto;

namespace MiAppWinForms
{
    public partial class AñadirClienteCasoForm : Form
    {
        public AñadirClienteCasoForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string celular = txtCelular.Text;
                string correo = txtCorreo.Text;
                string descripcion = txtDescripcion.Text;

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.Conectar())
                {
                    SqlCommand cmdCliente =
                        new SqlCommand(
                            "SP_InsertarCliente",
                            cn);

                    cmdCliente.CommandType =
                        CommandType.StoredProcedure;

                    cmdCliente.Parameters.AddWithValue(
                        "@Nombre",
                        nombre);

                    cmdCliente.Parameters.AddWithValue(
                        "@Celular",
                        celular);

                    cmdCliente.Parameters.AddWithValue(
                        "@Correo",
                        correo);

                    int idCliente =
                        Convert.ToInt32(
                            cmdCliente.ExecuteScalar());

                    SqlCommand cmdCaso =
                        new SqlCommand(
                            "SP_InsertarCaso",
                            cn);

                    cmdCaso.CommandType =
                        CommandType.StoredProcedure;

                    cmdCaso.Parameters.AddWithValue(
                        "@Descripcion",
                        descripcion);

                    cmdCaso.Parameters.AddWithValue(
                        "@Estado",
                        1);

                    cmdCaso.Parameters.AddWithValue(
                        "@IdCliente",
                        idCliente);

                    cmdCaso.ExecuteNonQuery();

                    GeneradorPDF.PDFClienteCaso(
                        idCliente,
                        nombre,
                        celular,
                        correo,
                        descripcion);

                    MessageBox.Show(
                        $"Cliente creado correctamente.\nN° Orden: {idCliente}",
                        "Registro exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtCelular.Clear();
                    txtCorreo.Clear();
                    txtDescripcion.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}