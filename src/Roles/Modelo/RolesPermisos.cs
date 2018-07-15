using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Tools;

namespace FrbaHotel.Roles.Modelo
{
    public static class RolesPermisos
    {
        public static List<Permiso> obtenerPermisosDadosPorRol(int rolId)
        {
            if (rolId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@rolId", rolId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT p.permiso_id, p.nombre FROM WHERE_EN_EL_DELETE_FROM.roles_permisos rp INNER JOIN WHERE_EN_EL_DELETE_FROM.permisos p ON p.permiso_id=rp.permiso_id WHERE rp.rol_id=@rolId";
                DataTable dt = DBInterface.seleccionar(sql, parametros);

                List<Permiso> permisos = new List<Permiso>();
                foreach(DataRow fila in dt.Rows){
                    permisos.Add(new Permiso(Convert.ToInt32(fila[0]), fila[1].ToString()));
                }

                return permisos;
            }

            return null;
        }
        public static List<Permiso> obtenerPermisosRestringidosPorRol(int rolId)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter("@rolId", rolId);
            parametro.DbType = DbType.Int32;
            parametros.Add(parametro);

            string sql = "SELECT permiso_id, nombre FROM WHERE_EN_EL_DELETE_FROM.permisos WHERE permiso_id NOT IN (SELECT permiso_id FROM WHERE_EN_EL_DELETE_FROM.roles_permisos WHERE rol_id=@rolId)";
            DataTable dt = DBInterface.seleccionar(sql, parametros);

            List<Permiso> permisos = new List<Permiso>();
            foreach (DataRow fila in dt.Rows)
            {
                permisos.Add(new Permiso(Convert.ToInt32(fila[0]), fila[1].ToString()));
            }

            return permisos;
        }

        public static List<KeyValuePair<string, string>> actualizarPermisos(Rol rol)
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();

            if (rol.RolId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@rolId", rol.RolId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "DELETE FROM WHERE_EN_EL_DELETE_FROM.roles_permisos WHERE rol_id=@rolId";
                DBInterface.borrar(sql, parametros);

                foreach (Permiso permiso in rol.PermisosDados)
                {
                    if (permiso.PermisoId > 0)
                    {
                        RolPermiso rolpermiso = new RolPermiso(rol.RolId, permiso.PermisoId);
                        errores = errores.Concat(rolpermiso.guardar()).ToList();
                    }
                    else
                    {
                        errores.Add(new KeyValuePair<string, string>("general", "El permiso '" + permiso.Nombre + "' no es valido"));
                    }
                }
            }
            else
            {
                errores.Add(new KeyValuePair<string,string>("general", "El rol '" + rol.Nombre + "' no es valido"));
            }

            return errores;
        }
    }
}
