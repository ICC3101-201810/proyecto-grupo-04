using System;
using ClassLibrary2;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Menu : Form
    {
        private Edificio edificio = new Edificio();

        private List<Accesorio> carrito = new List<Accesorio>();
        BindingSource carritoBinding = new BindingSource();

        private List<int> total = new List<int>();
        BindingSource totalBinding = new BindingSource();

        private List<Sala> salaArrendada = new List<Sala>();
        BindingSource salaArrendadaBinding = new BindingSource();

        BindingSource salasBinding = new BindingSource();
        BindingSource accesoriosBinding = new BindingSource();
        public Menu()
        {
            InitializeComponent();
            SetupData();

            //ACCESORIOS DISPONIBLES
            accesoriosBinding.DataSource = edificio.accesorios;
            ListaAcsesorios.DataSource = accesoriosBinding;

            ListaAcsesorios.DisplayMember = "DisplayA";
            ListaAcsesorios.ValueMember = "DisplayA";

            //SALAS DISPONIBLES
            salasBinding.DataSource = edificio.salas;
            SalasDisponibles.DataSource = salasBinding;

            SalasDisponibles.ValueMember = "Display";
            SalasDisponibles.DisplayMember = "Display";

            //CARRITO
            carritoBinding.DataSource = carrito;
            Carrito.DataSource = carritoBinding;

            Carrito.DisplayMember = "DisplayA";
            Carrito.ValueMember = "DisplayA";

            //Sala Arrendada
            salaArrendadaBinding.DataSource = salaArrendada;
            SalaArrendadaL.DataSource = salaArrendadaBinding;

            SalaArrendadaL.ValueMember = "Display";
            SalaArrendadaL.DisplayMember = "Display";

            //Total Compra
            totalBinding.DataSource = total;
            TotalL.DataSource = totalBinding;

            SalaArrendadaL.ValueMember = "Display";
            
        }

        private void SetupData()
        {
            edificio.salas.Add(new Sala { ID = 2001 });
            edificio.salas.Add(new Sala { ID = 2002 });
            edificio.salas.Add(new Sala { ID = 2003 });
            edificio.salas.Add(new Sala { ID = 2004 });
            edificio.salas.Add(new Sala { ID = 2005 });
            edificio.salas.Add(new Sala { ID = 2006 });

            edificio.accesorios.Add(new Accesorio { nombre = "Computador", valor = 2000 });
            edificio.accesorios.Add(new Accesorio { nombre = "Plumon", valor = 1000 });
            edificio.accesorios.Add(new Accesorio { nombre = "Pizzara", valor= 500 });
            edificio.accesorios.Add(new Accesorio { nombre = "Pizza" ,valor= 10000});

            edificio.Nombre = "Biblioteca";
        }

        private void SalasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaAcsesorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarAccesoriosBotton_Click(object sender, EventArgs e)
        {
            Accesorio accserorioSelecionado = (Accesorio)ListaAcsesorios.SelectedItem;
            carrito.Add(accserorioSelecionado);
            carritoBinding.ResetBindings(false);
            
            int t = 0;
            foreach(Accesorio a in carrito)
            {
                t += a.valor;
            }
            if (total.Count == 0)
            {
                total.Add(t);
            }
            if (total.Count==1)
            {
                total[0] = t;
            }
            

            totalBinding.ResetBindings(false);

        }

        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            
            carrito.Clear();
            carritoBinding.ResetBindings(false);

            if (salaArrendada.Count == 1)
            {
                edificio.salasNo.Add(salaArrendada[0]);
                edificio.salas.Remove(salaArrendada[0]);
                salasBinding.ResetBindings(false);
            }

            salaArrendada.Clear();
            salaArrendadaBinding.ResetBindings(false);

            total.Clear();
            totalBinding.ResetBindings(false);
        }

        private void ArrendarSalaBotton_Click(object sender, EventArgs e)
        {
            Sala salaSelecionada = (Sala)SalasDisponibles.SelectedItem;
            if(salaArrendada.Count==0)
            {
                salaArrendada.Add(salaSelecionada);
                salaArrendadaBinding.ResetBindings(false);
            }
            else if (salaArrendada.Count==1)
            {
                salaArrendada[0] = salaSelecionada;
                salaArrendadaBinding.ResetBindings(false);
            }
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
