using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string bd = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        public static string cn = "server=DESKTOP-CI6EOTK\\SQLEXPRESS;" + bd;

        
    }
}
