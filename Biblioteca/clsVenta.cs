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
        private string _EmpleadoDNI;

        public string EmpleadoDNI
        {
            get { return _EmpleadoDNI; }
            set { _EmpleadoDNI = value; }
        }
        private int _CodigoCliente;

        public int CodigoCliente
        {
            get { return _CodigoCliente; }
            set { _CodigoCliente = value; }
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
        private string _Numero;

        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        public clsVenta(DateTime argFechaVenta, string argEmpleadoDNI, string argTipoComprobante,
        string argSerie, string argNumero)
        {
            FechaVenta = argFechaVenta;
            EmpleadoDNI = argEmpleadoDNI;
            TipoComprabante = argTipoComprobante;
            Serie = argSerie;
            Numero = argNumero;
        }
        /// <summary>
        /// Listar Fecha
        /// </summary>
        /// <param name="argFechaVenta"></param>
        public clsVenta(DateTime argFechaVenta)
        {
            FechaVenta = argFechaVenta;
        }
        public void Insertar_Venta(List<clsVentaDetalle> argDetalleVentas)
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand cmd;
            cmd = new SqlCommand("usp_Venta_Insertar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parFechaVenta", FechaVenta);
            // cmd.Parameters.AddWithValue("@parEmpleadoDNI", EmpleadoDNI);
            // cmd.Parameters.AddWithValue("@parCodigoCliente", CodigoCliente);
            cmd.Parameters.AddWithValue("@parTipoComprobante", TipoComprabante);
            cmd.Parameters.AddWithValue("@parSerie", Serie);
            cmd.Parameters.AddWithValue("@parNumero", Numero);
            //cmd.Parameters.AddWithValue("@parCodigoCategoria", Categoria.CodigoCategoria);
            //cmd.Parameters.AddWithValue("@parCodigoPresentacion", Presentacion.CodigoPresentacion);

            //cmd.Parameters.AddWithValue("@parCodigo", Categoria.NombreDescripcion);      
            //cmd.Parameters.AddWithValue("@parCodigoCategoria", Categoria.CodigoCategoria);  

            miConexion.Open();   
            int CodigoVenta=0;
            CodigoVenta=Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            miConexion.Close();

            foreach (clsVentaDetalle elemento in argDetalleVentas)
	        {
		    SqlConnection miConexion1;
            miConexion1 = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd1;
            cmd1 = new SqlCommand("usp_VentaProducto_insertar", miConexion);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@parCodigoVenta", CodigoVenta);
            cmd1.Parameters.AddWithValue("@parCodigoProducto", DBNull.Value);
            cmd1.Parameters.AddWithValue("@cantidad", elemento.Cantidad);
            cmd1.Parameters.AddWithValue("@precioVenta", elemento.PrecioVenta);
            miConexion1.Open();   
            cmd1.ExecuteNonQuery();
            miConexion1.Close();
	        }

        }
        public static List<clsVenta> CapturarAnioActual()
        {
            List<clsVenta> variable = new List<clsVenta>();
            SqlConnection Conexion;
            Conexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand comandos;
            comandos = new SqlCommand("usp_Capturar_AnioActual", Conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            Conexion.Open();
            SqlDataReader datos;
            datos = comandos.ExecuteReader();
            while (datos.Read() == true)
            {
                clsVenta Listar;
                Listar = new clsVenta(Convert.ToDateTime(datos["FechaVenta"]));
                variable.Add(Listar);
            }
            Conexion.Close();
            return variable;
        }

        public static IEnumerable<clsVenta> CapturarAnioActual(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        //public String RegistrarVenta()
        //{
        //    String Mensaje = "";
        //    List<clsVenta> lst = new List<clsVenta>();
        //    try
        //    {
        //        lst.Add(new clsVenta("@IdEmpleado", IdEmpleado));
        //        lst.Add(new clsVenta("@IdCliente", IdCliente));
        //        lst.Add(new clsVenta("@Serie", Serie));
        //        lst.Add(new clsVenta("@NroDocumento", NroComprobante));
        //        lst.Add(new clsVenta("@TipoDocumento", TipoDocumento));
        //        lst.Add(new clsVenta("@FechaVenta", FechaVenta));
        //        lst.Add(new clsVenta("@Total", Total));
        //        lst.Add(new clsVenta("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
        //        M.EjecutarSP("RegistrarVenta", ref lst);
        //        return Mensaje = lst[7].Valor.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        }
    }


