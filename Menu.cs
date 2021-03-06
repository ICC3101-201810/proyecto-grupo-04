﻿using System;
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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp4
{
    public partial class Menu : Form

    {
        Thread th;
        public static List<Credencial> credenciales;
        public List<Persona> personas;
        public Edificio edificio;
        public Persona currentUser;
        public Sala salaParaDesocupar;


        private List<Accesorio> carrito = new List<Accesorio>();
        BindingSource carritoBinding = new BindingSource();

        private List<int> total = new List<int>();
        BindingSource totalBinding = new BindingSource();

        private List<Sala> salaArrendada = new List<Sala>();
        BindingSource salaArrendadaBinding = new BindingSource();

        BindingSource salasBinding = new BindingSource();
        BindingSource accesoriosBinding = new BindingSource();

        public int contador;
        public Menu(List<Credencial> _credenciales, List<Persona> _personas, Edificio _edificio, Persona _currentUser, int _contador)
        {
            InitializeComponent();

            credenciales = _credenciales;
            personas = _personas;
            edificio = _edificio;
            currentUser = _currentUser;
            contador = _contador;




            //ACCESORIOS DISPONIBLES ALUMNOS
            if (currentUser.cargo == "ALUMNO")
            {
                accesoriosBinding.DataSource = edificio.accesoriosAlumno;
                ListaAcsesorios.DataSource = accesoriosBinding;

                ListaAcsesorios.DisplayMember = "DisplayA";
                ListaAcsesorios.ValueMember = "DisplayA";
            }
           
            //ACCESORIOS DISPONIBLES ALUMNOS
            else if (currentUser.cargo == "PROFESOR")
            {
                accesoriosBinding.DataSource = edificio.accesoriosProfessor;
                ListaAcsesorios.DataSource = accesoriosBinding;

                ListaAcsesorios.DisplayMember = "DisplayA";
                ListaAcsesorios.ValueMember = "DisplayA";
            }

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

                salaArrendada[0].Rut = currentUser.rut;
                edificio.salasNo.Add(salaArrendada[0]);
                
                edificio.salas.Remove(salaArrendada[0]);
                salasBinding.ResetBindings(false);
            }

            salaArrendada.Clear();
            salaArrendadaBinding.ResetBindings(false);

            total.Clear();
            totalBinding.ResetBindings(false);

            //serializamos los edificios 
            BinaryFormatter formattere = new BinaryFormatter();
            Stream miStreame = new FileStream("Edificios.bin", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            formattere.Serialize(miStreame, edificio);
            miStreame.Close();


            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
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

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            int paso = 0;
            foreach(Sala s in edificio.salasNo)
            {
                if(s.Rut==currentUser.rut)
                {
                    salaParaDesocupar = s;
                
                    paso = 1;
                }
            }
            if(paso==1)
            {
                edificio.salas.Add(salaParaDesocupar);
                edificio.salasNo.Remove(salaParaDesocupar);
                MessageBox.Show("La sala se a desocupada");
            }
            if(paso==0)
            {
                MessageBox.Show("Usted no tiene sala para desocupar");
            }
        }

        private void openLogin()
        {
            Application.Run(new Login(credenciales, personas, edificio, currentUser, contador));
        }
    }
}
