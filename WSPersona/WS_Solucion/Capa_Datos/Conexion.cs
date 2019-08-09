using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Capa_Datos
{
    public class Conexion
    {
        public SqlConnection cadena = new SqlConnection(
            ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
    }
}
