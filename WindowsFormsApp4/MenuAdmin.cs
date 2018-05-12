﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ClassLibrary2;

namespace WindowsFormsApp4
{
    public partial class MenuAdmin : Form
    {
        Thread th;
        public List<Persona> personas;
        public List<Credencial> credenciales;
        public Edificio edificio;
        public Persona currentUser;
        public Persona alumnoCastigado;
        private List<Sala> salaNoDisponible = new List<Sala>();

        BindingSource personasBinding = new BindingSource();
        BindingSource salaNoDisponibleBinding = new BindingSource();
        BindingSource salasBinding = new BindingSource();
        BindingSource accesoriosBinding = new BindingSource();

        public MenuAdmin(List<Credencial> _credenciales, List<Persona> _personas, Edificio _edificio, Persona _currentUser)
        { 
            InitializeComponent();
            personas = _personas;
            credenciales = _credenciales;
            edificio = _edificio;
            currentUser = _currentUser;
            salaNoDisponible = edificio.salasNo;

            //ALUMNOS
            personasBinding.DataSource = personas;
            LBAlumnos.DataSource = personasBinding;

            LBAlumnos.ValueMember = "DisplayAlumno";
            LBAlumnos.DisplayMember = "DisplayAlumno";

            //SALAS DISPONIBLES
            salasBinding.DataSource = edificio.salas;
            LBSalasDisponibles.DataSource = salasBinding;

            LBSalasDisponibles.ValueMember = "Display";
            LBSalasDisponibles.DisplayMember = "Display";

            //Sala Arrendada
            salaNoDisponibleBinding.DataSource = salaNoDisponible;
            LBSalasNoDisponibles.DataSource = salaNoDisponible;

            LBSalasNoDisponibles.ValueMember = "DisplayAdmin";
            LBSalasNoDisponibles.DisplayMember = "DisplayAdmin";

        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new Login(credenciales,personas, edificio, currentUser));
        }

        private void BCastigarAlumno_Click(object sender, EventArgs e)
        {
            Persona personaSelecionada = (Persona)LBAlumnos.SelectedItem;
            if (!LBAlumnos.Visible)
            {
                LBAlumnos.Visible = true;
                LAlumnos.Visible = true;
                PB1.Visible = false;
            }
            else if (LBAlumnos.Text != "")
            {
                LBAlumnos.Text = "";
                foreach (Persona p in personas)
                {
                    if (p.rut==personaSelecionada.rut)
                    {
                        alumnoCastigado = p;
                    }
                }
                th = new Thread(openCastigarAlumno);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                LBAlumnos.Visible = false;
                LAlumnos.Visible = false;
                PB1.Visible = true;
            }
        }

        private void openCastigarAlumno()
        {
            Application.Run(new CastigarAlumno(credenciales, personas, edificio, currentUser, alumnoCastigado));
        }
    }
}