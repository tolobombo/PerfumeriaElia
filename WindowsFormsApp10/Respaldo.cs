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
using System.Data.Sql;
using System.Data.SqlTypes;

namespace WindowsFormsApp10
{
    public partial class Respaldo : Form
    {
        AbrirCerrarConexion conexion = new AbrirCerrarConexion();
       
        public Respaldo()
        {
            InitializeComponent();
            button2.Enabled = false;
            button4.Enabled = false;
        }

        /// SELECCIONAR CARPETA ///////////////////////////////////////////////////////////////// 
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.SelectedPath;
                button2.Enabled = true;
            }
        }


        /// HACER RESPALDO ///////////////////////////////////////////////////////////////// 
        private void button2_Click(object sender, EventArgs e)
        {
            string dataBase = conexion.GetConexion().Database.ToString();
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Ingresa la dirrecion del Backup");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + dataBase + "] TO DISK= '" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".bak'";
                conexion.Abrir();
                SqlCommand command = new SqlCommand(cmd,conexion.GetConexion());
                command.ExecuteNonQuery();
                MessageBox.Show("El respaldo a sido creado");
                conexion.Cerrar();
                button2.Enabled=false;
            }
        }

        /// SELECCIONAR RESPALDOS ///////////////////////////////////////////////////////////////// 
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            
            openFile.Title = "Seleccionar Respaldo";
            if (openFile.ShowDialog() == DialogResult.OK) 
            {
                textBox2.Text = openFile.FileName;
                button4.Enabled = true;
            }
        }

        /// RESTORAR DATOS ///////////////////////////////////////////////////////////////// 
        private void button4_Click(object sender, EventArgs e)
        {
            string database = conexion.GetConexion().Database.ToString();
            
            try
            {
                conexion.Abrir();
                string st1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK INMEDIATE");
                SqlCommand comando1 = new SqlCommand(st1, conexion.GetConexion());
                comando1.ExecuteNonQuery();

                string st2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "' WITH REPLACE;";
                SqlCommand comando2 = new SqlCommand(st2, conexion.GetConexion());
                comando2.ExecuteNonQuery();

                string st3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER"); 
                SqlCommand comando3 = new SqlCommand(st3 , conexion.GetConexion());
                comando3.ExecuteNonQuery();
                MessageBox.Show("La base de datos a sido restaurada con exito!");
                conexion.Cerrar();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

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

        ////////////////////////////////////////////////////////////////////
    }
}
