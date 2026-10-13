using Microsoft.Data.SqlClient;
using System.Data;
using TuProyecto;

namespace MiAppWinForms
{
    public partial class VerCasos : Form
    {
        public VerCasos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int estado =
                    cboEstado.SelectedIndex == 0 ? 1 : 0;

                Conexion conexion = new Conexion();

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

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable tabla =
                        new DataTable();

                    da.Fill(tabla);

                    dgvCasos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}