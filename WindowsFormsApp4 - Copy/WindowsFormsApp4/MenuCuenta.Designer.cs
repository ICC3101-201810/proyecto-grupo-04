namespace WindowsFormsApp4
{
    partial class MenuCuenta
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
            this.PBMenuCuenta = new System.Windows.Forms.PictureBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LMail = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LCargo = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.LPassword = new System.Windows.Forms.Label();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.HTMenuCuenta = new System.Windows.Forms.Label();
            this.GBMenuCuenta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenuCuenta)).BeginInit();
            this.GBMenuCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMenuCuenta
            // 
            this.PBMenuCuenta.Location = new System.Drawing.Point(17, 48);
            this.PBMenuCuenta.Name = "PBMenuCuenta";
            this.PBMenuCuenta.Size = new System.Drawing.Size(138, 137);
            this.PBMenuCuenta.TabIndex = 0;
            this.PBMenuCuenta.TabStop = false;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(161, 48);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LMail
            // 
            this.LMail.AutoSize = true;
            this.LMail.Location = new System.Drawing.Point(161, 108);
            this.LMail.Name = "LMail";
            this.LMail.Size = new System.Drawing.Size(26, 13);
            this.LMail.TabIndex = 2;
            this.LMail.Text = "Mail";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(161, 79);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            // 
            // LCargo
            // 
            this.LCargo.AutoSize = true;
            this.LCargo.Location = new System.Drawing.Point(161, 172);
            this.LCargo.Name = "LCargo";
            this.LCargo.Size = new System.Drawing.Size(35, 13);
            this.LCargo.TabIndex = 4;
            this.LCargo.Text = "Cargo";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(228, 45);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(263, 20);
            this.TBNombre.TabIndex = 5;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(228, 76);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(263, 20);
            this.TBApellido.TabIndex = 6;
            // 
            // TBMail
            // 
            this.TBMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TBMail.Location = new System.Drawing.Point(228, 105);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(263, 20);
            this.TBMail.TabIndex = 7;
            // 
            // CBCargo
            // 
            this.CBCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCargo.Items.AddRange(new object[] {
            "ADMIN",
            "ALUMNO",
            "PROFESOR"});
            this.CBCargo.Location = new System.Drawing.Point(228, 164);
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.Size = new System.Drawing.Size(104, 21);
            this.CBCargo.TabIndex = 9;
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(17, 227);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(138, 36);
            this.BAceptar.TabIndex = 10;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(164, 227);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(168, 36);
            this.BSalir.TabIndex = 11;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(161, 137);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(61, 13);
            this.LPassword.TabIndex = 11;
            this.LPassword.Text = "Contraseña";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(228, 134);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(263, 20);
            this.TBContraseña.TabIndex = 8;
            // 
            // HTMenuCuenta
            // 
            this.HTMenuCuenta.AutoSize = true;
            this.HTMenuCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.HTMenuCuenta.Location = new System.Drawing.Point(10, 0);
            this.HTMenuCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HTMenuCuenta.Name = "HTMenuCuenta";
            this.HTMenuCuenta.Size = new System.Drawing.Size(366, 37);
            this.HTMenuCuenta.TabIndex = 13;
            this.HTMenuCuenta.Text = "Cree Una Nueva Cuenta";
            // 
            // GBMenuCuenta
            // 
            this.GBMenuCuenta.Controls.Add(this.HTMenuCuenta);
            this.GBMenuCuenta.Controls.Add(this.TBContraseña);
            this.GBMenuCuenta.Controls.Add(this.LPassword);
            this.GBMenuCuenta.Controls.Add(this.BSalir);
            this.GBMenuCuenta.Controls.Add(this.BAceptar);
            this.GBMenuCuenta.Controls.Add(this.CBCargo);
            this.GBMenuCuenta.Controls.Add(this.TBMail);
            this.GBMenuCuenta.Controls.Add(this.TBApellido);
            this.GBMenuCuenta.Controls.Add(this.TBNombre);
            this.GBMenuCuenta.Controls.Add(this.LCargo);
            this.GBMenuCuenta.Controls.Add(this.LApellido);
            this.GBMenuCuenta.Controls.Add(this.LMail);
            this.GBMenuCuenta.Controls.Add(this.LNombre);
            this.GBMenuCuenta.Controls.Add(this.PBMenuCuenta);
            this.GBMenuCuenta.Location = new System.Drawing.Point(3, 9);
            this.GBMenuCuenta.Name = "GBMenuCuenta";
            this.GBMenuCuenta.Size = new System.Drawing.Size(497, 267);
            this.GBMenuCuenta.TabIndex = 0;
            this.GBMenuCuenta.TabStop = false;
            // 
            // MenuCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 288);
            this.Controls.Add(this.GBMenuCuenta);
            this.Name = "MenuCuenta";
            this.Text = "MenuCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.PBMenuCuenta)).EndInit();
            this.GBMenuCuenta.ResumeLayout(false);
            this.GBMenuCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBMenuCuenta;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LMail;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LCargo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.Label HTMenuCuenta;
        private System.Windows.Forms.GroupBox GBMenuCuenta;
        private System.Windows.Forms.ComboBox CBCargo;
    }
}