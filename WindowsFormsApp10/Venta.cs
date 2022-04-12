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
    
    public partial class Venta : Form
    {
        
        AbrirCerrarConexion Conexion = new AbrirCerrarConexion();
        public string x;
        public Venta()
        {
            InitializeComponent();
            Conexion.CrearAbrir();

            
        }


        ///////////////////////////////////////////////////////////////// ARRASTRAR VENTANA
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
        /////////////////////////////////////////////////////////////////




        ///////////////////////////////////////////////////////////////// REGRESAR, MINIMIZAR Y SALIR
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
            Conexion.Cerrar();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LlenadoNombre();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Metodos 

        private void LlenadoNombre() 
        {
            SqlCommand comandoNombre = new SqlCommand();
            DataTable table = new DataTable();

            comandoNombre.Connection = Conexion.GetConexion();

            comandoNombre.CommandType = CommandType.Text;

            comandoNombre.CommandText = "select * from inventario";

            SqlDataAdapter data = new SqlDataAdapter(comandoNombre);
            data.Fill(table);

          
           
            //Llenar combobox

            comboBox1.DataSource = table;

            comboBox1.DisplayMember = "inventario";

            comboBox1.ValueMember = "nombreProducto";
        }

       


        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Add(comboBox1.Text); ;
        }
    }
}
