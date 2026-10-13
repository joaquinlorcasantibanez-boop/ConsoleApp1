using static System.Net.Mime.MediaTypeNames;

namespace MiAppWinForms
{
    partial class ModificarEstadoCasoForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblIdCaso;
        private TextBox txtIdCaso;
        private Button btnActualizar;
        private Button btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblIdCaso = new Label();
            txtIdCaso = new TextBox();
            btnActualizar = new Button();
            btnVolver = new Button();

            SuspendLayout();

            // lblIdCaso
            lblIdCaso.AutoSize = true;
            lblIdCaso.Location = new Point(30, 40);
            lblIdCaso.Text = "ID del Caso";

            // txtIdCaso
            txtIdCaso.Location = new Point(130, 40);
            txtIdCaso.Size = new Size(200, 27);

            // btnActualizar
            btnActualizar.Location = new Point(130, 100);
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;

            // btnVolver
            btnVolver.Location = new Point(270, 100);
            btnVolver.Size = new Size(120, 40);
            btnVolver.Text = "Volver";
            btnVolver.Click += btnVolver_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 200);

            Controls.Add(lblIdCaso);
            Controls.Add(txtIdCaso);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Estado Caso";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}