using static System.Net.Mime.MediaTypeNames;

namespace MiAppWinForms
{
    partial class AdministracionForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Button btnVerTrabajador;
        private Button btnVerCasos;
        private Button btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnVerTrabajador = new Button();
            btnVerCasos = new Button();
            btnVolver = new Button();

            SuspendLayout();

            // lblTitulo
            lblTitulo.Font = new System.Drawing.Font(
             "Segoe UI",
              14F,
              FontStyle.Bold);

            // btnVerTrabajador
            btnVerTrabajador.Location = new Point(240, 120);
            btnVerTrabajador.Size = new Size(250, 50);
            btnVerTrabajador.Text = "Ver Trabajador";
            btnVerTrabajador.Click += btnVerTrabajador_Click;

            // btnVerCasos
            btnVerCasos.Location = new Point(240, 200);
            btnVerCasos.Size = new Size(250, 50);
            btnVerCasos.Text = "Ver Casos por Estado";
            btnVerCasos.Click += btnVerCasos_Click;

            // btnVolver
            btnVolver.Location = new Point(240, 280);
            btnVolver.Size = new Size(250, 50);
            btnVolver.Text = "Volver";
            btnVolver.Click += btnVolver_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);

            Controls.Add(lblTitulo);
            Controls.Add(btnVerTrabajador);
            Controls.Add(btnVerCasos);
            Controls.Add(btnVolver);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}