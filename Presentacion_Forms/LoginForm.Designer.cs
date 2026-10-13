namespace MiAppWinForms;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Correo = new Label();
        Contraseña = new Label();
        txtCorreo = new TextBox();
        txtContraseña = new TextBox();
        btnIngresar = new Button();
        SuspendLayout();
        // 
        // Correo
        // 
        Correo.AutoSize = true;
        Correo.Location = new Point(12, 60);
        Correo.Name = "Correo";
        Correo.Size = new Size(57, 20);
        Correo.TabIndex = 0;
        Correo.Text = "Correo:";
        // 
        // Contraseña
        // 
        Contraseña.AutoSize = true;
        Contraseña.Location = new Point(12, 98);
        Contraseña.Name = "Contraseña";
        Contraseña.Size = new Size(86, 20);
        Contraseña.TabIndex = 1;
        Contraseña.Text = "Contraseña:";
        
        // 
        // txtCorreo
        // 
        txtCorreo.Location = new Point(75, 60);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(525, 27);
        txtCorreo.TabIndex = 2;
        
        // 
        // txtContraseña
        // 
        txtContraseña.Location = new Point(104, 98);
        txtContraseña.Name = "txtContraseña";
        txtContraseña.PasswordChar = '*';
        txtContraseña.Size = new Size(496, 27);
        txtContraseña.TabIndex = 3;
        txtContraseña.UseSystemPasswordChar = true;
        
        // 
        // btnIngresar
        // 
        btnIngresar.Location = new Point(247, 197);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(94, 29);
        btnIngresar.TabIndex = 4;
        btnIngresar.Text = "Ingresar";
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(701, 734);
        Controls.Add(btnIngresar);
        Controls.Add(txtContraseña);
        Controls.Add(txtCorreo);
        Controls.Add(Contraseña);
        Controls.Add(Correo);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Inicio De Sesion";
        
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Correo;
    private Label Contraseña;
    private TextBox txtCorreo;
    private TextBox txtContraseña;
    private Button btnIngresar;
}
