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
using AplicacionBotica.Formulario;
using AplicacionBotica.Utilitarios;

namespace AplicacionBotica.UsuarioControl
{
    public partial class UserProducto_Buscar : UserControl
    {

        private List<clsProducto> _BucarProducto = new List<clsProducto>();

        public List<clsProducto> BuscarProducto
        {
            get { return _BucarProducto; }
            set { _BucarProducto = value; }
        }
        public UserProducto_Buscar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            lstvListarProducto.Items.Clear();
            BuscarProducto.Clear();
            int contador = 0;
            foreach (clsProducto elemento in clsProducto.Buscar_PorProducto(txtBuscar.Text))
            {
                BuscarProducto.Add(elemento);
                lstvListarProducto.Items.Add(Convert.ToString(contador + 1));
                lstvListarProducto.Items[contador].SubItems.Add(elemento.NombreProducto);
                if (elemento.Presentacion == null || elemento.Categoria == null)
                {
                    lstvListarProducto.Items[contador].SubItems.Add("-");
                    lstvListarProducto.Items[contador].SubItems.Add("-");
                }
                else
                {
                    lstvListarProducto.Items[contador].SubItems.Add(elemento.Presentacion.Nombre);
                    lstvListarProducto.Items[contador].SubItems.Add(elemento.Categoria.Nombre);
                }
                //lstvListarProducto.Items[contador].SubItems.Add(elemento.Presentacion.Nombre);
                lstvListarProducto.Items[contador].SubItems.Add(Convert.ToString(elemento.StockActual));
                lstvListarProducto.Items[contador].SubItems.Add(Convert.ToString(Math.Round(elemento.PrecioBase,2)));
                if (contador % 2 == 0)
                {
                    lstvListarProducto.Items[contador].BackColor = Color.Cyan;
                }
                contador = contador + 1;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            frmRptProducto_Listar_Todo Producto_Lista;
            Producto_Lista = new frmRptProducto_Listar_Todo();
            Producto_Lista.clsProductoBindingSource.DataSource = BuscarProducto;
            Producto_Lista.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserProducto_Buscar_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection listar = new AutoCompleteStringCollection();
            foreach (clsProducto elemento in clsProducto.Buscar_PorProducto(txtBuscar.Text))
            {
                listar.Add(elemento.NombreProducto);
            }
            txtBuscar.AutoCompleteCustomSource = listar;
            txtBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clsUsuarioControl.addPanel(new userProducto(), panelFormulario);
            panel1.Visible = false;
        }
    }
}
