using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class MenuGerente : Form
    {
        
        public MenuGerente()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////// ABRIR FORMULARIOS CON BOTONES
        private void btnBit_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora(); 
            bit.Show();
            this.Close();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
            this.Close();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.Show();
            this.Close();
        }

        private void btnVen_Click(object sender, EventArgs e)
        {
            Venta ven = new Venta();
            ven.Show();
            this.Close();
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
        ////////////////////////////////////////////////////////////////




        /////////////////////////////////////////////////////////////// REGRESAR, MINIMIZAR Y CERRAR VENTANA
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Respaldo respaldo = new Respaldo();
            respaldo.Show();
            this.Close();

        }
        ///////////////////////////////////////////////////////////////
    }
}
