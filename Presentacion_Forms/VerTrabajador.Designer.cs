namespace MiAppWinForms
{
    partial class VerTrabajador
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblId;
        private TextBox txtId;
        private Button btnBuscar;

        private Label lblNombre;
        private Label lblCorreo;
        private Label lblCelular;
        private Label lblCargo;

        private void InitializeComponent()
        {
            lblId = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();

            lblNombre = new Label();
            lblCorreo = new Label();
            lblCelular = new Label();
            lblCargo = new Label();

            SuspendLayout();

            lblId.AutoSize = true;
            lblId.Location = new Point(25, 30);
            lblId.Text = "ID Trabajador";

            txtId.Location = new Point(130, 30);
            txtId.Size = new Size(150, 27);

            btnBuscar.Location = new Point(300, 28);
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;

            lblNombre.Location = new Point(25, 100);
            lblNombre.Size = new Size(500, 30);

            lblCorreo.Location = new Point(25, 140);
            lblCorreo.Size = new Size(500, 30);

            lblCelular.Location = new Point(25, 180);
            lblCelular.Size = new Size(500, 30);

            lblCargo.Location = new Point(25, 220);
            lblCargo.Size = new Size(500, 30);

            ClientSize = new Size(600, 300);

            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnBuscar);

            Controls.Add(lblNombre);
            Controls.Add(lblCorreo);
            Controls.Add(lblCelular);
            Controls.Add(lblCargo);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Trabajador";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}