using TuProyecto;

namespace MiAppWinForms
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text =
                $"Bienvenido {SesionActual.Nombre}";

            if (SesionActual.Cargo != "Administrador")
            {
                btnAdministrador.Visible = false;
            }
        }

        private void btnModificarCaso_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}