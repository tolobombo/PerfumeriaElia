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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.SelectedPath;
                button2.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dataBase = conexion.ToString();
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Ingresa la dirrecion del Backup");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + dataBase + "] TO DISK '" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".bak'";
                conexion.CrearAbrir();
                SqlCommand command = new SqlCommand(cmd,conexion.GetConexion());
                command.ExecuteNonQuery();
                MessageBox.Show("El respaldo a sido creado");
                conexion.Cerrar();
                button2.Enabled=false;
            }
        }
    }
}
