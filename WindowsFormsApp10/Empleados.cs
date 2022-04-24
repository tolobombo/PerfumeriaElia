﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp10
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VerificarDatos();
        }

        public void VerificarDatos()
        {
            Regex correoRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            string nombreCompleto = txtNombre.Text + " " + txtApellido1.Text + " " + txtApellido2.Text;
            bool correoValido = false;
            bool contraCoincide = false;

            //Verificar que se llenen todos los campos.
            if (txtID.Text.Equals("") || txtNombre.Text.Equals("") || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("") || txtCorreo.Text.Equals("") || txtUsuario.Text.Equals("") || txtContra.Text.Equals("") || txtContra2.Text.Equals("") || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Favor de llenar todos los campos.");
            }

            //Validar Correo
            if (txtCorreo.Text != "")
            {
                if (correoRegex.IsMatch(txtCorreo.Text) == false)
                {
                    MessageBox.Show("Correo Invalido");
                }
                else if (correoRegex.IsMatch(txtCorreo.Text))
                {
                    correoValido = true;
                }
            }

            //Validar Contraseñas
            if (txtContra.Text != "" && txtContra2.Text != "")
            {
                if (txtContra.Text != txtContra2.Text)
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden, intentelo de nuevo.");
                }
                else if (txtContra.Text == txtContra2.Text)
                {
                    contraCoincide = true;
                }
            }

            //Verificar que todos los campos tengan informacion, aparte que el correo y contraseñas sean validos para poder agregar los datos a la tabla.
            if (cmbTipo.SelectedIndex == 0 || cmbTipo.SelectedIndex == 1)
            {
                if (txtID.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtCorreo.Text != "" && correoValido && txtUsuario.Text != "" && txtContra.Text != "" && txtContra2.Text != "" && contraCoincide)
                {

                    InsertarDatos(nombreCompleto);

                    //Limpiar casillas
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellido1.Text = "";
                    txtApellido2.Text = "";
                    txtCorreo.Text = "";
                    cmbTipo.SelectedIndex = -1;
                    txtUsuario.Text = "";
                    txtContra.Text = "";
                    txtContra2.Text = "";
                }
            }
        }

        AbrirCerrarConexion cnn = new AbrirCerrarConexion();
        public void InsertarDatos(string nombre)
        {
            dgvEmpleados.Rows.Add(txtID.Text, nombre, txtCorreo.Text, txtUsuario.Text, cmbTipo.SelectedItem.ToString());

            cnn.CrearAbrir();

        }
        ////////////////////////////////////////////////////////////////////




        //////////////////////////////////////////////////////////////////// BOTONES SALIR, MINIMIZAR Y REGRESAR.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuGerente mg = new MenuGerente();
            mg.Show();
            this.Close();
        }
        ////////////////////////////////////////////////////////////////////



        //////////////////////////////////////////////////////////////////// ARRASTRAR VENTANA
        bool mouseDown;
        private Point mousePos;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos.X = e.X;
            mousePos.Y = e.Y;
            mouseDown = true;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - mousePos.X, currentScreenPos.Y - mousePos.Y);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////
    }
}
