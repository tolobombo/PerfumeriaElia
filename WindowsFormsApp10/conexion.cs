using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public class conexion
    {
        public bool conectado = false;

        public void conexionSQL(string usr, string psw)
        {
            Login login = new Login();
            Venta venta = new Venta();

            string pcName = System.Windows.Forms.SystemInformation.ComputerName;

            try
            {
                string connectionString = @"Data Source="+pcName+@"\SQLEXPRESS;Initial Catalog=demoDB;User ID=" + usr + ";Password=" + psw;
                SqlConnection cnn = new SqlConnection(connectionString);

                cnn.Open();

                venta.Show();
                conectado = true;

                cnn.Close();
            }
            catch (Exception)
            {
                login.loginError();
            }
        }
    }
}
