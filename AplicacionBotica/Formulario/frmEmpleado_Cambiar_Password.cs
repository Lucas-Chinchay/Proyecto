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
    public partial class frmEmpleado_Cambiar_Password : Form
    {
        public frmEmpleado_Cambiar_Password()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClaveNueva.Text == txtConfirmarClave.Text)
            {
                if (clsEmpleado.Validacion(
                       mdlVariablesDeAplicacionBotica.UsuarioConectado.Usuario,
                    txtClaveActual.Text) == null)
                {
                    MessageBox.Show("La clave actual es incorrecta.");
                }
                else
                {
                    mdlVariablesDeAplicacionBotica.UsuarioConectado.CambiarClave(
                        txtClaveNueva.Text);
                    MessageBox.Show("Clave actualizada satisfactoriamente.");
                }
            }
            else
            {
                MessageBox.Show("Las claves no coinciden.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
