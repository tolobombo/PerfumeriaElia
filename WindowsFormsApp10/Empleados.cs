using System;
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool correoValido = false;
            string nombreCompleto = txtNombre.Text+" "+txtApellido1.Text+" "+txtApellido2.Text;

            //Verificar que se llenen todos los campos.
            if (txtID.Text.Equals("") || txtNombre.Text.Equals("") || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("") || txtCorreo.Text.Equals("") || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Favor de llenar todos los campos.");
            }

            //Validar Correo
            if (txtCorreo.Text!="")
            {
                if (CorreoValido(txtCorreo.Text) == false)
                {
                    MessageBox.Show("Correo Invalido");
                }
                else if(CorreoValido(txtCorreo.Text))
                {
                    correoValido = true;
                }
            }

            //Verificar que todos los campos tengan informacion y si el correo es valido para poder agregar los datos a la tabla.
            if (cmbTipo.SelectedIndex == 0 || cmbTipo.SelectedIndex == 1)
            {
                if (txtID.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtCorreo.Text != "")
                {
                    dgvEmpleados.Rows.Add(txtID.Text,nombreCompleto,txtCorreo.Text,cmbTipo.SelectedItem.ToString());

                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellido1.Text = "";
                    txtApellido2.Text = "";
                    txtCorreo.Text = "";
                }
            }
        }
        public static bool CorreoValido(string correo)
        {
            Regex correoRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",RegexOptions.IgnoreCase);

            return correoRegex.IsMatch(correo);
        }

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
        ////////////////////////////////////////////////////////////////////
    }
}
