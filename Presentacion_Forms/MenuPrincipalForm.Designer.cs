namespace MiAppWinForms
{
    partial class MenuPrincipalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            btnModificarCaso = new Button();
            btnAgregarCliente = new Button();
            btnAdministrador = new Button();
            btnSalir = new Button();

            SuspendLayout();

            // lblBienvenida
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(300, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(83, 20);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";

            // btnModificarCaso
            btnModificarCaso.Location = new Point(280, 70);
            btnModificarCaso.Name = "btnModificarCaso";
            btnModificarCaso.Size = new Size(220, 50);
            btnModificarCaso.TabIndex = 1;
            btnModificarCaso.Text = "Modificar Estado Caso";
            btnModificarCaso.UseVisualStyleBackColor = true;
            btnModificarCaso.Click += btnModificarCaso_Click;

            // btnAgregarCliente
            btnAgregarCliente.Location = new Point(280, 140);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(220, 50);
            btnAgregarCliente.TabIndex = 2;
            btnAgregarCliente.Text = "Añadir Cliente y Caso";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;

            // btnAdministrador
            btnAdministrador.Location = new Point(280, 210);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(220, 50);
            btnAdministrador.TabIndex = 3;
            btnAdministrador.Text = "Administración";
            btnAdministrador.UseVisualStyleBackColor = true;
            btnAdministrador.Click += btnAdministrador_Click;

            // btnSalir
            btnSalir.Location = new Point(280, 280);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;

            // MenuPrincipalForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAdministrador);
            Controls.Add(btnAgregarCliente);
            Controls.Add(btnModificarCaso);
            Controls.Add(lblBienvenida);
            Name = "MenuPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            Load += MenuPrincipalForm_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnModificarCaso;
        private Button btnAgregarCliente;
        private Button btnAdministrador;
        private Button btnSalir;
    }
}