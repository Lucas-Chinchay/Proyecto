using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class clsProducto
    {
        private int _CodigoProducto;

        public int CodigoProducto
        {
            get { return _CodigoProducto; }
            set { _CodigoProducto = value; }
        }

        private string _NombreProducto;

        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }
        private decimal _PrecioBase;

        public decimal PrecioBase
        {
            get { return _PrecioBase; }
            set { _PrecioBase = value; }
        }

        private decimal _PrecioAdquirido;

        public decimal PrecioAdquirido
        {
            get { return _PrecioAdquirido; }
            set { _PrecioAdquirido = value; }
        }
        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        private byte _StockMinimo;

        public byte StockMinimo
        {
            get { return _StockMinimo; }
            set { _StockMinimo = value; }
        }
        private int _StockActual;

        public int StockActual
        {
            get { return _StockActual; }
            set { _StockActual = value; }
        }

        private clsCategoria _Categoria;

        public clsCategoria Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private clsPresentacion _Presentacion;

        public clsPresentacion Presentacion
        {
            get { return _Presentacion; }
            set { _Presentacion = value; }
        }



        public clsProducto(string argNombre, decimal argPreAdq, byte argSMinimo, int argSActual)
        {
            NombreProducto = argNombre;
            PrecioAdquirido = argPreAdq;
            StockMinimo = argSMinimo;
            StockActual = argSActual;
        }

        public clsProducto(string argNombre,string argDescripcion)
        {
            NombreProducto = argNombre;
            Descripcion = argDescripcion;
           
        }

        /// <summary>
        /// Registrar Producto
        /// </summary>
        /// <param name="argNombre"></param>
        /// <param name="argPreAdq"></param>
        /// <param name="argSMinimo"></param>
        /// <param name="argSActual"></param>
        /// <param name="argPresentacion"></param>
        /// <param name="argCategoria"></param>
        public clsProducto(string argNombre, decimal argPrecioBase, decimal argPreAdq, byte argSMinimo, int argSActual, clsPresentacion argPresentacion,
            clsCategoria argCategoria)
        {
            NombreProducto = argNombre;
            PrecioBase = argPrecioBase;
            PrecioAdquirido = argPreAdq;
            StockMinimo = argSMinimo;
            StockActual = argSActual;
            Presentacion = argPresentacion;
            Categoria = argCategoria;
        }
        /// <summary>
        /// Listar para Venta
        /// </summary>
        /// <param name="argNombre"></param>
        /// <param name="argPrecioBase"></param>
        /// <param name="argPreAdq"></param>
        /// <param name="argSMinimo"></param>
        /// <param name="argSActual"></param>
        /// <param name="argPresentacion"></param>
        /// <param name="argCategoria"></param>
        public clsProducto(int argCodigoProducto, string argNombre, decimal argPrecioBase, decimal argPreAdq, byte argSMinimo, int argSActual, clsPresentacion argPresentacion,
           clsCategoria argCategoria)
        {
            CodigoProducto = argCodigoProducto;
            NombreProducto = argNombre;
            PrecioBase = argPrecioBase;
            PrecioAdquirido = argPreAdq;
            StockMinimo = argSMinimo;
            StockActual = argSActual;
            Presentacion = argPresentacion;
            Categoria = argCategoria;
        }

        public void Insertar_Producto()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand cmd;
            cmd = new SqlCommand("usp_Producto_Insertar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parNombre", NombreProducto);
            cmd.Parameters.AddWithValue("@parPrecioBase", PrecioBase);
            cmd.Parameters.AddWithValue("@parPreAdquirido", PrecioAdquirido);
            cmd.Parameters.AddWithValue("@parDescripcion", Descripcion);
            cmd.Parameters.AddWithValue("@parStockMinimo", StockMinimo);
            cmd.Parameters.AddWithValue("@parStockActual", StockActual);
            cmd.Parameters.AddWithValue("@parCodigoCategoria", Categoria.CodigoCategoria);
            cmd.Parameters.AddWithValue("@parCodigoPresentacion", Presentacion.CodigoPresentacion);

            miConexion.Open();
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }


        public static List<clsProducto> Buscar_PorProducto(string textoABuscarProducto)
        {
            List<clsProducto> miVariable = new List<clsProducto>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Producto_Buscar", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@parBuscarProducto", textoABuscarProducto);
            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {

                clsPresentacion aux01;
                if (misDatos["Presentacion"] == DBNull.Value)
                {
                    aux01 = null;
                }
                else
                {
                    aux01 = new clsPresentacion(
                        //  Convert.ToInt16(misDatos["CodigoPresentacion"]),
                      Convert.ToString(misDatos["Presentacion"]));
                }

                clsCategoria aux02;
                if (misDatos["Categoria"] == DBNull.Value)
                {
                    aux02 = null;
                }
                else
                {
                    aux02 = new clsCategoria(Convert.ToString(misDatos["Categoria"]));
                }
                //clsCategoria aux02;
                //aux02 = new clsCategoria(
                //    //Convert.ToInt16(misDatos["CodigoCategoria"]),
                //    Convert.ToString(misDatos["Categoria"]));
                clsProducto Fila;
                Fila = new clsProducto(
                     Convert.ToInt32(misDatos["CodigoProducto"]),
                    Convert.ToString(misDatos["Producto"]),
                    Convert.ToDecimal(misDatos["PrecioBase"]),
                    Convert.ToDecimal(misDatos["PrecioAdquirido"]),
                    Convert.ToByte(misDatos["StockMinimo"]),
                    Convert.ToInt16(misDatos["StockActual"]), aux01, aux02);

                //aux01, aux02);

                miVariable.Add(Fila);
            }
            miConexion.Close();
            return miVariable;
        }
        public static List<clsProducto> Buscar_PorPresentacion(string textoABuscarPresentacion)
        {
            List<clsProducto> miVariable = new List<clsProducto>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Presentacion_Buscar", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@parBuscarPresentacion", textoABuscarPresentacion);
            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {

                clsPresentacion aux01;
                if (misDatos["Presentacion"] == DBNull.Value)
                {
                    aux01 = null;
                }
                else
                {
                    aux01 = new clsPresentacion(
                      Convert.ToInt16(misDatos["CodigoPresentacion"]),
                      Convert.ToString(misDatos["Presentacion"]));
                }

                clsCategoria aux02;
                if (misDatos["Categoria"] == DBNull.Value)
                {
                    aux02 = null;
                }
                else
                {
                    aux02 = new clsCategoria(Convert.ToString(misDatos["Categoria"]));
                }              
                clsProducto Fila;
                Fila = new clsProducto(
                     Convert.ToInt32(misDatos["CodigoProducto"]),
                    Convert.ToString(misDatos["Producto"]),
                    Convert.ToDecimal(misDatos["PrecioBase"]),
                    Convert.ToDecimal(misDatos["PrecioAdquirido"]),
                    Convert.ToByte(misDatos["StockMinimo"]),
                    Convert.ToInt16(misDatos["StockActual"]), aux01, aux02);

                //aux01, aux02);

                miVariable.Add(Fila);
            }
            miConexion.Close();
            return miVariable;
        }
        public static List<clsProducto> Buscar_PorCategoria(string textoABuscarPresentacion)
        {
            List<clsProducto> miVariable = new List<clsProducto>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Categoria_Buscar", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@parBuscarCategoria", textoABuscarPresentacion);
            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {

                clsPresentacion aux01;
                if (misDatos["Presentacion"] == DBNull.Value)
                {
                    aux01 = null;
                }
                else
                {
                    aux01 = new clsPresentacion(                      
                      Convert.ToString(misDatos["Presentacion"]));
                }

                clsCategoria aux02;
                aux02 = new clsCategoria(
                    //Convert.ToInt16(misDatos["CodigoCategoria"]),
                    Convert.ToString(misDatos["Categoria"]));
                clsProducto Fila;
                Fila = new clsProducto(
                     Convert.ToInt32(misDatos["CodigoProducto"]),
                    Convert.ToString(misDatos["Producto"]),
                    Convert.ToDecimal(misDatos["PrecioBase"]),
                    Convert.ToDecimal(misDatos["PrecioAdquirido"]),
                    Convert.ToByte(misDatos["StockMinimo"]),
                    Convert.ToInt16(misDatos["StockActual"]), aux01, aux02);

                //aux01, aux02);

                miVariable.Add(Fila);
            }
            miConexion.Close();
            return miVariable;
        }      

    }
}