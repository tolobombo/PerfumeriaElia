using System.Data.SqlClient;


namespace WindowsFormsApp10
{
    sealed class AbrirCerrarConexion // Esta clase la puedes usar en cualquier parte para crear, abrir y/o cerrar en cualquier lugar
    {
        static string pcName = System.Windows.Forms.SystemInformation.ComputerName;
        static string connectionString = @"Data Source=" + pcName + @"\SQLEXPRESS;Initial Catalog=perfumeriaElia;User ID=localhost;Password=admin";
        static string direccion = "Data Source=Localhost;Initial Catalog=PerfumeriaElia; Integrated Security=true";
        SqlConnection conexionSqlConnection = new SqlConnection(connectionString);

        // En esta parte tiene que ser estaticos los campos por la privacidad de la clase
        public void Abrir()
        {
            conexionSqlConnection.Open();

            //System.Windows.Forms.MessageBox.Show("Abierta");
        }

        public void Cerrar()
        {
            conexionSqlConnection.Close();

            //System.Windows.Forms.MessageBox.Show("Cerrada");
        }

        public SqlConnection GetConexion()
        {
            return conexionSqlConnection;
        }

        
    }
}
