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
using AplicacionBotica.Utilitarios;

namespace AplicacionBotica.Formulario
{
    public partial class frmCliente_Registrar : Form
    {
        public frmCliente_Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea guardar los datos?",
                            "Aviso del sistema",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) ==
                            System.Windows.Forms.DialogResult.Yes)
            {
                //Código para guardar el participante
                clsCliente nuevoCliente;
                nuevoCliente = new clsCliente(txtNombre.Text,txtApPaterno.Text,txtAPMaterno.Text,
                                              txtDNI.Text);
                nuevoCliente.Direccion = txtDireccion.Text;            
                nuevoCliente.Registrar_Cliente();
                MessageBox.Show("Cliente registrado.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Control elemento in this.Controls)
            {
                if (elemento.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox t = (TextBox)elemento;
                    t.Clear();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsBorrar_Control borrar = new clsBorrar_Control();
            borrar.Limpiar_campos(this);
        }
            
    }
}
             