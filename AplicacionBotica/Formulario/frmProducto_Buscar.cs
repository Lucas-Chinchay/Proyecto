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
    public partial class frmProducto_Buscar : Form
    {
           
        private List<clsProducto> _BucarProducto = new List<clsProducto>();

        public List<clsProducto> BuscarProducto
        {
            get { return _BucarProducto; }
            set { _BucarProducto = value; }
        }

        private clsProducto _ProductoSeleccionado;

        public clsProducto ProductoSeleccionado
        {
            get { return _ProductoSeleccionado; }
            set { _ProductoSeleccionado = value; }
        }
        

        public frmProducto_Buscar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProducto_Buscar_Load(object sender, EventArgs e)
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstvListarProducto.Items.Clear();
            BuscarProducto.Clear();
            int contador = 0;

            if (rbCategoria.Checked == true)
            {
                foreach (clsProducto elemento in clsProducto.Buscar_PorCategoria(txtBuscar.Text))
                {
                    BuscarProducto.Add(elemento);
                    lstvListarProducto.Items.Add(Convert.ToString(contador + 1));
                    lstvListarProducto.Items[contador].SubItems.Add(elemento.NombreProducto);
                    lstvListarProducto.Items[contador].SubItems.Add(Convert.ToString(elemento.PrecioBase));

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
                    if (contador % 2 == 0)
                    {
                        lstvListarProducto.Items[contador].BackColor = Color.Cyan;
                    }
                    contador = contador + 1;
                }
            }
            else if (rbPresentacion.Checked == true)
            {
                foreach (clsProducto elemento in clsProducto.Buscar_PorPresentacion(txtBuscar.Text))
                {
                    BuscarProducto.Add(elemento);
                    lstvListarProducto.Items.Add(Convert.ToString(contador + 1));
                    lstvListarProducto.Items[contador].SubItems.Add(elemento.NombreProducto);
                    lstvListarProducto.Items[contador].SubItems.Add(Convert.ToString(elemento.PrecioBase));

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
                    if (contador % 2 == 0)
                    {
                        lstvListarProducto.Items[contador].BackColor = Color.Cyan;
                    }
                    contador = contador + 1;
                }
            }

            else
            {
                foreach (clsProducto elemento in clsProducto.Buscar_PorProducto(txtBuscar.Text))
                {
                    BuscarProducto.Add(elemento);
                    lstvListarProducto.Items.Add(Convert.ToString(contador + 1));
                    lstvListarProducto.Items[contador].SubItems.Add(elemento.NombreProducto);
                    lstvListarProducto.Items[contador].SubItems.Add(Convert.ToString(elemento.PrecioBase));

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
                    if (contador % 2 == 0)
                    {
                        lstvListarProducto.Items[contador].BackColor = Color.Cyan;
                    }
                    contador = contador + 1;
                }
            }
        }
          

        private void lstvListarProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductoSeleccionado = BuscarProducto[lstvListarProducto.SelectedItems[0].Index];
            Close();

        }

        private void lstvListarProducto_Click(object sender, EventArgs e)
        {
            

           // lstvListarProducto.ForeColor = System.Drawing.Color.Blue;

        }

        private void lstvListarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstvListarProducto
          // lstvListarProducto.SelectedItems[0].Index].ForeColor=Color.Maroon;
                //lstvListarProducto.BackColor = Color.Maroon;
                //lstvListarProducto.ForeColor = Color.White;
         
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
