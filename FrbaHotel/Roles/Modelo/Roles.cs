using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel.Roles.Modelo
{
    static class Roles
    {
        public static DataTable obtener()
        {
            ConexionSQL conn = new ConexionSQL();
            string sqlQuery = "SELECT rol_id, nombre, habilitado FROM WHERE_EN_EL_DELETE_FROM.Roles";
            DataTable dt = conn.cargarTablaSQL(sqlQuery);
            return dt;
        }
    }
}
