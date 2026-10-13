namespace MiAppWinForms
{
    partial class VerCasos
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnBuscar;
        private DataGridView dgvCasos;

        private void InitializeComponent()
        {
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnBuscar = new Button();
            dgvCasos = new DataGridView();

            SuspendLayout();

            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(20, 25);
            lblEstado.Text = "Estado";

            cboEstado.Location = new Point(90, 22);
            cboEstado.Size = new Size(200, 28);

            cboEstado.Items.Add("En Proceso");
            cboEstado.Items.Add("Terminado");

            btnBuscar.Location = new Point(310, 20);
            btnBuscar.Size = new Size(120, 30);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;

            dgvCasos.Location = new Point(20, 80);
            dgvCasos.Size = new Size(700, 300);

            ClientSize = new Size(750, 420);

            Controls.Add(lblEstado);
            Controls.Add(cboEstado);
            Controls.Add(btnBuscar);
            Controls.Add(dgvCasos);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Casos";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}