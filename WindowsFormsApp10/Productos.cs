using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    internal class Productos
    {
        //VARIABLES

        private string idProducto, nombreProducto, marcaProducto;
        private int precioCompra, precioVenta, totalProducto;

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string MarcaProducto { get => marcaProducto; set => marcaProducto = value; }
        public int PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int TotalProducto { get => totalProducto; set => totalProducto = value; }

    }
}
