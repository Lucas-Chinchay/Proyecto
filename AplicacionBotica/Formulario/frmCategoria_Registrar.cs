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

namespace AplicacionBotica.Formulario
{
    public partial class frmCategoria_Registrar : Form
    {
        private clsCategoria _CapturarCategoria;

        public clsCategoria CapturarCategoria
        {
            get { return _CapturarCategoria; }
            set { _CapturarCategoria = value; }
        }
        
        public frmCategoria_Registrar()
        {
            InitializeComponent();
        }
      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los datos?",
                 "Aviso del sistema",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) ==
                 System.Windows.Forms.DialogResult.Yes)
            {
                clsCategoria NuevoCategoria = new clsCategoria(txtNombre_Categoria.Text);
                NuevoCategoria.Registrar_Categoria();
                MessageBox.Show("Nombre de Categoria Registrado");

            }         
            //frmProducto_Registrar pasar = new frmProducto_Registrar(string pasar);
            //txtNombre_Categoria=pasar          
            Close();

            
          
            //CapturarCategoria = BuscarProducto[lstvListarProducto.SelectedItems[0].Index];
           
            
        }

        private void txtNombre_Categoria_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
