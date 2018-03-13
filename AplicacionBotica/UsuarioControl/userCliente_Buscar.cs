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

namespace AplicacionBotica.UsuarioControl
{
    public partial class userCliente_Buscar : UserControl
    {
        public userCliente_Buscar()
        {
            InitializeComponent();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            dgvNombre.Rows.Clear();
            foreach (clsCliente textoABuscarClienteNombre in clsCliente.Buscar_Cliente_Nombre_Ap(txtNombreApellido.Text))
            {

                dgvNombre.Rows.Add(dgvNombre.Rows.Count + 1
                                     , textoABuscarClienteNombre.Nombre
                           , textoABuscarClienteNombre.ApellidoPaterno
                           , textoABuscarClienteNombre.ApellidoMaterno
                           , textoABuscarClienteNombre.Direccion
                           , textoABuscarClienteNombre.DNI);


            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            dgvDni.Rows.Clear();
            foreach (clsCliente textoABuscarClienteNombre in clsCliente.Buscar_Cliente_Nombre_Ap(txtDNI.Text))
            {

                dgvDni.Rows.Add(dgvDni.Rows.Count + 1
                                     , textoABuscarClienteNombre.Nombre
                           , textoABuscarClienteNombre.ApellidoPaterno
                           , textoABuscarClienteNombre.ApellidoMaterno
                           , textoABuscarClienteNombre.Direccion
                           , textoABuscarClienteNombre.DNI);
                          
            }
        }
    }
}
