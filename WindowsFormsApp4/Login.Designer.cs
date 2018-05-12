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
            this.BLogin.Location = new System.Drawing.Point(16, 305);
            this.BLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(140, 53);
            this.BLogin.TabIndex = 0;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(169, 305);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(140, 53);
            this.BSalir.TabIndex = 1;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LLCrearCuenta
            // 
            this.LLCrearCuenta.AutoSize = true;
            this.LLCrearCuenta.Location = new System.Drawing.Point(111, 378);
            this.LLCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLCrearCuenta.Name = "LLCrearCuenta";
            this.LLCrearCuenta.Size = new System.Drawing.Size(92, 17);
            this.LLCrearCuenta.TabIndex = 2;
            this.LLCrearCuenta.TabStop = true;
            this.LLCrearCuenta.Text = "Crear Cuenta";
            this.LLCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLCrearCuenta_LinkClicked);
            // 
            // TBUsername
            // 
            this.TBUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TBUsername.Location = new System.Drawing.Point(16, 73);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(289, 22);
            this.TBUsername.TabIndex = 3;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TBPassword.Location = new System.Drawing.Point(16, 165);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(289, 22);
            this.TBPassword.TabIndex = 4;
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsername.Location = new System.Drawing.Point(16, 44);
            this.LUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(110, 25);
            this.LUsername.TabIndex = 5;
            this.LUsername.Text = "Username";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.Location = new System.Drawing.Point(16, 137);
            this.LPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(113, 26);
            this.LPassword.TabIndex = 6;
            this.LPassword.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.FondoLogin;
            this.ClientSize = new System.Drawing.Size(321, 405);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LUsername);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.LLCrearCuenta);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
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