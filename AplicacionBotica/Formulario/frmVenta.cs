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
using AplicacionBotica.UsuarioControl;
using AplicacionBotica.Utilitarios;

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
        private clsCliente _ClienteCodigo;

        public clsCliente ClienteCodigo
        {
            get { return _ClienteCodigo; }
            set { _ClienteCodigo = value; }
        }
        private clsProducto _ProductoCodigo;

        public clsProducto ProductoCodigo
        {
            get { return _ProductoCodigo; }
            set { _ProductoCodigo = value; }
        }
        double suma;
        double total;
        string Tipo;
        public frmVenta()
        {
            InitializeComponent();
        }       
       
        private clsVenta _VentaCod;

        public clsVenta VentaCod
        {
            get { return _VentaCod; }
            set { _VentaCod = value; }
        }
        
        

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            frmCliente_Buscar Cliente = new frmCliente_Buscar();
            Cliente.ShowDialog();
            if (Cliente.SeleccionarCliente != null)
            {
                ClienteCodigo = Cliente.SeleccionarCliente;
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
            ProductoCodigo = Producto.ProductoSeleccionado;
            if (Producto.ProductoSeleccionado != null)
            {
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
                txtNombreProducto.Text = Producto.ProductoSeleccionado.NombreProducto;
            }
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //int cantidad;
            //decimal precio;
            //cantidad =Convert.ToInt32(nudCantidad.Value);
            //precio = Convert.ToDecimal(txtPrecioVenta.Text);
         

            ListViewItem Venta = new ListViewItem(Convert.ToString(nudCantidad.Value));
            Venta.SubItems.Add(txtNombreProducto.Text);
            Venta.SubItems.Add(txtPrecioVenta.Text);           
            Venta.SubItems.Add(Convert.ToString(Convert.ToDecimal(txtPrecioVenta.Text) * (Convert.ToInt32(nudCantidad.Value))));
            lstvVenta.Items.Add(Venta);

            //suma = Convert.ToDouble(cantidad) * Convert.ToDouble(precio);
            //total = total + suma;
            //txtTotal.Text =Convert.ToString(total);
            

            VentaDetalle.Add(new clsVentaDetalle(Convert.ToDecimal(txtPrecioVenta.Text),
            Convert.ToInt32(nudCantidad.Value), VentaCod, ProductoCodigo));

        } 
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                Tipo = "F";               
            }
            else
            {
                Tipo = "B";
               
            }  
            if (MessageBox.Show("¿Desea guardar los datos?",
                   "Aviso del sistema",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) ==
                   System.Windows.Forms.DialogResult.Yes)
            {                
                clsVenta Venta = new clsVenta(Convert.ToDateTime(lblFecha.Text), Tipo, lblSerie.Text, 
                                Convert.ToInt32(lblNroCorrelativo.Text),                  
                                mdlVariablesDeAplicacionBotica.UsuarioConectado);
                Venta.Cliente = ClienteCodigo;
                Venta.Insertar_Venta(VentaDetalle);
                MessageBox.Show("Venta Registrada");
            }
        }
        private void frmVenta_Load(object sender, EventArgs e)
        {

            DateTime fecha;
            fecha = clsVenta.Otbener_Fecha();
            lblFecha.Text = Convert.ToString(fecha);
            lblNroCorrelativo.Text ="000"+ clsVenta.Otbener_Numero().ToString();            
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (lstvVenta.SelectedItems.Count > 0)
            {
                VentaDetalle.RemoveAt(lstvVenta.SelectedItems[0].Index); 
                lstvVenta.Items.Remove(lstvVenta.SelectedItems[0]);                               
            }            
        }       
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            Int32 cantidadActual, CantVender;
            cantidadActual = Convert.ToInt32(txtStock.Text);
            CantVender = Convert.ToInt32(nudCantidad.Value);
            txtStock.Text = Convert.ToString(cantidadActual - CantVender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fecha;
            fecha = clsVenta.Otbener_Fecha();
            lblFecha.Text = Convert.ToString(fecha);
        }

        private void rbnFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFactura.Checked == true)
            {
                lblTipo.Text = "FACTURA";
            }
            else
            {
                lblTipo.Text = "BOLETA DE VENTA";
            }           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmRptVenta EmpleadoLista;
            EmpleadoLista = new frmRptVenta();
            EmpleadoLista.clsVentaDetalleBindingSource.DataSource = VentaDetalle;
            EmpleadoLista.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //Close();
            clsUsuarioControl.addPanel(new userInicio(), panelFormulario);
            
        }

    }
}

       
