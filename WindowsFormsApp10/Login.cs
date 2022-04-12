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

        ////////////////////////////////////////////////////////////////// INICIAR CONEXION CON BASE DE DATOS
        
        public void conexionSQL()
        {
            MenuGerente menuGerente = new MenuGerente();
            Venta venta = new Venta();

            string pcName = System.Windows.Forms.SystemInformation.ComputerName;

            string connectionString = @"Data Source=" + pcName + @"\SQLEXPRESS;Initial Catalog=perfumeriaElia;User ID=localhost;Password=admin";

            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);

                cnn.Open();

                SqlCommand cmd;
                SqlDataReader sqlDataReader;
                String sql;

                sql = "Select nombreUsuario,contraUsuario,tipoUsuario from empleados";   ///// AGARRA USUARIO CONTRA Y ROL DE LA TABLA DE EMPLEADOS

                cmd = new SqlCommand(sql, cnn);

                sqlDataReader = cmd.ExecuteReader();


                //// LO COMPARA CON LO INGRESADO EN LOS TEXTBOX Y SI COINCIDEN SE VUELVE A COMPARAR PARA DETERMINAR EL ROL
                while (sqlDataReader.Read())
                {
                    if (txtUser.Text == sqlDataReader.GetValue(0).ToString() && txtPassword.Text == sqlDataReader.GetValue(1).ToString())
                    {
                        if (sqlDataReader.GetValue(2).ToString()=="admin")
                        {
                            menuGerente.Show();
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
                        //loginError();
                    }
                }

                sqlDataReader.Close();
                cmd.Dispose();
                cnn.Close();

            }
            catch (Exception)
            {
                
            }
        }
        //////////////////////////////////////////////////////////////////




        //////////////////////////////////////////////////////////////////
        public void btnLogin_Click_1(object sender, EventArgs e)
        {
            //conexionSQL();

            
            MenuGerente mg = new MenuGerente();
            mg.Show();

            this.Hide();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        public void loginError()
        {
            MessageBox.Show("El Usuario/Contraseña No Es Valido, Intentelo De Nuevo.");
        }
        /////////////////////////////////////////////////////////////////




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




        //////////////////////////////////////////////////////////////// BOTONES PA MINIMIZAR, CERRAR/SALIR, Y CONTINUAR CON ENTER
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conexionSQL();
            }
        }
        ////////////////////////////////////////////////////////////////
    }
}