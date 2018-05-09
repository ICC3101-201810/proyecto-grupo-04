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
            this.HeaderText = new System.Windows.Forms.Label();
            this.SalasDisponibles = new System.Windows.Forms.ListBox();
            this.SalaDisponibeLabel = new System.Windows.Forms.Label();
            this.ArrendarSalaBotton = new System.Windows.Forms.Button();
            this.AgregarAccesoriosBotton = new System.Windows.Forms.Button();
            this.ListaAcsesorios = new System.Windows.Forms.ListBox();
            this.AccesoriosLabel = new System.Windows.Forms.Label();
            this.Carrito = new System.Windows.Forms.ListBox();
            this.CarritoLabel = new System.Windows.Forms.Label();
            this.FinalizarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.HeaderText.Location = new System.Drawing.Point(18, 14);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(96, 37);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Menu";
            // 
            // SalasDisponibles
            // 
            this.SalasDisponibles.FormattingEnabled = true;
            this.SalasDisponibles.ItemHeight = 20;
            this.SalasDisponibles.Location = new System.Drawing.Point(13, 128);
            this.SalasDisponibles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalasDisponibles.Name = "SalasDisponibles";
            this.SalasDisponibles.Size = new System.Drawing.Size(273, 344);
            this.SalasDisponibles.TabIndex = 1;
            // 
            // SalaDisponibeLabel
            // 
            this.SalaDisponibeLabel.AutoSize = true;
            this.SalaDisponibeLabel.Location = new System.Drawing.Point(8, 73);
            this.SalaDisponibeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalaDisponibeLabel.Name = "SalaDisponibeLabel";
            this.SalaDisponibeLabel.Size = new System.Drawing.Size(135, 20);
            this.SalaDisponibeLabel.TabIndex = 2;
            this.SalaDisponibeLabel.Text = "Salas Disponibles";
            // 
            // ArrendarSalaBotton
            // 
            this.ArrendarSalaBotton.Location = new System.Drawing.Point(13, 515);
            this.ArrendarSalaBotton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArrendarSalaBotton.Name = "ArrendarSalaBotton";
            this.ArrendarSalaBotton.Size = new System.Drawing.Size(273, 36);
            this.ArrendarSalaBotton.TabIndex = 3;
            this.ArrendarSalaBotton.Text = "Arrendar Sala";
            this.ArrendarSalaBotton.UseVisualStyleBackColor = true;
            // 
            // AgregarAccesoriosBotton
            // 
            this.AgregarAccesoriosBotton.Location = new System.Drawing.Point(313, 515);
            this.AgregarAccesoriosBotton.Name = "AgregarAccesoriosBotton";
            this.AgregarAccesoriosBotton.Size = new System.Drawing.Size(274, 36);
            this.AgregarAccesoriosBotton.TabIndex = 4;
            this.AgregarAccesoriosBotton.Text = "Agregar Accesorios";
            this.AgregarAccesoriosBotton.UseVisualStyleBackColor = true;
            // 
            // ListaAcsesorios
            // 
            this.ListaAcsesorios.FormattingEnabled = true;
            this.ListaAcsesorios.ItemHeight = 20;
            this.ListaAcsesorios.Location = new System.Drawing.Point(313, 128);
            this.ListaAcsesorios.Name = "ListaAcsesorios";
            this.ListaAcsesorios.Size = new System.Drawing.Size(274, 344);
            this.ListaAcsesorios.TabIndex = 5;
            // 
            // AccesoriosLabel
            // 
            this.AccesoriosLabel.AutoSize = true;
            this.AccesoriosLabel.Location = new System.Drawing.Point(308, 73);
            this.AccesoriosLabel.Name = "AccesoriosLabel";
            this.AccesoriosLabel.Size = new System.Drawing.Size(87, 20);
            this.AccesoriosLabel.TabIndex = 6;
            this.AccesoriosLabel.Text = "Accesorios";
            // 
            // Carrito
            // 
            this.Carrito.FormattingEnabled = true;
            this.Carrito.ItemHeight = 20;
            this.Carrito.Location = new System.Drawing.Point(612, 128);
            this.Carrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(273, 344);
            this.Carrito.TabIndex = 7;
            // 
            // CarritoLabel
            // 
            this.CarritoLabel.AutoSize = true;
            this.CarritoLabel.Location = new System.Drawing.Point(607, 73);
            this.CarritoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarritoLabel.Name = "CarritoLabel";
            this.CarritoLabel.Size = new System.Drawing.Size(56, 20);
            this.CarritoLabel.TabIndex = 8;
            this.CarritoLabel.Text = "Carrito";
            // 
            // FinalizarButton
            // 
            this.FinalizarButton.Location = new System.Drawing.Point(612, 515);
            this.FinalizarButton.Name = "FinalizarButton";
            this.FinalizarButton.Size = new System.Drawing.Size(274, 36);
            this.FinalizarButton.TabIndex = 9;
            this.FinalizarButton.Text = "Finalizar";
            this.FinalizarButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 703);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = " Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox SalasDisponibles;
        private System.Windows.Forms.Label SalaDisponibeLabel;
        private System.Windows.Forms.Button ArrendarSalaBotton;
        private System.Windows.Forms.Button AgregarAccesoriosBotton;
        private System.Windows.Forms.ListBox ListaAcsesorios;
        private System.Windows.Forms.Label AccesoriosLabel;
        private System.Windows.Forms.ListBox Carrito;
        private System.Windows.Forms.Label CarritoLabel;
        private System.Windows.Forms.Button FinalizarButton;
    }
}

