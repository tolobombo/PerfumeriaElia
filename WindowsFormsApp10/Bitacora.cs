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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////


        AbrirCerrarConexion cnn = new AbrirCerrarConexion();


        ///////////////////////////////////////////////////////////////
        public void CargarDatos()
        {
            cnn.Abrir();

            String sql = "select * from bitacora";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cnn.GetConexion());
            DataSet dataSet = new System.Data.DataSet();

            dataAdapter.Fill(dataSet, "bitacora");

            dgvBitacora.DataSource = dataSet.Tables[0];

            cnn.Cerrar();
        }

        public void LimpiarCasillas()
        {

        }
        ///////////////////////////////////////////////////////////////
        



        /////////////////////////////////////////////////////////////// REGRESAR, MINIMIZAR Y CERRAR VENTANA
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuGerente mg = new MenuGerente();
            mg.Show();
            
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ///////////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////////// ARRASTRAR VENTANA
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
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - mousePos.X, currentScreenPos.Y - mousePos.Y);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        ///////////////////////////////////////////////////////////////

    }
}
