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
            CargarDatos();
        }

        ///////////////////////////////////////////////////////////////


        AbrirCerrarConexion cnn = new AbrirCerrarConexion();


        ///////////////////////////////////////////////////////////////
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            VerificarDatos();
        }
        ///////////////////////////////////////////////////////////////




        ///////////////////////////////////////////////////////////////
        public void CargarDatos()
        {
            dateTimePicker1.Value = DateTime.Now;
            cboxEstado.SelectedIndex = 1;

            cnn.Abrir();

            String sql = "select * from bitacora";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cnn.GetConexion());
            DataSet dataSet = new System.Data.DataSet();

            dataAdapter.Fill(dataSet, "bitacora");

            dgvBitacora.DataSource = dataSet.Tables[0];

            cnn.Cerrar();

            LimpiarCasillas();
        }

        public void VerificarDatos()
        {
            if (txtProcesoID.Text.Equals("") || txtEmpleadoID.Text.Equals("") || txtDesc.Text.Equals("") || cboxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Favor De Llenar Todos Los Campos.","Bitacora",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = this.dateTimePicker1.Text;
        }


        ///////////////////////////////////////////////////////////////

    }
}
