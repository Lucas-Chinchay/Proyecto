using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using AplicacionBotica.Conexion;



namespace AplicacionBotica.Formulario
{
    public partial class frmEntrar : Form
    {
        public frmEntrar()
        {
            InitializeComponent();            
        }
       
        private void btnEntrar_Click(object sender, EventArgs e)
        {            
            if (clsEmpleado.Validacion(txtUsuario.Text, txtContrasenia.Text) == null)
            {
                MessageBox.Show("Usuario o clave incorrecta.");
            }
            else
            {
                mdlVariablesDeAplicacionBotica.UsuarioConectado =
                    clsEmpleado.Validacion(txtUsuario.Text, txtContrasenia.Text);
                Close();             
            }
        }

        private void txtUsuario_Click_1(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            //System.Environment.Exit(0);
        }

        private void txtContrasenia_Click(object sender, EventArgs e)
        {
            txtContrasenia.Text = "";
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (clsEmpleado.Validacion(txtUsuario.Text, txtContrasenia.Text) == null)
                {
                    MessageBox.Show("Usuario o clave incorrecta.");
                }
                else
                {
                    mdlVariablesDeAplicacionBotica.UsuarioConectado =
                        clsEmpleado.Validacion(txtUsuario.Text, txtContrasenia.Text);
                    Close();
                }

            }
        }

        private void frmEntrar_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.PasswordChar == '*')
            {
                txtContrasenia.PasswordChar = '\0';

            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
