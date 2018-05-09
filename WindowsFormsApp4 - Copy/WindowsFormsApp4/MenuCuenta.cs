using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class MenuCuenta : Form
    {
        Thread th;
        public MenuCuenta()
        {
            InitializeComponent();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (TBNombre.Text != "" && TBApellido.Text != "" && TBMail.Text != "" && TBContraseña.Text != "" && CBCargo.Text != "")
            {
                string nombre = TBNombre.Text;
                string apellido = TBApellido.Text;
                string mail = TBMail.Text;
                string password = TBContraseña.Text;
                string cargo = CBCargo.Text;
                MessageBox.Show("EXITOOO");
                TBNombre.Clear();
                TBApellido.Clear();
                TBContraseña.Clear();
                TBMail.Clear();
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new Login());
        }
    }
}
