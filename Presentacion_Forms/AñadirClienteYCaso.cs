using static System.Net.Mime.MediaTypeNames;

namespace MiAppWinForms
{
    partial class AñadirClienteCasoForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblNombre;
        private Label lblCelular;
        private Label lblCorreo;
        private Label lblDescripcion;

        private TextBox txtNombre;
        private TextBox txtCelular;
        private TextBox txtCorreo;
        private TextBox txtDescripcion;

        private Button btnGuardar;
        private Button btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblCelular = new Label();
            lblCorreo = new Label();
            lblDescripcion = new Label();

            txtNombre = new TextBox();
            txtCelular = new TextBox();
            txtCorreo = new TextBox();
            txtDescripcion = new TextBox();

            btnGuardar = new Button();
            btnVolver = new Button();

            SuspendLayout();

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 30);
            lblNombre.Text = "Nombre";

            // txtNombre
            txtNombre.Location = new Point(140, 30);
            txtNombre.Size = new Size(300, 27);

            // lblCelular
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(30, 80);
            lblCelular.Text = "Celular";

            // txtCelular
            txtCelular.Location = new Point(140, 80);
            txtCelular.Size = new Size(300, 27);

            // lblCorreo
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(30, 130);
            lblCorreo.Text = "Correo";

            // txtCorreo
            txtCorreo.Location = new Point(140, 130);
            txtCorreo.Size = new Size(300, 27);

            // lblDescripcion
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(30, 180);
            lblDescripcion.Text = "Descripción";

            // txtDescripcion
            txtDescripcion.Location = new Point(140, 180);
            txtDescripcion.Multiline = true;
            txtDescripcion.Size = new Size(300, 120);

            // btnGuardar
            btnGuardar.Location = new Point(140, 330);
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;

            // btnVolver
            btnVolver.Location = new Point(320, 330);
            btnVolver.Size = new Size(120, 40);
            btnVolver.Text = "Volver";
            btnVolver.Click += btnVolver_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 420);

            Controls.Add(lblNombre);
            Controls.Add(txtNombre);

            Controls.Add(lblCelular);
            Controls.Add(txtCelular);

            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);

            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);

            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Cliente y Caso";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
