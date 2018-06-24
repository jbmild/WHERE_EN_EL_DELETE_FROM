using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Roles.Modelo
{
    public static class RolesPermisos
    {
        public static List<Permiso> obtenerPermisosDadosPorRol(int rolId)
        {
            if (rolId > 0)
            {
                List<Permiso> permisos = new List<Permiso>();

                ConexionSQL conn = new ConexionSQL();
                string sqlQuery = "SELECT p.permiso_id, p.nombre FROM WHERE_EN_EL_DELETE_FROM.roles_permisos rp INNER JOIN WHERE_EN_EL_DELETE_FROM.permisos p ON p.permiso_id=rp.permiso_id WHERE rp.rol_id="+rolId.ToString();
                DataTable dt = conn.cargarTablaSQL(sqlQuery);

                foreach(DataRow fila in dt.Rows){
                    permisos.Add(new Permiso(Convert.ToInt32(fila[0]), fila[1].ToString()));
                }

                return permisos;
            }

            return null;
        }
        public static List<Permiso> obtenerPermisosRestringidosPorRol(int rolId)
        {
            List<Permiso> permisos = new List<Permiso>();

            ConexionSQL conn = new ConexionSQL();
            string sqlQuery = "SELECT permiso_id, nombre FROM WHERE_EN_EL_DELETE_FROM.permisos WHERE permiso_id NOT IN (SELECT permiso_id FROM WHERE_EN_EL_DELETE_FROM.roles_permisos WHERE rol_id=" + rolId.ToString() + ")";
            DataTable dt = conn.cargarTablaSQL(sqlQuery);

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
                ConexionSQL conn = new ConexionSQL();
                string sql = "DELETE FROM WHERE_EN_EL_DELETE_FROM.roles_permisos WHERE rol_id=" + rol.RolId.ToString();
                conn.ejecutarComandoSQL(sql);

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
