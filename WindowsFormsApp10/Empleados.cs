using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            CargarDatos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VerificarDatos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarDatos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AAAAUUUUGHH");
        }
        ////////////////////////////////////////////////////////////////////




        ////////////////////////////////////////////////////////////////////
        public void VerificarDatos()
        {
            Regex correoRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            string nombreCompleto = txtNombre.Text + " " + txtApellido1.Text + " " + txtApellido2.Text;
            bool correoValido = false;
            bool contraCoincide = false;

            //Verificar que se llenen todos los campos.
            if (txtID.Text.Equals("") || txtNombre.Text.Equals("") || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("") || txtCorreo.Text.Equals("") || txtUsuario.Text.Equals("") || txtContra.Text.Equals("") || txtContra2.Text.Equals("") || cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Favor de llenar todos los campos.");
            }

            //Validar Correo
            if (txtCorreo.Text != "")
            {
                if (correoRegex.IsMatch(txtCorreo.Text) == false)
                {
                    MessageBox.Show("Correo Invalido");
                }
                else if (correoRegex.IsMatch(txtCorreo.Text))
                {
                    correoValido = true;
                }
            }

            //Validar Contraseñas
            if (txtContra.Text != "" && txtContra2.Text != "")
            {
                if (txtContra.Text != txtContra2.Text)
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden, intentelo de nuevo.");
                }
                else if (txtContra.Text == txtContra2.Text)
                {
                    contraCoincide = true;
                }
            }

            //Verificar que todos los campos tengan informacion, aparte que el correo y contraseñas sean validos para poder agregar los datos a la tabla.
            if (cmbTipo.SelectedIndex == 0 || cmbTipo.SelectedIndex == 1)
            {
                if (txtID.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtCorreo.Text != "" && correoValido && txtUsuario.Text != "" && txtContra.Text != "" && txtContra2.Text != "" && contraCoincide)
                {

                    InsertarDatos(nombreCompleto);

                    //Limpiar casillas
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellido1.Text = "";
                    txtApellido2.Text = "";
                    txtCorreo.Text = "";
                    cmbTipo.SelectedIndex = -1;
                    txtUsuario.Text = "";
                    txtContra.Text = "";
                    txtContra2.Text = "";
                }
            }
        }


        //////////////////////////////////////////////////////////////////// CARGAR DATOS AL DATA GRID VIEW
        public void CargarDatos()
        {
            cnn.Abrir();

            String sql = "select * from empleados";
            SqlDataAdapter SDA = new SqlDataAdapter(sql,cnn.GetConexion());
            DataSet DS = new System.Data.DataSet();

            SDA.Fill(DS, "empleados");

            dgvEmpleados.DataSource = DS.Tables[0];

            cnn.Cerrar();

            dgvEmpleados.ClearSelection();
        }


        //////////////////////////////////////////////////////////////////// INSERTAR DATOS A LA BD
        AbrirCerrarConexion cnn = new AbrirCerrarConexion();
        public void InsertarDatos(string nombre)
        {
            cnn.Abrir();

            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "insert into empleados (idEmpleado,nombreEmpleado,correoEmpleado,nombreUsuario,contraUsuario,tipoUsuario) " +
                         "values('" + txtID.Text + "','" + nombre + "','" + txtCorreo.Text + "','" + txtUsuario.Text + "','" + txtContra.Text + "','" + cmbTipo.SelectedItem.ToString() + "')";

            SqlCommand cmd = new SqlCommand(sql,cnn.GetConexion());

            adapter.InsertCommand = new SqlCommand(sql, cnn.GetConexion());
            adapter.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Cerrar();

            CargarDatos();
        }
        ////////////////////////////////////////////////////////////////////




        //////////////////////////////////////////////////////////////////// BORRAR DATOS DE LA BD
        private string id = "";
        public void BorrarDatos()
        {
            cnn.Abrir();

            SqlDataAdapter SDA = new SqlDataAdapter();
            String sql = "Delete empleados where idEmpleado="+id;

            SqlCommand cmd = new SqlCommand(sql,cnn.GetConexion());

            SDA.DeleteCommand = new SqlCommand(sql,cnn.GetConexion());
            SDA.DeleteCommand.ExecuteNonQuery();

            cmd.Dispose();
            cnn.Cerrar();

            CargarDatos();
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//botaba error si se daba clic en el nombre de las columnas del dgv (no puede con "-1")
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                DataGridViewRow row = this.dgvEmpleados.Rows[e.RowIndex];
                id = row.Cells["idEmpleado"].Value.ToString();
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
        private void MainPanel_Click(object sender, EventArgs e)
        {
            dgvEmpleados.ClearSelection();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void topPanel_Click(object sender, EventArgs e)
        {
            dgvEmpleados.ClearSelection();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
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




        ////////////////////////////////////////////////////////////////////
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.ClearSelection();
        }

    }
}
