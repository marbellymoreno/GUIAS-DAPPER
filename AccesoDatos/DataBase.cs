using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DataBase
    {
        public static string CadenaConexion
        {
            get
            {
                return ConfigurationManager.
                    ConnectionStrings["Conexion"].
                    ConnectionString;
            }
        }

        public static SqlConnection GetSqlConnection() 
        { 
            SqlConnection cadena = new SqlConnection(CadenaConexion);
            cadena.Open();
            return cadena;
        }
    }
}
