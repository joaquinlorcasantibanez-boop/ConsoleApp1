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
            ModificarEstadoCasoForm frm =
                new ModificarEstadoCasoForm();

            frm.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AñadirClienteCasoForm frm = new AñadirClienteCasoForm();
            frm.ShowDialog();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            AdministracionForm frm =
                new AdministracionForm();

            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}