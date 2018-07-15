using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Tools;

namespace FrbaHotel.Hoteles.Modelo
{
    public static class Hoteles
    {
        public static DataTable obtener(string nombre, string ciudad, string pais, int estrellas)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter("@usuarioId", Sesion.usuario.UsuarioId);
            parametro.DbType = DbType.Int32;
            parametros.Add(parametro);

            string sql = @"SELECT
                            hotel_id, 
                            nombre, 
                            mail, 
                            telefono, 
                            direccion, 
                            ciudad, 
                            pais, 
                            estrellas_cant, 
                            estrellas_recargo, 
                            convert(varchar(10), fecha_creacion, 110) as fecha_creacion
                        FROM 
                            WHERE_EN_EL_DELETE_FROM.hoteles
                        WHERE
                            hotel_id IN (SELECT eh.hotel_id FROM WHERE_EN_EL_DELETE_FROM.empleados_hoteles eh INNER JOIN WHERE_EN_EL_DELETE_FROM.empleados e ON e.empleado_id=eh.empleado_id WHERE e.usuario_id = @usuarioId)";

            if (nombre.Length > 0)
            {
                parametro = new SqlParameter("@nombre", "%" + nombre + "%");
                parametro.DbType = DbType.String;
                parametros.Add(parametro);

                sql = sql + " AND nombre like @nombre";
            }

            if (ciudad.Length > 0)
            {
                parametro = new SqlParameter("@ciudad", "%" + ciudad + "%");
                parametro.DbType = DbType.String;
                parametros.Add(parametro);

                sql = sql + " AND ciudad like @ciudad";
            }

            if (pais.Length > 0)
            {
                parametro = new SqlParameter("@pais", "%" + pais + "%");
                parametro.DbType = DbType.String;
                parametros.Add(parametro);

                sql = sql + " AND pais like @ciudad";
            }

            if (estrellas > 0)
            {
                parametro = new SqlParameter("@estrellas", estrellas);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                sql = sql + " AND estrellas_cant = @estrellas";
            }

            return DBInterface.seleccionar(sql, parametros);
        }
    }
}
