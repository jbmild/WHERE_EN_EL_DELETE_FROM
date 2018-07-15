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
    public static class UsuariosRoles
    {
        public static List<UsuarioRol> obtenerPorUsuario(int usuarioId)
        {
            if (usuarioId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@usuarioId", usuarioId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT usuario_id, rol_id FROM WHERE_EN_EL_DELETE_FROM.usuarios_roles WHERE usuario_id=@usuarioId";
                DataTable dt = DBInterface.seleccionar(sql, parametros);

                List<UsuarioRol> usuariosroles = new List<UsuarioRol>();
                foreach (DataRow fila in dt.Rows)
                {
                    usuariosroles.Add(new UsuarioRol(Convert.ToInt32(fila[0]), Convert.ToInt32(fila[1])));
                }

                return usuariosroles;
            }

            return null;
        }
    }
}
