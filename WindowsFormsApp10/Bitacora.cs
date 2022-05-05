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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarDatos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        ///////////////////////////////////////////////////////////////




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

            LimpiarCasillas();
        }
        public void LimpiarCasillas()
        {
            dtpFecha.Value = DateTime.Now;

            txtProcesoID.Text = "";
            txtEmpleadoID.Text = "";
            txtDesc.Text = "";
            
            cboxEstado.SelectedIndex = 1;

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtProcesoID.Enabled = true;
            btnCapturar.Enabled = true;
            cboxEstado.Enabled = true;
            dgvBitacora.ClearSelection();
        }

        public void VerificarDatos()
        {
            if (txtProcesoID.Text.Equals("") || txtEmpleadoID.Text.Equals("") || txtDesc.Text.Equals("") || cboxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Favor De Llenar Todos Los Campos.","Bitacora",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            if (cboxEstado.SelectedIndex==0 || cboxEstado.SelectedIndex == 1)
            {
                if (txtProcesoID.Text != "" && txtEmpleadoID.Text != "" && txtDesc.Text != "")
                {
                    InsertarDatos();
                }
            }
        }

        ///////////////////////////////////////////////////////////////




        ///////////////////////////////////////////////////////////////
        public void InsertarDatos()
        {
            try
            {
                cnn.Abrir();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                String sql = "insert into bitacora (idProceso,idEmpleado,fechaProceso,desProceso,estaProceso) " +
                             "values('" + txtProcesoID.Text + "','" + txtEmpleadoID.Text + "','" + this.dtpFecha.Text + "','" + txtDesc.Text + "','" + cboxEstado.SelectedItem.ToString() + "')";

                SqlCommand cmd = new SqlCommand(sql, cnn.GetConexion());

                dataAdapter.InsertCommand = new SqlCommand(sql, cnn.GetConexion());
                dataAdapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                cnn.Cerrar();

                CargarDatos();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private string id = "";
        public void BorrarDatos()
        {
            cnn.Abrir();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            String sql = "Delete bitacora where idProceso=" + id;

            SqlCommand cmd = new SqlCommand(sql, cnn.GetConexion());

            dataAdapter.DeleteCommand = new SqlCommand(sql, cnn.GetConexion());
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Cerrar();

            CargarDatos();
        }

        public void ModificarDatos()
        {
            cnn.Abrir();

            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "Update bitacora set idEmpleado='" + txtEmpleadoID.Text + "',fechaProceso='" + this.dtpFecha.Text + "',desProceso='" + txtDesc.Text + "' where idProceso=" + id;

            SqlCommand cmd = new SqlCommand(sql, cnn.GetConexion());

            adapter.UpdateCommand = new SqlCommand(sql, cnn.GetConexion());
            adapter.UpdateCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Cerrar();

            CargarDatos();
        }
        private void dgvBitacora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)//botaba error si se daba clic en el nombre de las columnas del dgv (no puede con "-1")
            {
                DataGridViewRow row = this.dgvBitacora.Rows[e.RowIndex];
                id = row.Cells["idProceso"].Value.ToString();

                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;

                btnCapturar.Enabled = false;

                txtProcesoID.Enabled = false;
                cboxEstado.Enabled = false;

                txtEmpleadoID.Text = row.Cells["idEmpleado"].Value.ToString();
                this.dtpFecha.Text = row.Cells["fechaProceso"].Value.ToString();
                txtDesc.Text = row.Cells["desProceso"].Value.ToString();
            }
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
        private void mainPanel_Click(object sender, EventArgs e)
        {
            dgvBitacora.ClearSelection();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void topPanel_Click(object sender, EventArgs e)
        {
            dgvBitacora.ClearSelection();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void Bitacora_Shown(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        ///////////////////////////////////////////////////////////////

    }
}
