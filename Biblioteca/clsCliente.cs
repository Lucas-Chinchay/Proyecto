using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class clsCliente
    {
        private int _CodigoCliente;

        public int CodigoCliente
        {
            get { return _CodigoCliente; }
            set { _CodigoCliente = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _ApellidoPaterno;

        public string ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set { _ApellidoPaterno = value; }
        }
        private string _ApellidoMaterno;

        public string ApellidoMaterno
        {
            get { return _ApellidoMaterno; }
            set { _ApellidoMaterno = value; }
        }
        private string _DNI;

        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        /// <summary>
        /// Buscar Cliente
        /// </summary>
        /// <param name="argNombre"></param>
        /// <param name="argApeterno"></param>
        /// <param name="argApellidoMaterno"></param>
        /// <param name="argDNI"></param>
        /// <param name="argDireccion"></param>
        /// <param name="argSexo"></param>
        public clsCliente( int argCodigo,string argNombre, string argApeterno, string argApellidoMaterno, string argDNI, string argDireccion)
        {
            CodigoCliente = argCodigo;
            Nombre = argNombre;
            ApellidoPaterno = argApeterno;
            ApellidoMaterno = argApellidoMaterno;
            DNI = argDNI;
            Direccion = argDireccion;          
        }
        /// <summary>
        /// Cliente Registrar
        /// </summary>
        /// <param name="argNombre"></param>
        /// <param name="argApeterno"></param>
        /// <param name="argApellidoMaterno"></param>
        /// <param name="argDNI"></param>
        /// <param name="argDireccion"></param>
        /// <param name="argSexo"></param>
        public clsCliente(string argNombre, string argApeterno, string argApellidoMaterno, string argDNI)
        {
            Nombre = argNombre;
            ApellidoPaterno = argApeterno;
            ApellidoMaterno = argApellidoMaterno;
            DNI = argDNI;
        }
        public clsCliente(int   argCodigp)
        {
                        CodigoCliente   = argCodigp;
        }
        public void Registrar_Cliente()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd;
            cmd = new SqlCommand("usp_Cliente_Registrar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parNombre", Nombre);
            cmd.Parameters.AddWithValue("@parApPaterno", ApellidoPaterno);
            cmd.Parameters.AddWithValue("@parApMaterno", ApellidoMaterno);
            cmd.Parameters.AddWithValue("@parDNI", DNI);
            cmd.Parameters.AddWithValue("@parDireccion", Direccion);            
            miConexion.Open();
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }

        public static DateTime oBTENER_fECHA()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd;
            cmd = new SqlCommand("[usp_Capturar_AnioActual]", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
         
            miConexion.Open();
            DateTime X;
            X = Convert.ToDateTime( cmd.ExecuteScalar());
            miConexion.Close();
            return X;
        }

        public static List<clsCliente> Buscar_Cliente_Nombre_Ap(string textoABuscarClienteNombre)
        {
            List<clsCliente> miVariable = new List<clsCliente>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Cliente_Apellido_Buscar", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@parBuscarNombre", textoABuscarClienteNombre);
            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {
                clsCliente BuscarCliente;
                BuscarCliente = new clsCliente(
                    Convert.ToInt32(misDatos["CodigoCliente"]),
                    Convert.ToString(misDatos["Nombre"]),
                   Convert.ToString(misDatos["ApellidoPaterno"]),
                    Convert.ToString(misDatos["ApellidoMaterno"]),
                    Convert.ToString(misDatos["DNI"]),
                    Convert.ToString(misDatos["Direccion"]));
                    

                miVariable.Add(BuscarCliente);
            }
            miConexion.Close();
            return miVariable;
        }
        //public static List<clsCliente> Listar_Cliente()
        //{
        //    List<clsCliente> variable = new List<clsCliente>();
        //    SqlConnection Conexion;
        //    Conexion = new SqlConnection(mdlVariables.CadenaConexion);
        //    SqlCommand comandos;
        //    comandos = new SqlCommand("usp_categoria_listar", Conexion);
        //    comandos.CommandType = System.Data.CommandType.StoredProcedure;
        //    Conexion.Open();
        //    SqlDataReader datos;
        //    datos = comandos.ExecuteReader();
        //    while (datos.Read() == true)
        //    {
        //        clsCliente ListarCategoria;
        //        ListarCategoria = new clsCliente(Convert.ToInt32(datos["CodigoCliente"]),
        //            Convert.ToString(datos["Nombre"]),
        //           Convert.ToString(datos["ApellidoPaterno"]),
        //            Convert.ToString(datos["ApellidoMaterno"]),
        //            Convert.ToString(datos["DNI"]),
        //            Convert.ToString(datos["Direccion"]));
        //        variable.Add(ListarCategoria);
        //    }
        //    Conexion.Close();
        //    return variable;
        //}
    }
}
