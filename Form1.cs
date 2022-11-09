using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
            txtUsuario.Text = "";
            lblInformacion.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, clave;

            usuario = txtUsuario.Text;
            clave = txtContrasena.Text;

            if (usuario == "pepito")
            {
                if (clave == "educacionIT")
                    lblInformacion.Text = "Bienvenido Pepito";
                else
                    lblInformacion.Text = "Usuario no coincide con clave";

            }
            else
                lblInformacion.Text = "Usuario no existe";
        }
    }
}

