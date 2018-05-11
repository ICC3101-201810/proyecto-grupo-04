namespace WindowsFormsApp4
{
    partial class CastigarAlumno
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
            this.LNombreAlumno = new System.Windows.Forms.Label();
            this.LRutAlumno = new System.Windows.Forms.Label();
            this.LMailAlumno = new System.Windows.Forms.Label();
            this.LMensaje = new System.Windows.Forms.Label();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.CBNoDevolvioSala = new System.Windows.Forms.CheckBox();
            this.CBNoDevolvioAccesorio = new System.Windows.Forms.CheckBox();
            this.CBDevolvioSalaSucia = new System.Windows.Forms.CheckBox();
            this.CBSalaMalEstado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LNombreAlumno
            // 
            this.LNombreAlumno.AutoSize = true;
            this.LNombreAlumno.Location = new System.Drawing.Point(3, 36);
            this.LNombreAlumno.Name = "LNombreAlumno";
            this.LNombreAlumno.Size = new System.Drawing.Size(79, 13);
            this.LNombreAlumno.TabIndex = 8;
            this.LNombreAlumno.Text = "NombreAlumno";
            // 
            // LRutAlumno
            // 
            this.LRutAlumno.AutoSize = true;
            this.LRutAlumno.Location = new System.Drawing.Point(3, 59);
            this.LRutAlumno.Name = "LRutAlumno";
            this.LRutAlumno.Size = new System.Drawing.Size(59, 13);
            this.LRutAlumno.TabIndex = 9;
            this.LRutAlumno.Text = "RutAlumno";
            // 
            // LMailAlumno
            // 
            this.LMailAlumno.AutoSize = true;
            this.LMailAlumno.Location = new System.Drawing.Point(3, 82);
            this.LMailAlumno.Name = "LMailAlumno";
            this.LMailAlumno.Size = new System.Drawing.Size(61, 13);
            this.LMailAlumno.TabIndex = 10;
            this.LMailAlumno.Text = "MailAlumno";
            // 
            // LMensaje
            // 
            this.LMensaje.AutoSize = true;
            this.LMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMensaje.Location = new System.Drawing.Point(2, 9);
            this.LMensaje.Name = "LMensaje";
            this.LMensaje.Size = new System.Drawing.Size(149, 20);
            this.LMensaje.TabIndex = 11;
            this.LMensaje.Text = "Esta Por Notificar a:";
            // 
            // BAceptar
            // 
            this.BAceptar.Location = new System.Drawing.Point(6, 211);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(82, 29);
            this.BAceptar.TabIndex = 12;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(107, 211);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(82, 29);
            this.BCancelar.TabIndex = 13;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // CBNoDevolvioSala
            // 
            this.CBNoDevolvioSala.AutoSize = true;
            this.CBNoDevolvioSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNoDevolvioSala.Location = new System.Drawing.Point(6, 98);
            this.CBNoDevolvioSala.Name = "CBNoDevolvioSala";
            this.CBNoDevolvioSala.Size = new System.Drawing.Size(119, 19);
            this.CBNoDevolvioSala.TabIndex = 14;
            this.CBNoDevolvioSala.Text = "No Devolvio Sala";
            this.CBNoDevolvioSala.UseVisualStyleBackColor = true;
            // 
            // CBNoDevolvioAccesorio
            // 
            this.CBNoDevolvioAccesorio.AutoSize = true;
            this.CBNoDevolvioAccesorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBNoDevolvioAccesorio.Location = new System.Drawing.Point(6, 123);
            this.CBNoDevolvioAccesorio.Name = "CBNoDevolvioAccesorio";
            this.CBNoDevolvioAccesorio.Size = new System.Drawing.Size(147, 19);
            this.CBNoDevolvioAccesorio.TabIndex = 15;
            this.CBNoDevolvioAccesorio.Text = "No Devolvio Accesorio";
            this.CBNoDevolvioAccesorio.UseVisualStyleBackColor = true;
            // 
            // CBDevolvioSalaSucia
            // 
            this.CBDevolvioSalaSucia.AutoSize = true;
            this.CBDevolvioSalaSucia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDevolvioSalaSucia.Location = new System.Drawing.Point(6, 173);
            this.CBDevolvioSalaSucia.Name = "CBDevolvioSalaSucia";
            this.CBDevolvioSalaSucia.Size = new System.Drawing.Size(134, 19);
            this.CBDevolvioSalaSucia.TabIndex = 17;
            this.CBDevolvioSalaSucia.Text = "Devolvio Sala Sucia";
            this.CBDevolvioSalaSucia.UseVisualStyleBackColor = true;
            // 
            // CBSalaMalEstado
            // 
            this.CBSalaMalEstado.AutoSize = true;
            this.CBSalaMalEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSalaMalEstado.Location = new System.Drawing.Point(6, 148);
            this.CBSalaMalEstado.Name = "CBSalaMalEstado";
            this.CBSalaMalEstado.Size = new System.Drawing.Size(116, 19);
            this.CBSalaMalEstado.TabIndex = 16;
            this.CBSalaMalEstado.Text = "Sala Mal Estado";
            this.CBSalaMalEstado.UseVisualStyleBackColor = true;
            // 
            // CastigarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 252);
            this.Controls.Add(this.CBDevolvioSalaSucia);
            this.Controls.Add(this.CBSalaMalEstado);
            this.Controls.Add(this.CBNoDevolvioAccesorio);
            this.Controls.Add(this.CBNoDevolvioSala);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.LMensaje);
            this.Controls.Add(this.LMailAlumno);
            this.Controls.Add(this.LRutAlumno);
            this.Controls.Add(this.LNombreAlumno);
            this.MaximizeBox = false;
            this.Name = "CastigarAlumno";
            this.ShowIcon = false;
            this.Text = "CastigarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LNombreAlumno;
        private System.Windows.Forms.Label LRutAlumno;
        private System.Windows.Forms.Label LMailAlumno;
        private System.Windows.Forms.Label LMensaje;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.CheckBox CBNoDevolvioSala;
        private System.Windows.Forms.CheckBox CBNoDevolvioAccesorio;
        private System.Windows.Forms.CheckBox CBDevolvioSalaSucia;
        private System.Windows.Forms.CheckBox CBSalaMalEstado;
    }
}