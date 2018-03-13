using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class clsVentaDetalle
    {
        private decimal _PrecioVenta;

        public decimal PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }
        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        //private int _CodioVenta;

        //public int CodigoVenta
        //{
        //    get { return _CodioVenta; }
        //    set { _CodioVenta = value; }
        //}
        //private int _CodigoProducto;

        //public int CodigoProducto
        //{
        //    get { return _CodigoProducto; }
        //    set { _CodigoProducto = value; }
        //}
        private clsProducto _Producto;

        public clsProducto Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }
        private clsVenta _Venta;

        public clsVenta Venta
        {
            get { return _Venta; }
            set { _Venta = value; }
        }

        /// <summary>
        /// Registrar Venta
        /// </summary>
        /// <param name="argPrecioVenta"></param>
        /// <param name="argCantidad"></param>
        /// <param name="argCodigoVenta"></param>
        /// <param name="argCodigoProducto"></param>
        public clsVentaDetalle(decimal argPrecioVenta, int argCantidad, clsVenta argCodigoVenta, clsProducto argCodigoProducto)
        {
            PrecioVenta = argPrecioVenta;
            Cantidad = argCantidad;
            Venta = argCodigoVenta;
            Producto = argCodigoProducto;
        }
        public void Insertar_VentaDetalle()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand cmd;
            cmd = new SqlCommand("usp_VentaProducto_Registrar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parPrecioVenta", PrecioVenta);
            cmd.Parameters.AddWithValue("@parCantidad", Cantidad);
            cmd.Parameters.AddWithValue("@parCodigoVenta", Venta.CodigoVenta);
            cmd.Parameters.AddWithValue("@parCodigoProducto", Producto.CodigoProducto);

            miConexion.Open();
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
    }
}

