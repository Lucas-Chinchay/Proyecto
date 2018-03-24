using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class clsVenta
    {
        private int _CodigoVenta;

        public int CodigoVenta
        {
            get { return _CodigoVenta; }
            set { _CodigoVenta = value; }
        }

        private DateTime _FechaVenta;

        public DateTime FechaVenta
        {
            get { return _FechaVenta; }
            set { _FechaVenta = value; }
        }
        private string _TipoComprobante;

        public string TipoComprabante
        {
            get { return _TipoComprobante; }
            set { _TipoComprobante = value; }
        }
        private string _Serie;

        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }
        private int _Numero;

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        private clsEmpleado _EmpleadoDNI;

        public clsEmpleado EmpleadoDNI
        {
            get { return _EmpleadoDNI; }
            set { _EmpleadoDNI = value; }
        }
        private clsCliente _Cliente;

        public clsCliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        private clsVentaDetalle _VentaDetalle_Re;

        public clsVentaDetalle VentaDetalle_Re
        {
            get { return _VentaDetalle_Re; }
            set { _VentaDetalle_Re = value; }
        }
        private clsProducto _Producto;

        public clsProducto Producto
        {
            get { return _Producto; }
            set { _Producto = value; }
        }
        
        

        public clsVenta(DateTime argFechaVenta, string argTipoComprobante,
        string argSerie, int argNumero, clsEmpleado argEmpleadoDNI)
        {
            FechaVenta = argFechaVenta;
            TipoComprabante = argTipoComprobante;
            Serie = argSerie;
            Numero = argNumero;
            EmpleadoDNI = argEmpleadoDNI;
        }
        /// <summary>
        /// Reporte Venta por fecha
        /// </summary>
        /// <param name="argFechaVenta"></param>
        /// <param name="argTipoComprobante"></param>
        /// <param name="argSerie"></param>
        /// <param name="argNumero"></param>
        /// <param name="argEmpleadoDNI"></param>
        public clsVenta(int argCodigoVenta, DateTime argFechaVenta, string argTipoComprobante,
               string argSerie, int argNumero, clsEmpleado argEmpleadoDNI, clsProducto argProducto, clsVentaDetalle argVDetalle)
        {
            CodigoVenta=argCodigoVenta;
            FechaVenta = argFechaVenta;
            TipoComprabante = argTipoComprobante;
            Serie = argSerie;
            Numero = argNumero;
            EmpleadoDNI = argEmpleadoDNI;
            Producto = argProducto;
            VentaDetalle_Re = argVDetalle;
        }       

        public void Insertar_Venta(List<clsVentaDetalle> argDetalleVentas)
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand cmd;
            cmd = new SqlCommand("usp_Venta_Insertar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parFechaVenta", FechaVenta);
            cmd.Parameters.AddWithValue("@parEmpleadoDNI", EmpleadoDNI.EmpleadoDNI);
            cmd.Parameters.AddWithValue("@parCodigoCliente", Cliente.CodigoCliente);
            cmd.Parameters.AddWithValue("@parTipoComprobante", TipoComprabante);
            cmd.Parameters.AddWithValue("@parSerie", Serie);
            cmd.Parameters.AddWithValue("@parNumero", Numero);

            miConexion.Open();
            int CodigoVentaG = 0;
            CodigoVentaG = Convert.ToInt32(cmd.ExecuteScalar());          
            miConexion.Close();

            foreach (clsVentaDetalle elemento in argDetalleVentas)
            {
                SqlConnection miConexion1;
                miConexion1 = new SqlConnection(mdlVariables.CadenaConexion);
                SqlCommand cmd1;
                cmd1 = new SqlCommand("usp_VentaProducto_insertar", miConexion1);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@parCodigoProducto", elemento.Producto.CodigoProducto);
                cmd1.Parameters.AddWithValue("@cantidad", elemento.Cantidad);
                cmd1.Parameters.AddWithValue("@precioVenta", elemento.PrecioVenta);
                cmd1.Parameters.AddWithValue("@parCodigoVenta", CodigoVentaG);
                miConexion1.Open();
                cmd1.ExecuteNonQuery();
                miConexion1.Close();
            }

        }
        public static DateTime Otbener_Fecha()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd;
            cmd = new SqlCommand("[usp_Capturar_AnioActual]", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            miConexion.Open();
            DateTime fecha;
            fecha = Convert.ToDateTime(cmd.ExecuteScalar());
            miConexion.Close();
            return fecha;
        }
        public static int Otbener_Numero()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd;
            cmd = new SqlCommand("[usp_Numero_Relativo]", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            miConexion.Open();
            int NumeroRelativo;
            NumeroRelativo = Convert.ToInt32(cmd.ExecuteScalar());
            miConexion.Close();
            return NumeroRelativo;
        }

        public static List<clsVenta> Reporte_PorFechas(DateTime dtpBuscar_FechaInicio, DateTime dtpBuscar_FechaFin)
        {
            List<clsVenta> miVariable = new List<clsVenta>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Venta_Reporte_PorFecha", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@parFechaInicio", dtpBuscar_FechaInicio);
            COMANDO.Parameters.AddWithValue("@parFechaFin", dtpBuscar_FechaFin);
            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {

                clsEmpleado Venta = new clsEmpleado(
                                    Convert.ToString(misDatos["EmpleadoDNI"]),
                                    Convert.ToString(misDatos["EmpleadoNombre"]),
                                    Convert.ToString(misDatos["EmpleadoApellido"]),
                                    Convert.ToString(misDatos["ApellidoMaterno"]));
               


                clsProducto Venta1 = new clsProducto(Convert.ToString(misDatos["ProductoNombre"]),
                                    Convert.ToString(misDatos["Descripcion"]));
                //clsProducto Fila;

               clsVentaDetalle venta2 = new clsVentaDetalle(Convert.ToDecimal(misDatos["PrecioVenta"]),
                                        Convert.ToInt32(misDatos["Cantidad"]));

               clsVenta venta03 = new clsVenta(Convert.ToInt32(misDatos["Venta"]), 
                                    Convert.ToDateTime(misDatos["FechaVenta"]), Convert.ToString(misDatos["TipoComprobante"]),
                                    Convert.ToString(misDatos["Serie"]), Convert.ToInt32(misDatos["Numero"]), 
                                    Venta, Venta1, venta2);
                miVariable.Add(venta03);
            }
            miConexion.Close();
            return miVariable;
        }
    }
}


