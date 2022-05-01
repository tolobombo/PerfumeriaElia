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
        public string x, nombre;
        public int precio;
        public Venta()
        {
            InitializeComponent();
            Conexion.Abrir();
            LlenadoOtrosMarca();
            
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
            comboBox1.Text = "";
            x = "CHANEL";
            LlenadoNombre();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Metodos 

        private void LlenadoOtrosMarca() 
        {
            SqlCommand comandoNombre = new SqlCommand();
            DataTable table = new DataTable();

            comandoNombre.Connection = Conexion.GetConexion();

            comandoNombre.CommandType = CommandType.Text;

            comandoNombre.CommandText = "select marcaProducto from inventario where marcaProducto <> 'CK' and marcaProducto<> 'BOSS'; ";


            SqlDataAdapter data = new SqlDataAdapter(comandoNombre);
            data.Fill(table);




            //Llenar combobox

            comboBox2.DataSource = table;

            comboBox2.DisplayMember = "inventario";

            comboBox2.ValueMember = "marcaProducto";
        }
        private void LlenadoNombre()
        {

            SqlCommand comandoNombre = new SqlCommand();
            DataTable table = new DataTable();

            comandoNombre.Connection = Conexion.GetConexion();

            comandoNombre.CommandType = CommandType.Text;

            comandoNombre.CommandText = $"select nombreProducto from inventario where marcaProducto = '{x}'";

            
            SqlDataAdapter data = new SqlDataAdapter(comandoNombre);
            data.Fill(table);


            
            
            //Llenar combobox

            comboBox1.DataSource = table;

            comboBox1.DisplayMember = "inventario";

            comboBox1.ValueMember = "nombreProducto";
        }

        private void LLenadoOtros() 
        {
            SqlCommand comandoNombre = new SqlCommand();
            DataTable table = new DataTable();

            comandoNombre.Connection = Conexion.GetConexion();

            comandoNombre.CommandType = CommandType.Text;

            comandoNombre.CommandText = $"select nombreProducto from inventario where marcaProducto = '{comboBox2.Text}'";


            SqlDataAdapter data = new SqlDataAdapter(comandoNombre);
            data.Fill(table);




            //Llenar combobox

            comboBox1.DataSource = table;

            comboBox1.DisplayMember = "inventario";

            comboBox1.ValueMember = "nombreProducto";
        }
        private void LlenarData(string nombre) 
        {
            

            SqlCommand comandoPrecio = new SqlCommand($"select precioVenta from inventario where nombreProducto = '{nombre}'", Conexion.GetConexion());


            precio = Convert.ToInt32(comandoPrecio.ExecuteScalar());

        }


        private void Total()
        {
            int total = 0;

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                total += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }


            textBox1.Text = total.ToString();
        }

        private void Eliminar() 
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void Suma() 
        {
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox1.Text);

            textBox3.Text = (a - b).ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LlenarData(comboBox1.Text);
            dataGridView1.Rows.Add(comboBox1.Text,precio,textBox4.Text, precio*Convert.ToInt32(textBox4.Text));

            Total();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            x = "PACO";
            LlenadoNombre();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            x = "CK";
            LlenadoNombre();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            x = "BOSS";
            LlenadoNombre();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar();
            Total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LLenadoOtros();
            
        }
    }
}
