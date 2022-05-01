using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Inventario : Form
    {
        AbrirCerrarConexion Conexion = new AbrirCerrarConexion();




        public Inventario()
        {

            InitializeComponent();
            dgv2.Hide();
            Conexion.Abrir();
            LlenadoOtrosMarca();
            txtMarca.Text = string.Empty;
            


        }

        //////////////////////////////////////////////////////////////////// BOTONES DE VENTANA
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresarEmp_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "CHANEL";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "PACO";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "CK";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "BOSS";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void comboOtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarca.Text = comboOtro.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Marca seleccionada";
            dgv2.Hide();
            dgvProductos.Show();
            LlenarDVG();
        }

        //METODOS

        string sql;

        public void LlenarDVG()
        {
            string marca =  txtMarca.Text;

            if (txtMarca.Text == string.Empty)
            {
                sql = "select * from inventario";
            }
            else
            {
                sql = $"select * from inventario where marcaProducto = '{marca}' ORDER BY idProducto ASC";
            }

            SqlCommand comandoLlenar = new SqlCommand(sql, Conexion.GetConexion()); 

            SqlDataAdapter adapter = new SqlDataAdapter(comandoLlenar);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProductos.DataSource = table;
        }
      
      
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

            comboOtro.DataSource = table;

            comboOtro.DisplayMember = "inventario";

            comboOtro.ValueMember = "marcaProducto";
        }

        private void AltaProductos() 
        {
            string sql = "insert into inventario values (@idProducto, @nombreProducto, @precioCompra, @totalProducto, @precioVenta, @marcaProducto)";
            SqlCommand comandoAlta = new SqlCommand(sql, Conexion.GetConexion());

            try
            {
                foreach (DataGridViewRow dgv in dgv2.Rows)
                {
                    comandoAlta.Parameters.Clear();

                    comandoAlta.Parameters.AddWithValue("@idProducto",Convert.ToString(dgv.Cells["Column1"].Value));
                    comandoAlta.Parameters.AddWithValue("@nombreProducto",Convert.ToString(dgv.Cells["Column2"].Value));
                    comandoAlta.Parameters.AddWithValue("@precioCompra",Convert.ToInt32(dgv.Cells["Column3"].Value));
                    comandoAlta.Parameters.AddWithValue("@totalProducto",Convert.ToInt32(dgv.Cells["Column4"].Value));
                    comandoAlta.Parameters.AddWithValue("@precioVenta",Convert.ToInt32(dgv.Cells["Column5"].Value));
                    comandoAlta.Parameters.AddWithValue("@marcaProducto", Convert.ToString(dgv.Cells["Column6"].Value));
                    comandoAlta.ExecuteNonQuery();
                }
                MessageBox.Show("Se dio de alta con exito!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar de tipo: "+ex);
            }
        }
        private void BajaProductos()
        {
            
            string sql = $"delete inventario where idProducto = '{txtMarca.Text}'";
            SqlCommand comandobaja = new SqlCommand(sql, Conexion.GetConexion());
            comandobaja.ExecuteNonQuery();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try { dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index); }
            //catch (Exception)
            //{
            //    MessageBox.Show("Selecciona una casilla para eliminar ");
            //}
            label4.Text = "Ingresa el ID del producto a eliminar";
            dgvProductos.Hide();
            dgv2.Show();


            //DataTable table = new DataTable();

            //SqlCommand sqlCommand = new SqlCommand("select * from inventario where idProducto = '';",Conexion.GetConexion());

            //SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

            //sqlData.Fill(table);

            //dgvProductos.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaProductos();
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaProductos();
        }
    }
}
