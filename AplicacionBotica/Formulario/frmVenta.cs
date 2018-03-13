using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionBotica.UsuarioControl;
using Biblioteca;
using AplicacionBotica.Conexion;

namespace AplicacionBotica.Formulario
{
    public partial class frmVenta : Form
    {
        private List<clsVentaDetalle> _VentaDetalle = new List<clsVentaDetalle>();

        public List<clsVentaDetalle> VentaDetalle
        {
            get { return _VentaDetalle; }
            set { _VentaDetalle = value; }
        }
        
        decimal total;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmCliente_Buscar Cliente = new frmCliente_Buscar();
            Cliente.ShowDialog();
            if (Cliente.SeleccionarCliente != null)
            {
                txtDocIdentidad.Text = Cliente.SeleccionarCliente.DNI;
                txtCliente_Datos.Text = Cliente.SeleccionarCliente.Nombre + " " +
                                        Cliente.SeleccionarCliente.ApellidoPaterno + " " +
                                        Cliente.SeleccionarCliente.ApellidoMaterno;
                txtDireccion.Text = Cliente.SeleccionarCliente.Direccion;
            }
            else
            {
                this.txtCliente_Datos.Text = Cliente.txtNombre.Text;
                this.txtDocIdentidad.Text = Cliente.txtDNI.Text;
                this.txtDireccion.Text = Cliente.txtDireccion.Text;
            }
        }

        private void btnBuscar_Producto_Click(object sender, EventArgs e)
        {
            frmProducto_Buscar Producto = new frmProducto_Buscar();
            Producto.ShowDialog();
            if (Producto.ProductoSeleccionado == null)
            {

            }
            else
            {
                txtNombreProducto.Text = Producto.ProductoSeleccionado.NombreProducto;
                if (Producto.ProductoSeleccionado.Categoria != null)
                {
                    txtCategoria.Text = Producto.ProductoSeleccionado.Categoria.Nombre;
                }
                else
                {
                    txtCategoria.Text = "nO TIENE";
                }
                if (Producto.ProductoSeleccionado.Presentacion != null)
                {
                    txtPresentacion.Text = Producto.ProductoSeleccionado.Presentacion.Nombre;
                }
                else
                {
                    txtPresentacion.Text = "No tiene";
                }
                txtPrecioVenta.Text = Convert.ToString(Producto.ProductoSeleccionado.PrecioBase);
                txtStock.Text = Convert.ToString(Producto.ProductoSeleccionado.StockActual);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal PrecioVenta, total = 0;
            PrecioVenta = Math.Round(Convert.ToDecimal(txtPrecioVenta.Text), 2);
            //*************************************************************************

            dtvLista_Venta.Rows.Add(nudCantidad.Value, txtNombreProducto.Text,
            PrecioVenta, (Convert.ToInt32(nudCantidad.Value) * PrecioVenta));

            //foreach (DataGridViewRow row in dtvLista_Venta.Rows)
            //{
            //    total += Convert.ToDecimal(row.Cells["Column3"].Value);
            //}
            //txtTotal.Text = Convert.ToString(total);
        }

        private void dtvLista_Venta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dtvLista_Venta.SelectedRows.Count > 0)
            {
                dtvLista_Venta.Rows.RemoveAt(this.dtvLista_Venta.SelectedRows[0].Index);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    ListViewItem venta = new ListViewItem(Convert.ToString(nudCantidad.Value));
            //    venta.SubItems.Add(txtNombreProducto.Text);
            //    venta.SubItems.Add(txtPrecioVenta.Text);
            //    venta.SubItems.Add(Convert.ToString(Convert.ToDecimal(txtPrecioVenta.Text) * (Convert.ToInt32(nudCantidad.Value))));
            //    lstvVenta.Items.Add(venta);

            //Double dblSuma = 0;
            //foreach (ListViewItem item in lstvVenta.Items)
            //{
            //    dblSuma += Convert.ToInt32(this.lstvVenta.Items[0].SubItems[0].Text.ToString()); } txtVenta.Text = dblSuma.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
           frmProducto_Buscar Producto = new frmProducto_Buscar();
            Producto.ShowDialog();
            if (Producto.ProductoSeleccionado == null)
            {

            }
            else
            {
                txtNombreProducto.Text = Producto.ProductoSeleccionado.NombreProducto;
                if (Producto.ProductoSeleccionado.Categoria != null)
                {
                    txtCategoria.Text = Producto.ProductoSeleccionado.Categoria.Nombre;
                }
                else
                {
                    txtCategoria.Text = "nO TIENE";
                }
                if (Producto.ProductoSeleccionado.Presentacion != null)
                {
                    txtPresentacion.Text = Producto.ProductoSeleccionado.Presentacion.Nombre;
                }
                else
                {
                    txtPresentacion.Text = "No tiene";
                }
                txtPrecioVenta.Text = Convert.ToString(Producto.ProductoSeleccionado.PrecioBase);
                txtStock.Text = Convert.ToString(Producto.ProductoSeleccionado.StockActual);
            }
        }

        private void dtvLista_Venta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtvLista_Venta.Rows)
            {
                total -= Convert.ToDecimal(row.Cells["Column3"].Value);
            }
            txtTotal.Text = Convert.ToString(total);
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
       
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}

       
