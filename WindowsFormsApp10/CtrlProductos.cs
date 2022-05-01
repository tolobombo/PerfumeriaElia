using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    internal class CtrlProductos
    {

        public List<Object> consulta(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "select idProducto, nombreProducto, precioCompra, precioVenta, totalProducto, marcaProducto from inventario ORDER BY idProducto ASC";
            }
            else
            {
                sql = $"select idProducto, nombreProducto, precioCompra, precioVenta, totalProducto, marcaProducto from inventario where marcaProducto = '{dato}' ORDER BY idProducto ASC";
            }
            try
            {
                AbrirCerrarConexion conexion = new AbrirCerrarConexion();
                conexion.Abrir();
                SqlCommand command = new SqlCommand(sql, conexion.GetConexion());
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Productos _productos = new Productos();
                    _productos.IdProducto = reader.GetString(0);
                    _productos.NombreProducto = reader[1].ToString();
                    _productos.PrecioCompra = int.Parse(reader[2].ToString());
                    _productos.PrecioVenta = int.Parse(reader[3].ToString());
                    _productos.TotalProducto = int.Parse(reader[4].ToString());
                    _productos.MarcaProducto = reader[5].ToString();

                    lista.Add(_productos);
                }
            }

            catch (SqlException ex) 
            {
                Console.WriteLine("No puedo realizar la consulta error de tipo: " + ex);
            }
            return lista;
        }
    }
}
