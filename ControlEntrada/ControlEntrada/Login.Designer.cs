namespace ControlEntrada
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Registro = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.usuarioLogin = new System.Windows.Forms.Label();
            this.tbUsuarioLogin = new System.Windows.Forms.TextBox();
            this.ContrasenaLogin = new System.Windows.Forms.Label();
            this.tbContraseñaLogin = new System.Windows.Forms.TextBox();
            this.entrarLogin = new System.Windows.Forms.Button();
            this.salirLogin = new System.Windows.Forms.Button();
            this.contenedorLogin = new System.Windows.Forms.GroupBox();
            this.contenedorLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.Color.White;
            this.Registro.Location = new System.Drawing.Point(81, 38);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(146, 40);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "       Registro \r\nEntrada y Salida ";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(84, 91);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(140, 13);
            this.version.TabIndex = 1;
            this.version.Text = "CBI Ver 1.0 21-02-2023";
            // 
            // usuarioLogin
            // 
            this.usuarioLogin.AutoSize = true;
            this.usuarioLogin.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLogin.ForeColor = System.Drawing.Color.White;
            this.usuarioLogin.Location = new System.Drawing.Point(78, 34);
            this.usuarioLogin.Name = "usuarioLogin";
            this.usuarioLogin.Size = new System.Drawing.Size(63, 18);
            this.usuarioLogin.TabIndex = 2;
            this.usuarioLogin.Text = "Usuario";
            // 
            // tbUsuarioLogin
            // 
            this.tbUsuarioLogin.Location = new System.Drawing.Point(22, 55);
            this.tbUsuarioLogin.Name = "tbUsuarioLogin";
            this.tbUsuarioLogin.Size = new System.Drawing.Size(174, 20);
            this.tbUsuarioLogin.TabIndex = 3;
            // 
            // ContrasenaLogin
            // 
            this.ContrasenaLogin.AutoSize = true;
            this.ContrasenaLogin.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaLogin.ForeColor = System.Drawing.Color.White;
            this.ContrasenaLogin.Location = new System.Drawing.Point(64, 127);
            this.ContrasenaLogin.Name = "ContrasenaLogin";
            this.ContrasenaLogin.Size = new System.Drawing.Size(90, 18);
            this.ContrasenaLogin.TabIndex = 4;
            this.ContrasenaLogin.Text = "Contraseña";
            // 
            // tbContraseñaLogin
            // 
            this.tbContraseñaLogin.Location = new System.Drawing.Point(22, 148);
            this.tbContraseñaLogin.Name = "tbContraseñaLogin";
            this.tbContraseñaLogin.Size = new System.Drawing.Size(174, 20);
            this.tbContraseñaLogin.TabIndex = 5;
            // 
            // entrarLogin
            // 
            this.entrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrarLogin.FlatAppearance.BorderSize = 0;
            this.entrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarLogin.ForeColor = System.Drawing.Color.White;
            this.entrarLogin.Location = new System.Drawing.Point(45, 395);
            this.entrarLogin.Name = "entrarLogin";
            this.entrarLogin.Size = new System.Drawing.Size(75, 26);
            this.entrarLogin.TabIndex = 6;
            this.entrarLogin.Text = "Entrar";
            this.entrarLogin.UseVisualStyleBackColor = true;
            // 
            // salirLogin
            // 
            this.salirLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirLogin.FlatAppearance.BorderSize = 0;
            this.salirLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirLogin.ForeColor = System.Drawing.Color.White;
            this.salirLogin.Location = new System.Drawing.Point(189, 395);
            this.salirLogin.Name = "salirLogin";
            this.salirLogin.Size = new System.Drawing.Size(75, 26);
            this.salirLogin.TabIndex = 7;
            this.salirLogin.Text = "Salir";
            this.salirLogin.UseVisualStyleBackColor = true;
            // 
            // contenedorLogin
            // 
            this.contenedorLogin.Controls.Add(this.usuarioLogin);
            this.contenedorLogin.Controls.Add(this.tbUsuarioLogin);
            this.contenedorLogin.Controls.Add(this.ContrasenaLogin);
            this.contenedorLogin.Controls.Add(this.tbContraseñaLogin);
            this.contenedorLogin.Location = new System.Drawing.Point(45, 134);
            this.contenedorLogin.Name = "contenedorLogin";
            this.contenedorLogin.Size = new System.Drawing.Size(219, 214);
            this.contenedorLogin.TabIndex = 8;
            this.contenedorLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(309, 468);
            this.Controls.Add(this.contenedorLogin);
            this.Controls.Add(this.salirLogin);
            this.Controls.Add(this.entrarLogin);
            this.Controls.Add(this.version);
            this.Controls.Add(this.Registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contenedorLogin.ResumeLayout(false);
            this.contenedorLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label usuarioLogin;
        private System.Windows.Forms.TextBox tbUsuarioLogin;
        private System.Windows.Forms.Label ContrasenaLogin;
        private System.Windows.Forms.TextBox tbContraseñaLogin;
        private System.Windows.Forms.Button entrarLogin;
        private System.Windows.Forms.Button salirLogin;
        private System.Windows.Forms.GroupBox contenedorLogin;
    }
}

