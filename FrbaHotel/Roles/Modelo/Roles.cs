using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FrbaHotel.Tools;

namespace FrbaHotel.Roles.Modelo
{
    public static class Roles
    {
        public static DataTable obtener()
        {
            ConexionSQL conn = new ConexionSQL();
            string sqlQuery = "SELECT rol_id, nombre, habilitado FROM WHERE_EN_EL_DELETE_FROM.Roles";
            DataTable dt = conn.cargarTablaSQL(sqlQuery);
            return dt;
        }

        public static DataTable obtener(string nombre, int habilitado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            string sql = "SELECT rol_id, nombre, habilitado FROM WHERE_EN_EL_DELETE_FROM.Roles WHERE 1=1";

            SqlParameter parametro;

            if (nombre.Length > 0)
            {
                parametro = new SqlParameter("@nombre", "%" + nombre + "%");
                parametro.DbType = DbType.String;
                parametros.Add(parametro);

                sql = String.Concat(sql, " AND nombre like @nombre");
            }

            if (habilitado != -1)
            {
                parametro = new SqlParameter("@habilitado", habilitado);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                sql = String.Concat(sql, " AND habilitado=@habilitado");
            }

            DataTable dt = DBInterface.seleccionar(sql, parametros);
            return dt;
        }
    }
}
