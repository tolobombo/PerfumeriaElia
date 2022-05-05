using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        //// INSTANCIAS //////////////////////////////////////////////////


        AbrirCerrarConexion cnn = new AbrirCerrarConexion();
        MenuGerente mg = new MenuGerente();
        Venta venta = new Venta();


        //////////////////////////////////////////////////////////////////
        public void btnLogin_Click_1(object sender, EventArgs e)
        {
            VerificarUsuario();

            //mg.Show();
            //this.Hide();
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificarUsuario();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
        //////////////////////////////////////////////////////////////////




        //////////////////////////////////////////////////////////////////
        public void VerificarUsuario()
        {
            if (txtUser.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Favor De No Dejar Campos Vacios.");
            }
            else
            {
                cnn.Abrir();

                SqlDataReader sqlDataReader;
                String sql = "Select nombreUsuario,contraUsuario,tipoUsuario from empleados";
                SqlCommand cmd = new SqlCommand(sql, cnn.GetConexion());

                sqlDataReader = cmd.ExecuteReader();

                bool coincide = false;
                string tipoUsuario = "";

                while (sqlDataReader.Read())
                {
                    if (txtUser.Text != sqlDataReader.GetValue(0).ToString() || txtPassword.Text != sqlDataReader.GetValue(1).ToString())
                    {
                        coincide = false;
                    }
                    else if (txtUser.Text == sqlDataReader.GetValue(0).ToString() && txtPassword.Text == sqlDataReader.GetValue(1).ToString())
                    {
                        tipoUsuario = sqlDataReader.GetValue(2).ToString();
                        coincide = true;
                        break;
                    }
                }

                if (coincide)
                {
                    if (tipoUsuario == "Administrador")
                    {
                        mg.Show();
                        this.Hide();
                    }
                    else
                    {
                        venta.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario/Contraseña No Es Valido, Intentelo De Nuevo.");
                }

                sqlDataReader.Close();
                cmd.Dispose();
                cnn.Cerrar();

            }

        }
        //////////////////////////////////////////////////////////////////




        /////////////////////////////////////////////////////////////// ARRASTRAR VENTANA
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
            if (mouseDown)
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




        //////////////////////////////////////////////////////////////// BOTONES PA MINIMIZAR Y CERRAR/SALIR
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ////////////////////////////////////////////////////////////////
    }
}