using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaDatos
{
   public class InventarioConexion
    {
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\C#\Sistema-Inventario-Farmacia\CapaDatos\DBInventario.mdf;
Integrated Security = True";

        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}
