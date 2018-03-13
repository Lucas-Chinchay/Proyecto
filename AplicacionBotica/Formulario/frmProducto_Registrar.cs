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
using AplicacionBotica.UsuarioControl;

namespace AplicacionBotica.Formulario
{
    public partial class frmProducto_Registrar : Form
    {
        public frmProducto_Registrar()
        {
            InitializeComponent();
        }
        
        private void frmProducto_Registrar_Load(object sender, EventArgs e)
        {
            cmbP_Presentacion.Items.Clear();
            cmbP_Categoria.Items.Clear();
            // cmbP_Categoria.Items.Add("Seleccione...");
            //cmbP_Presentacion.Items.Add("Seleccione...");



            List<clsPresentacion> presentaciones = clsPresentacion.Listar_Presentacion();

            cmbP_Presentacion.DataSource = presentaciones;
            cmbP_Presentacion.DisplayMember = "Nombre";
            cmbP_Presentacion.ValueMember = "CodigoPresentacion";


            List<clsCategoria> categorias = clsCategoria.Listar_Categoria();

            cmbP_Categoria.DataSource = categorias;
            cmbP_Categoria.DisplayMember = "Nombre";
            cmbP_Categoria.ValueMember = "CodigoCategoria";
        }

        private void btnP_Registrar_Click(object sender, EventArgs e)
        {
           
            try
            {


                if (MessageBox.Show("¿Desea guardar los datos?",
                 "Aviso del sistema",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) ==
                 System.Windows.Forms.DialogResult.Yes)
                {
                    //Código para guardar el participante


                    clsCategoria categoria = new clsCategoria();
                    categoria.CodigoCategoria = Convert.ToInt32(cmbP_Categoria.SelectedValue.ToString());
                    categoria.Nombre = cmbP_Categoria.Text;


                    clsPresentacion presentacion = new clsPresentacion();
                    presentacion.CodigoPresentacion = Convert.ToInt32(cmbP_Presentacion.SelectedValue.ToString());
                    presentacion.Nombre = cmbP_Presentacion.Text;


                    clsProducto nuevoPeoducto;
                    nuevoPeoducto = new clsProducto(txtP_Nombre.Text, Convert.ToDecimal(txtPrecioBase.Text), nudP_PreAdquirido.Value, Convert.ToByte(nudP_S_Minimo.Value),
                    Convert.ToInt16(nudP_S_Actual.Value), presentacion, categoria);
                    nuevoPeoducto.Descripcion = txtP_Descripcion.Text;
                    //nuevoPeoducto.CodigoCategoria=Convert.ToInt16(cmbP_Categoria.Text);
                    //nuevoPeoducto.CodigoPresentacion = Convert.ToInt16(cmbP_Presentacion.Text);

                    nuevoPeoducto.Insertar_Producto();
                    MessageBox.Show("Producto registrado.");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "-" + ex.StackTrace.ToString());
            }
        }

        private void btnNuevo_Categoria_Click(object sender, EventArgs e)
        {
           
            frmCategoria_Registrar categoria = new frmCategoria_Registrar();       
            categoria.ShowDialog();
            //if (categoria != null)
            //{
            //    cmbP_Categoria.Text = categoria;
            //}
           
        }

        private void btnNuevo_Presentacion_Click(object sender, EventArgs e)
        {
            frmPresentacion_Registrar presentacion = new frmPresentacion_Registrar();
            presentacion.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clsUsuarioControl.addPanel(new userProducto(), panelFormulario);
            btnAtras.Visible = false;
            panel1.Visible = false;
        }

    }
}
