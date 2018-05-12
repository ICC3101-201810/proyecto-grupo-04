namespace WindowsFormsApp4
{
    partial class Menu
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
            this.FinalizarButton = new System.Windows.Forms.Button();
            this.CarritoLabel = new System.Windows.Forms.Label();
            this.Carrito = new System.Windows.Forms.ListBox();
            this.AccesoriosLabel = new System.Windows.Forms.Label();
            this.ListaAcsesorios = new System.Windows.Forms.ListBox();
            this.AgregarAccesoriosBotton = new System.Windows.Forms.Button();
            this.ArrendarSalaBotton = new System.Windows.Forms.Button();
            this.SalaDisponibeLabel = new System.Windows.Forms.Label();
            this.SalasDisponibles = new System.Windows.Forms.ListBox();
            this.HeaderText = new System.Windows.Forms.Label();
            this.SalaArrendadaLabel = new System.Windows.Forms.Label();
            this.SalaArrendadaL = new System.Windows.Forms.ListBox();
            this.TotalL = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinalizarButton
            // 
            this.FinalizarButton.Location = new System.Drawing.Point(643, 635);
            this.FinalizarButton.Name = "FinalizarButton";
            this.FinalizarButton.Size = new System.Drawing.Size(274, 36);
            this.FinalizarButton.TabIndex = 19;
            this.FinalizarButton.Text = "Finalizar";
            this.FinalizarButton.UseVisualStyleBackColor = true;
            this.FinalizarButton.Click += new System.EventHandler(this.FinalizarButton_Click);
            // 
            // CarritoLabel
            // 
            this.CarritoLabel.AutoSize = true;
            this.CarritoLabel.Location = new System.Drawing.Point(638, 124);
            this.CarritoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarritoLabel.Name = "CarritoLabel";
            this.CarritoLabel.Size = new System.Drawing.Size(70, 25);
            this.CarritoLabel.TabIndex = 18;
            this.CarritoLabel.Text = "Carrito";
            // 
            // Carrito
            // 
            this.Carrito.FormattingEnabled = true;
            this.Carrito.ItemHeight = 25;
            this.Carrito.Location = new System.Drawing.Point(644, 170);
            this.Carrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(273, 304);
            this.Carrito.TabIndex = 17;
            // 
            // AccesoriosLabel
            // 
            this.AccesoriosLabel.AutoSize = true;
            this.AccesoriosLabel.Location = new System.Drawing.Point(339, 124);
            this.AccesoriosLabel.Name = "AccesoriosLabel";
            this.AccesoriosLabel.Size = new System.Drawing.Size(109, 25);
            this.AccesoriosLabel.TabIndex = 16;
            this.AccesoriosLabel.Text = "Accesorios";
            // 
            // ListaAcsesorios
            // 
            this.ListaAcsesorios.FormattingEnabled = true;
            this.ListaAcsesorios.ItemHeight = 25;
            this.ListaAcsesorios.Location = new System.Drawing.Point(344, 170);
            this.ListaAcsesorios.Name = "ListaAcsesorios";
            this.ListaAcsesorios.Size = new System.Drawing.Size(274, 304);
            this.ListaAcsesorios.TabIndex = 15;
            this.ListaAcsesorios.SelectedIndexChanged += new System.EventHandler(this.ListaAcsesorios_SelectedIndexChanged);
            // 
            // AgregarAccesoriosBotton
            // 
            this.AgregarAccesoriosBotton.Location = new System.Drawing.Point(344, 635);
            this.AgregarAccesoriosBotton.Name = "AgregarAccesoriosBotton";
            this.AgregarAccesoriosBotton.Size = new System.Drawing.Size(274, 36);
            this.AgregarAccesoriosBotton.TabIndex = 14;
            this.AgregarAccesoriosBotton.Text = "Agregar Accesorios";
            this.AgregarAccesoriosBotton.UseVisualStyleBackColor = true;
            this.AgregarAccesoriosBotton.Click += new System.EventHandler(this.AgregarAccesoriosBotton_Click);
            // 
            // ArrendarSalaBotton
            // 
            this.ArrendarSalaBotton.Location = new System.Drawing.Point(44, 635);
            this.ArrendarSalaBotton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArrendarSalaBotton.Name = "ArrendarSalaBotton";
            this.ArrendarSalaBotton.Size = new System.Drawing.Size(273, 36);
            this.ArrendarSalaBotton.TabIndex = 13;
            this.ArrendarSalaBotton.Text = "Arrendar Sala";
            this.ArrendarSalaBotton.UseVisualStyleBackColor = true;
            this.ArrendarSalaBotton.Click += new System.EventHandler(this.ArrendarSalaBotton_Click);
            // 
            // SalaDisponibeLabel
            // 
            this.SalaDisponibeLabel.AutoSize = true;
            this.SalaDisponibeLabel.Location = new System.Drawing.Point(39, 124);
            this.SalaDisponibeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalaDisponibeLabel.Name = "SalaDisponibeLabel";
            this.SalaDisponibeLabel.Size = new System.Drawing.Size(168, 25);
            this.SalaDisponibeLabel.TabIndex = 12;
            this.SalaDisponibeLabel.Text = "Salas Disponibles";
            // 
            // SalasDisponibles
            // 
            this.SalasDisponibles.FormattingEnabled = true;
            this.SalasDisponibles.ItemHeight = 25;
            this.SalasDisponibles.Location = new System.Drawing.Point(44, 170);
            this.SalasDisponibles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalasDisponibles.Name = "SalasDisponibles";
            this.SalasDisponibles.Size = new System.Drawing.Size(273, 304);
            this.SalasDisponibles.TabIndex = 11;
            this.SalasDisponibles.SelectedIndexChanged += new System.EventHandler(this.SalasDisponibles_SelectedIndexChanged);
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.HeaderText.Location = new System.Drawing.Point(36, 20);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(119, 46);
            this.HeaderText.TabIndex = 10;
            this.HeaderText.Text = "Menu";
            // 
            // SalaArrendadaLabel
            // 
            this.SalaArrendadaLabel.AutoSize = true;
            this.SalaArrendadaLabel.Location = new System.Drawing.Point(39, 506);
            this.SalaArrendadaLabel.Name = "SalaArrendadaLabel";
            this.SalaArrendadaLabel.Size = new System.Drawing.Size(149, 25);
            this.SalaArrendadaLabel.TabIndex = 21;
            this.SalaArrendadaLabel.Text = "Sala Arrendada";
            // 
            // SalaArrendadaL
            // 
            this.SalaArrendadaL.FormattingEnabled = true;
            this.SalaArrendadaL.ItemHeight = 25;
            this.SalaArrendadaL.Location = new System.Drawing.Point(44, 553);
            this.SalaArrendadaL.Name = "SalaArrendadaL";
            this.SalaArrendadaL.Size = new System.Drawing.Size(273, 29);
            this.SalaArrendadaL.TabIndex = 22;
            // 
            // TotalL
            // 
            this.TotalL.FormattingEnabled = true;
            this.TotalL.ItemHeight = 25;
            this.TotalL.Location = new System.Drawing.Point(643, 553);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(273, 29);
            this.TotalL.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(952, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalL);
            this.Controls.Add(this.SalaArrendadaL);
            this.Controls.Add(this.SalaArrendadaLabel);
            this.Controls.Add(this.FinalizarButton);
            this.Controls.Add(this.CarritoLabel);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.AccesoriosLabel);
            this.Controls.Add(this.ListaAcsesorios);
            this.Controls.Add(this.AgregarAccesoriosBotton);
            this.Controls.Add(this.ArrendarSalaBotton);
            this.Controls.Add(this.SalaDisponibeLabel);
            this.Controls.Add(this.SalasDisponibles);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = " Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FinalizarButton;
        private System.Windows.Forms.Label CarritoLabel;
        private System.Windows.Forms.ListBox Carrito;
        private System.Windows.Forms.Label AccesoriosLabel;
        private System.Windows.Forms.ListBox ListaAcsesorios;
        private System.Windows.Forms.Button AgregarAccesoriosBotton;
        private System.Windows.Forms.Button ArrendarSalaBotton;
        private System.Windows.Forms.Label SalaDisponibeLabel;
        private System.Windows.Forms.ListBox SalasDisponibles;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label SalaArrendadaLabel;
        private System.Windows.Forms.ListBox SalaArrendadaL;
        private System.Windows.Forms.ListBox TotalL;
        private System.Windows.Forms.Label label1;
    }
}

