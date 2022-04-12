using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp10
{
    sealed class AbrirCerrarConexion
    {
        static string pcName = System.Windows.Forms.SystemInformation.ComputerName;

        static string connectionString = @"Data Source=" + pcName + @"\SQLEXPRESS;Initial Catalog=perfumeriaElia;User ID=localhost;Password=admin";
        static string direccion = "Data Source=Localhost;Initial Catalog=bd1; Integrated Security=true";
        SqlConnection conexionSqlConnection = new SqlConnection(direccion);
        public void CrearAbrir() 
        {
           

            conexionSqlConnection.Open();

            System.Windows.Forms.MessageBox.Show("Abierta");


        }

        public void Cerrar()
        {
         conexionSqlConnection.Close();
            System.Windows.Forms.MessageBox.Show("Cerrada");
        }
    }
}
