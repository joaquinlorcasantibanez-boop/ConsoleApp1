using Microsoft.Data.SqlClient;
using System.Data;
using TuProyecto;

namespace MiAppWinForms
{
    public partial class VerTrabajador : Form
    {
        public VerTrabajador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idTrabajador =
                    Convert.ToInt32(txtId.Text);

                Conexion conexion = new Conexion();

                using (SqlConnection cn =
                    conexion.Conectar())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_BuscarTrabajadorPorId",
                            cn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@IdTrabajador",
                        idTrabajador);

                    SqlDataReader dr =
                        cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblNombre.Text =
                            $"Nombre: {dr["Nombre"]}";

                        lblCorreo.Text =
                            $"Correo: {dr["Correo"]}";

                        lblCelular.Text =
                            $"Celular: {dr["Celular"]}";

                        lblCargo.Text =
                            $"Cargo: {dr["Cargo"]}";
                    }
                    else
                    {
                        MessageBox.Show(
                            "Trabajador no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}