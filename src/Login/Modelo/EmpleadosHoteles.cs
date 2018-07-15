using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Tools;

namespace FrbaHotel.Login.Modelo
{
    public static class EmpleadosHoteles
    {
        public static List<EmpleadoHotel> obtenerPorEmpleado(int empleadoId)
        {
            if (empleadoId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@empleadoId", empleadoId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT empleado_id, hotel_id FROM WHERE_EN_EL_DELETE_FROM.empleados_hoteles WHERE empleado_id=@empleadoId";
                DataTable dt = DBInterface.seleccionar(sql, parametros);

                List<EmpleadoHotel> empleadoshoteles = new List<EmpleadoHotel>();
                foreach (DataRow fila in dt.Rows)
                {
                    empleadoshoteles.Add(new EmpleadoHotel(Convert.ToInt32(fila[0]), Convert.ToInt32(fila[1])));
                }

                return empleadoshoteles;
            }

            return null;
        }
    }
}
