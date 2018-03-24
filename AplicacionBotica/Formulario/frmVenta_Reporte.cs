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
using AplicacionBotica.Conexion;

namespace AplicacionBotica.Formulario
{
    public partial class frmVenta_Reporte : Form
    {
        private List<clsVenta> _ReporteVenta=new List<clsVenta>();

        public List<clsVenta> ReporteVenta
        {
            get { return _ReporteVenta; }
            set { _ReporteVenta = value; }
        }

        public frmVenta_Reporte()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {              
            lstvReporte.Items.Clear();
            ReporteVenta.Clear();          
            int contador = 0;
            foreach (clsVenta elemento in clsVenta.Reporte_PorFechas(dtpFecha_De.Value , dtpFecha_Hasta.Value))
            {
                lstvReporte.Items.Add(Convert.ToString(contador + 1));
                lstvReporte.Items[contador].SubItems.Add(elemento.EmpleadoDNI.EmpleadoDNI);
                lstvReporte.Items[contador].SubItems.Add(elemento.EmpleadoDNI.Nombre + " "+ elemento.EmpleadoDNI.ApellidoPaterno);
                lstvReporte.Items[contador].SubItems.Add(elemento.Producto.NombreProducto);
                lstvReporte.Items[contador].SubItems.Add(Convert.ToString(elemento.VentaDetalle_Re.Cantidad));
                lstvReporte.Items[contador].SubItems.Add(Convert.ToString(elemento.VentaDetalle_Re.PrecioVenta));
                lstvReporte.Items[contador].SubItems.Add(Convert.ToString(elemento.VentaDetalle_Re.PrecioVenta * elemento.VentaDetalle_Re.Cantidad));
                lstvReporte.Items[contador].SubItems.Add(Convert.ToString(elemento.FechaVenta));
                ReporteVenta.Add(elemento);
                if (contador % 2 == 0)
                {
                    lstvReporte.Items[contador].BackColor = Color.Cyan;
                }
                contador = contador + 1;
            }
        }
    }
}
