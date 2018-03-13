using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using AplicacionBotica.Utilitarios;
using AplicacionBotica.Formulario;

namespace AplicacionBotica.UsuarioControl
{
    public partial class userEmpleado_Registrar : UserControl
    {
        public userEmpleado_Registrar()
        {
            InitializeComponent();
            lblValidar.Visible = false;
            pictureBox1.Visible = false;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Desea guardar los datos?",
            //                   "Aviso del sistema",
            //                   MessageBoxButtons.YesNo,
            //                   MessageBoxIcon.Question) ==
            //                   System.Windows.Forms.DialogResult.Yes)
            //{
            //    string sexo;
            //    if (rbFemenino.Checked == true)
            //    {
            //        sexo = "F";
            //    }
            //    else

            //        sexo = "M";


            //    string Cargo;
            //    if (rbVendedor.Checked == true)
            //    {
            //        Cargo = "Vendedor";
            //    }
            //    else
            //        Cargo = "Administrador";

            //******************************************************************
            try
            {
                
                //{                   
                //   MessageBox.Show("Ingrese DNI");
                //   lblValidar.Visible = true;
                //    return;                    
                   
                ////}
                //if (txtNombre.Text == "")
                //{
                //   MessageBox.Show("Ingrese Nombre");
                //    return;
                //}
                //if (txtApPaterno.Text=="")
                //{
                //    MessageBox.Show("Ingrese Apellido Paterno");
                //    return;
                //}
                if (MessageBox.Show("¿Desea guardar los datos?",
                        "Aviso del sistema",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) ==
                        System.Windows.Forms.DialogResult.Yes)
                {
                    string sexo;
                    if (rbFemenino.Checked == true)
                    {
                        sexo = "F";
                    }
                    else
                        sexo = "M";
                    string Cargo;
                    if (rbVendedor.Checked == true)
                    {
                        Cargo = "Vendedor";
                    }
                    else
                        Cargo = "Administrador";
                    clsEmpleado Registrar = new clsEmpleado(txtDNI.Text, txtNombre.Text, txtApPaterno.Text,
                      txtAPMaterno.Text, dtpFecha.Value, txtTelefono.Text, txtDireccion.Text,
                     Convert.ToChar(sexo), Cargo, txtNombreUsuario.Text, txtClave.Text);

                    Registrar.Registrar_Empleados();
                    MessageBox.Show("Empleado registrado.");
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
      


                //clsEmpleado Registrar = new clsEmpleado(txtDNI.Text, txtNombre.Text, txtApPaterno.Text,
                //    txtAPMaterno.Text, dtpFecha.Value, txtTelefono.Text, txtDireccion.Text,
                //   Convert.ToChar(sexo), Cargo, txtNombreUsuario.Text, txtClave.Text);



                //Registrar.Registrar_Empleados();
                //MessageBox.Show("Empleado registrado.");


        //    }
        //}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsBorrar_Control borrar = new clsBorrar_Control();
            borrar.Limpiar_campos(this);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            foreach (clsEmpleado elemento in clsEmpleado.Listar_Todo())
            {
                if (elemento.EmpleadoDNI == txtDNI.Text)
                {
                    lblDNI.Text = "exite";
                }               
                if (txtDNI.Text.Length != 8)
                {
                    lblValidar.Visible = true;
                    pictureBox1.Visible = false;
                }
                else if (txtDNI.Text.Length == 8)
                {
                  lblValidar.Visible = false;
                    pictureBox1.Visible = true;
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clsPanel.addPanel(new frmEmpleado(), panelFormulario);
            btnAtras.Visible = false;
            panel2.Visible = false;
        }
    }
}
