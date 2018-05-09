namespace WindowsFormsApp4
{
    partial class MenuAdmin
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
            this.LSalasDisponibles = new System.Windows.Forms.Label();
            this.LSalasNoDisponibles = new System.Windows.Forms.Label();
            this.LBSalasDisponibles = new System.Windows.Forms.ListBox();
            this.LBSalasNoDisponibles = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BCrearSala = new System.Windows.Forms.Button();
            this.BBorrarSala = new System.Windows.Forms.Button();
            this.BCastigarAlumno = new System.Windows.Forms.Button();
            this.BDesocuparSala = new System.Windows.Forms.Button();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.HeaderText = new System.Windows.Forms.Label();
            this.LUserInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LSalasDisponibles
            // 
            this.LSalasDisponibles.AutoSize = true;
            this.LSalasDisponibles.Location = new System.Drawing.Point(236, 43);
            this.LSalasDisponibles.Name = "LSalasDisponibles";
            this.LSalasDisponibles.Size = new System.Drawing.Size(90, 13);
            this.LSalasDisponibles.TabIndex = 0;
            this.LSalasDisponibles.Text = "Salas Disponibles";
            // 
            // LSalasNoDisponibles
            // 
            this.LSalasNoDisponibles.AutoSize = true;
            this.LSalasNoDisponibles.Location = new System.Drawing.Point(470, 43);
            this.LSalasNoDisponibles.Name = "LSalasNoDisponibles";
            this.LSalasNoDisponibles.Size = new System.Drawing.Size(109, 13);
            this.LSalasNoDisponibles.TabIndex = 1;
            this.LSalasNoDisponibles.Text = "Salas NO Disponibles";
            // 
            // LBSalasDisponibles
            // 
            this.LBSalasDisponibles.FormattingEnabled = true;
            this.LBSalasDisponibles.Location = new System.Drawing.Point(239, 67);
            this.LBSalasDisponibles.Name = "LBSalasDisponibles";
            this.LBSalasDisponibles.Size = new System.Drawing.Size(174, 277);
            this.LBSalasDisponibles.TabIndex = 2;
            // 
            // LBSalasNoDisponibles
            // 
            this.LBSalasNoDisponibles.FormattingEnabled = true;
            this.LBSalasNoDisponibles.Location = new System.Drawing.Point(462, 67);
            this.LBSalasNoDisponibles.Name = "LBSalasNoDisponibles";
            this.LBSalasNoDisponibles.Size = new System.Drawing.Size(174, 277);
            this.LBSalasNoDisponibles.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 245);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BCrearSala
            // 
            this.BCrearSala.Location = new System.Drawing.Point(138, 368);
            this.BCrearSala.Name = "BCrearSala";
            this.BCrearSala.Size = new System.Drawing.Size(120, 43);
            this.BCrearSala.TabIndex = 5;
            this.BCrearSala.Text = "Crear Sala";
            this.BCrearSala.UseVisualStyleBackColor = true;
            // 
            // BBorrarSala
            // 
            this.BBorrarSala.Location = new System.Drawing.Point(264, 368);
            this.BBorrarSala.Name = "BBorrarSala";
            this.BBorrarSala.Size = new System.Drawing.Size(120, 43);
            this.BBorrarSala.TabIndex = 6;
            this.BBorrarSala.Text = "Borrar Sala";
            this.BBorrarSala.UseVisualStyleBackColor = true;
            // 
            // BCastigarAlumno
            // 
            this.BCastigarAlumno.Location = new System.Drawing.Point(12, 368);
            this.BCastigarAlumno.Name = "BCastigarAlumno";
            this.BCastigarAlumno.Size = new System.Drawing.Size(120, 43);
            this.BCastigarAlumno.TabIndex = 7;
            this.BCastigarAlumno.Text = "Castigar Alumno";
            this.BCastigarAlumno.UseVisualStyleBackColor = true;
            // 
            // BDesocuparSala
            // 
            this.BDesocuparSala.Location = new System.Drawing.Point(390, 368);
            this.BDesocuparSala.Name = "BDesocuparSala";
            this.BDesocuparSala.Size = new System.Drawing.Size(120, 43);
            this.BDesocuparSala.TabIndex = 8;
            this.BDesocuparSala.Text = "Desocupar Sala";
            this.BDesocuparSala.UseVisualStyleBackColor = true;
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.Location = new System.Drawing.Point(516, 368);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(120, 43);
            this.BCerrarSesion.TabIndex = 9;
            this.BCerrarSesion.Text = "Cerrar Sesion";
            this.BCerrarSesion.UseVisualStyleBackColor = true;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.HeaderText.Location = new System.Drawing.Point(13, 9);
            this.HeaderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(197, 37);
            this.HeaderText.TabIndex = 10;
            this.HeaderText.Text = "Menu Admin";
            // 
            // LUserInfo
            // 
            this.LUserInfo.AutoSize = true;
            this.LUserInfo.Location = new System.Drawing.Point(13, 66);
            this.LUserInfo.Name = "LUserInfo";
            this.LUserInfo.Size = new System.Drawing.Size(0, 13);
            this.LUserInfo.TabIndex = 11;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 423);
            this.Controls.Add(this.LUserInfo);
            this.Controls.Add(this.HeaderText);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.BDesocuparSala);
            this.Controls.Add(this.BCastigarAlumno);
            this.Controls.Add(this.BBorrarSala);
            this.Controls.Add(this.BCrearSala);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBSalasNoDisponibles);
            this.Controls.Add(this.LBSalasDisponibles);
            this.Controls.Add(this.LSalasNoDisponibles);
            this.Controls.Add(this.LSalasDisponibles);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSalasDisponibles;
        private System.Windows.Forms.Label LSalasNoDisponibles;
        private System.Windows.Forms.ListBox LBSalasDisponibles;
        private System.Windows.Forms.ListBox LBSalasNoDisponibles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BCrearSala;
        private System.Windows.Forms.Button BBorrarSala;
        private System.Windows.Forms.Button BCastigarAlumno;
        private System.Windows.Forms.Button BDesocuparSala;
        private System.Windows.Forms.Button BCerrarSesion;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label LUserInfo;
    }
}