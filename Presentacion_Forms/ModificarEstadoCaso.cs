using Microsoft.Data.SqlClient;
using System.Data;
using TuProyecto;

namespace MiAppWinForms
{
    public partial class ModificarEstadoCasoForm : Form
    {
        public ModificarEstadoCasoForm()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCaso = Convert.ToInt32(txtIdCaso.Text);

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.Conectar())
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

                    MessageBox.Show(
                        "Estado actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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