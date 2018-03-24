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
using AplicacionBotica.Formulario;

namespace AplicacionBotica.Formulario
{
    public partial class frmCliente_Buscar : Form
    {
        private List<clsCliente> _BuscarCliente = new List<clsCliente>();

        public List<clsCliente> BuscarCliente
        {
            get { return _BuscarCliente; }
            set { _BuscarCliente = value; }
        }

        private clsCliente _SeleccionarCliente;

        public clsCliente SeleccionarCliente
        {
            get { return _SeleccionarCliente; }
            set { _SeleccionarCliente = value; }
        }

        public frmCliente_Buscar()
        {
            InitializeComponent();

        }
        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            lstvCliente_Nombres.Items.Clear();
            BuscarCliente.Clear();
            int contador = 0;
            foreach (clsCliente elemento in clsCliente.Buscar_Cliente_Nombre_Ap(txtNombreApellido.Text))
            {
                lstvCliente_Nombres.Items.Add(Convert.ToString(contador + 1));
                lstvCliente_Nombres.Items[contador].SubItems.Add(elemento.Nombre);
                lstvCliente_Nombres.Items[contador].SubItems.Add(elemento.ApellidoPaterno);
                lstvCliente_Nombres.Items[contador].SubItems.Add(elemento.ApellidoMaterno);
                lstvCliente_Nombres.Items[contador].SubItems.Add(elemento.Direccion);
                lstvCliente_Nombres.Items[contador].SubItems.Add(elemento.DNI);
                BuscarCliente.Add(elemento);

                if (contador % 2 == 0)
                {
                    lstvCliente_Nombres.Items[contador].BackColor = Color.Cyan;
                }
                contador = contador + 1;
            }
        }

        private void frmCliente_Buscar_Load(object sender, EventArgs e)
        {
            //AutoCompleteStringCollection listar = new AutoCompleteStringCollection();
            //foreach (clsCliente elemento in clsCliente.Buscar_Cliente_Nombre_Ap(txtNombreApellido.Text))
            //{
            //    listar.Add(elemento.ApellidoPaterno);
            //}
            //txtNombreApellido.AutoCompleteCustomSource = listar;
            //txtNombreApellido.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtNombreApellido.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void lstvCliente_Nombres_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarCliente = BuscarCliente[lstvCliente_Nombres.SelectedItems[0].Index];
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente = null;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (SeleccionarCliente != null)
            {
                SeleccionarCliente = BuscarCliente[lstvCliente_Nombres.SelectedItems[0].Index];
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione Un Cliente");
            }
           
        }

        private void btnCanclear_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("No debe Quedar Vacío el Nombre");
                    return;
                }
                if (MessageBox.Show("¿Desea guardar los datos?",
                        "Aviso del sistema",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) ==
                        System.Windows.Forms.DialogResult.Yes)
                {
                    clsCliente nuevoCliente;
                    nuevoCliente = new clsCliente(txtNombre.Text, txtApPaterno.Text, txtAPMaterno.Text,
                                                  txtDNI.Text);
                    nuevoCliente.Direccion = txtDireccion.Text;
                    nuevoCliente.Registrar_Cliente();
                    MessageBox.Show("Cliente registrado.");
                    Close();
                }
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //    if (MessageBox.Show("¿Desea guardar los datos?",
        //                    "Aviso del sistema",
        //                    MessageBoxButtons.YesNo,
        //                    MessageBoxIcon.Question) ==
        //                    System.Windows.Forms.DialogResult.Yes)
        //    {
        //        //Código para guardar el participante
        //        clsCliente nuevoCliente;
        //        nuevoCliente = new clsCliente(txtNombre.Text, txtApPaterno.Text, txtAPMaterno.Text,
        //                                      txtDNI.Text);
        //        nuevoCliente.Direccion = txtDireccion.Text;
        //        nuevoCliente.Registrar_Cliente();
        //        MessageBox.Show("Cliente registrado.");
        //        Close();
        //    }            
        //}
    }
        
}

