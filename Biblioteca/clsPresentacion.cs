using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class clsPresentacion
    {
        private int _CodigoPresentacion;
        public int CodigoPresentacion
        {
            get { return _CodigoPresentacion; }
            set { _CodigoPresentacion = value; }
        }


        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public clsPresentacion(int argCodigoP, string argNombre)
        {
            CodigoPresentacion = argCodigoP;
            Nombre = argNombre;
        }
        public clsPresentacion(string argNombre)
        {
            Nombre = argNombre;
        }

        public clsPresentacion()
        {

        }


        public static List<clsPresentacion> Listar_Presentacion()
        {
            List<clsPresentacion> miVariable = new List<clsPresentacion>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Presentacion_Listar", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;

            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {
                clsPresentacion ListarPresentacion;
                ListarPresentacion = new clsPresentacion(
                    Convert.ToInt16(misDatos["CodigoPresentacion"]),
                    Convert.ToString(misDatos["Nombre"]));

                miVariable.Add(ListarPresentacion);
            }
            miConexion.Close();
            return miVariable;
        }
    }
}
