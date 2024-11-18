using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfigationDB
    {
        private const string DB_CONFIG_NAME = "ConexionDB";
        public static string ObtenerConexionDB()
        {
            return ConfigurationManager.ConnectionStrings[DB_CONFIG_NAME].ConnectionString;
        }
    }
}
