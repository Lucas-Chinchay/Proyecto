using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
  public class clsCategoria
    {
        private int _CodigoCategoria;

        public int CodigoCategoria
        {
            get { return _CodigoCategoria; }
            set { _CodigoCategoria = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public clsCategoria(int argCategoria, string argNombre)
        {
            CodigoCategoria = argCategoria;
            Nombre = argNombre;
        }
        public clsCategoria(string argNombre)
        {
            Nombre = argNombre;
        }
        public clsCategoria()
        {

        }

        public static List<clsCategoria> Listar_Categoria()
        {
            List<clsCategoria> variable = new List<clsCategoria>();
            SqlConnection Conexion;
            Conexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand comandos;
            comandos = new SqlCommand("usp_categoria_listar", Conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            Conexion.Open();
            SqlDataReader datos;
            datos = comandos.ExecuteReader();
            while (datos.Read() == true)
            {
                clsCategoria ListarCategoria;
                ListarCategoria = new clsCategoria(Convert.ToInt16(datos["CodigoCategoria"]), 
                    Convert.ToString(datos["Nombre"]));
                variable.Add(ListarCategoria);
            }
            Conexion.Close();
            return variable;
        }
        public void Registrar_Categoria()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand cmd;
            cmd = new SqlCommand("usp_Categoria_Insertar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parNombreCat", Nombre);            
            miConexion.Open();
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
       
    }
}
