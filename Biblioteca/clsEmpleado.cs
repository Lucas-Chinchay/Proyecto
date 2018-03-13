using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class clsEmpleado
    {
        private string _EmpleadoDNI;

        public string EmpleadoDNI
        {
            get { return _EmpleadoDNI; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El N° de DNI no puede quedar vacío.");
                }
                else if (value.Length != 8)
                {
                    throw new Exception("El N° de DNI debe tener 8 caracteres.");
                }
                else
                {
                    _EmpleadoDNI = value;
                }

            }
                 
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El nombre no debe quedar vacío.");
                }
                else
                {
                    //Minuscula => ToLower()
                    _Nombre = value.Trim();
                }
            }
        }
        private string _ApellidoPaterno;

        public string ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El Apellido no debe quedar vacío.");
                }
                else
                {
                    _ApellidoPaterno = value.Trim();
                }
            }
        }
        private string _ApellidoMaterno;

        public string ApellidoMaterno
        {
            get { return _ApellidoMaterno; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El Apellido no debe quedar vacío.");
                }
                else
                {
                    _ApellidoMaterno = value.Trim();
                }
            }
        }
        private DateTime _FechaIngreso;

        public DateTime FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private char _Sexo;

        public char Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }
        private string _Cargo;

        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }
        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        private string _Clave;

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }
        public clsEmpleado(string argUsuario, string argClave)
        {
            Usuario = argUsuario;
            Clave = argClave;
        }
        public clsEmpleado(string argDNI, string argNombre, string argApPaterno, string argApMaterno,
           DateTime argFechIngreso, string argTelefono, string argdireccion, char argSexo, string argCargo,
           string argUsuario, string argClave)
        {
            EmpleadoDNI = argDNI;
            Nombre = argNombre;
            ApellidoPaterno = argApPaterno;
            ApellidoMaterno = argApMaterno;
            FechaIngreso = argFechIngreso;
            Telefono = argTelefono;
            Direccion = argdireccion;
            Sexo = argSexo;
            Cargo = argCargo;
            Usuario = argUsuario;
            Clave = argClave;
        }
        public static List<clsEmpleado> Listar_Todo()
        {
            List<clsEmpleado> miVariable = new List<clsEmpleado>();
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Empleado_Buscar", miConexion);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            miConexion.Open();
            SqlDataReader misDatos;
            misDatos = COMANDO.ExecuteReader();
            while (misDatos.Read() == true)
            {
                clsEmpleado Fila;
                Fila = new clsEmpleado(
                   Convert.ToString(misDatos["EmpleadoDNI"]),
                   Convert.ToString(misDatos["Nombre"]),
                   Convert.ToString(misDatos["ApellidoPaterno"]),
                   Convert.ToString(misDatos["ApellidoMaterno"]),
                   Convert.ToDateTime(misDatos["FechaIngreso"]),
                   Convert.ToString(misDatos["Telefono"]),
                   Convert.ToString(misDatos["Direccion"]),
                   Convert.ToChar(misDatos["Sexo"]),
                   Convert.ToString(misDatos["Cargo"]),
                   Convert.ToString(misDatos["Usuario"]),
                   Convert.ToString(misDatos["Clave"]));



                miVariable.Add(Fila);
            }
            miConexion.Close();
            return miVariable;
        }
        //public void Registrar_Empleados()
        //{
        //    SqlConnection miConexion;
        //    miConexion = new SqlConnection(mdlVariables.CadenaConexion);
        //    SqlCommand cmd;
        //    cmd = new SqlCommand("usp_Empleado_Registrar", miConexion);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@parEmpleadoDNI", EmpleadoDNI);
        //    cmd.Parameters.AddWithValue("@parNombre", Nombre);
        //    cmd.Parameters.AddWithValue("@parApPaterno", ApellidoPaterno);
        //    cmd.Parameters.AddWithValue("@parApMaterno", ApellidoMaterno);
        //    cmd.Parameters.AddWithValue("@parFechaIngreso", FechaIngreso);
        //    cmd.Parameters.AddWithValue("@parTelefono", Telefono);
        //    cmd.Parameters.AddWithValue("@parDireccion", Direccion);
        //    cmd.Parameters.AddWithValue("@parSexo", Sexo);
        //    cmd.Parameters.AddWithValue("@parCargo", Cargo);
        //    cmd.Parameters.AddWithValue("@parUsuario", Usuario);
        //    cmd.Parameters.AddWithValue("@parClave", Clave);
        //    miConexion.Open();
        //    cmd.ExecuteNonQuery();
        //    miConexion.Close();
        //}

        public void Registrar_Empleados()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd;
            cmd = new SqlCommand("usp_Empleado_Registrar", miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parEmpleadoDNI", EmpleadoDNI);
            cmd.Parameters.AddWithValue("@parNombre", Nombre);
            cmd.Parameters.AddWithValue("@parApellidoPaterno", ApellidoPaterno);
            cmd.Parameters.AddWithValue("@parApellidoMaterno", ApellidoMaterno);
            cmd.Parameters.AddWithValue("@parFechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@parTelefono", Telefono);
            cmd.Parameters.AddWithValue("@parDireccion", Direccion);
            cmd.Parameters.AddWithValue("@parSexo", Sexo);
            cmd.Parameters.AddWithValue("@parCargo", Cargo);
            cmd.Parameters.AddWithValue("@parUsuario", Usuario);
            cmd.Parameters.AddWithValue("@parClave", Clave);
            miConexion.Open();
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }


        public static clsEmpleado Validacion(string argUsuario, string argClave)
        {
            clsEmpleado ValorRetornado = null;
            //-----------------------------------------
            SqlConnection cn;
            cn = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand COMANDO;
            COMANDO = new SqlCommand("usp_Usuario_Validar", cn);
            COMANDO.CommandType = System.Data.CommandType.StoredProcedure;
            COMANDO.Parameters.AddWithValue("@parUsuario", argUsuario);
            COMANDO.Parameters.AddWithValue("@parClave", argClave);
            cn.Open();
            SqlDataReader datos;
            datos = COMANDO.ExecuteReader();
            while (datos.Read())
            {
                ValorRetornado = new clsEmpleado
                                    (
                                       Convert.ToString(datos["Usuario"]),
                                       Convert.ToString(datos["Clave"])
                                    );
            }
            cn.Close();           
            return ValorRetornado;
        }
    }
}
