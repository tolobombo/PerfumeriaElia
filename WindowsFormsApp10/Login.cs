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
    public partial class Login : Form
    {
        conexion conx  = new conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conx.conexionSQL(txtUser.Text,txtPassword.Text);
            if (conx.conectado) { this.Hide(); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loginError()
        {
            MessageBox.Show("El Usuario/Contraseña No Es Valido, Intentelo De Nuevo.");
        }
    }
}
