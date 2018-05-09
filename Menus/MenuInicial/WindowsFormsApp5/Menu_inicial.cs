using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String apellido = textBox3.Text;
            String mail = textBox2.Text;
            String cargo = comboBox1.Text;
            MessageBox.Show("Usted ha ingresado a " + nombre+" " + apellido);
            StreamWriter archivo;
            archivo = File.AppendText("datos.txt");
            archivo.WriteLine(nombre + " " + apellido + " " + mail+" "+cargo);
            archivo.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("grazie per aver utilizzato il programma, torna presto");
            this.Close();
             
        }
    }
}
