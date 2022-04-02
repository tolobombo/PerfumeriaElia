using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Login : Form
    {
        conexion conx  = new conexion();
        
        public Login()
        {
            InitializeComponent();
        }

        //manda el texto por el metodo a la clase de conexion
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //conx.conexionSQL(txtUser.Text, txtPassword.Text);
            //if (conx.conectado) { this.Hide(); }

            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loginError()
        {
            MessageBox.Show("El Usuario/Contraseña No Es Valido, Intentelo De Nuevo.");
        }
        /////////////////////////////////////////////////////////////////
        

        //para poder arrastrar la ventana desde el panel superior
        bool mouseDown;
        private Point mousePos;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos.X = e.X;
            mousePos.Y = e.Y;
            mouseDown = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - mousePos.X, currentScreenPos.Y - mousePos.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        ////////////////////////////////////////////////////////////////
        
        
        /// Enter para continuar
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conx.conexionSQL(txtUser.Text, txtPassword.Text);
                if (conx.conectado) { this.Hide(); }
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuGerente gerente = new MenuGerente();
            gerente.Show();
            this.Hide();
        }
        ////////////////////////////////////////////////////////////////
    }
}
