namespace MiAppWinForms
{
    public partial class AdministracionForm : Form
    {
        public AdministracionForm()
        {
            InitializeComponent();
        }

        private void btnVerTrabajador_Click(object sender, EventArgs e)
        {
            VerTrabajador frm = new VerTrabajador();

            frm.ShowDialog();
        }

        private void btnVerCasos_Click(object sender, EventArgs e)
        {
            VerCasos frm = new VerCasos();

            frm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}