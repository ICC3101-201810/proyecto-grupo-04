namespace WindowsFormsApp4
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BLogin = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.LLCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LUsername = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(12, 248);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(105, 43);
            this.BLogin.TabIndex = 0;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(127, 248);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(105, 43);
            this.BSalir.TabIndex = 1;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LLCrearCuenta
            // 
            this.LLCrearCuenta.AutoSize = true;
            this.LLCrearCuenta.Location = new System.Drawing.Point(83, 307);
            this.LLCrearCuenta.Name = "LLCrearCuenta";
            this.LLCrearCuenta.Size = new System.Drawing.Size(69, 13);
            this.LLCrearCuenta.TabIndex = 2;
            this.LLCrearCuenta.TabStop = true;
            this.LLCrearCuenta.Text = "Crear Cuenta";
            this.LLCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLCrearCuenta_LinkClicked);
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(12, 59);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(218, 20);
            this.TBUsername.TabIndex = 3;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(12, 134);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(218, 20);
            this.TBPassword.TabIndex = 4;
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsername.Location = new System.Drawing.Point(12, 36);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(83, 20);
            this.LUsername.TabIndex = 5;
            this.LUsername.Text = "Username";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.Location = new System.Drawing.Point(12, 111);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(86, 20);
            this.LPassword.TabIndex = 6;
            this.LPassword.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 329);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LLCrearCuenta);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.LinkLabel LLCrearCuenta;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LUsername;
        private System.Windows.Forms.Label LPassword;
    }
}