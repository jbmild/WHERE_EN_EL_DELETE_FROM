using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Roles.Modelo
{
    public class RolPermiso
    {
        private int rol_id;
        private int permiso_id;
        private Permiso permiso;
        private Rol rol;

        public int RoleId
        {
            get { return rol_id; }
            set { rol_id = value; }
        }
        public int PermisoId
        {
            get { return permiso_id; }
            set { permiso_id = value; }
        }
        public Permiso Permiso
        {
            get {
                if (this.permiso == null && this.permiso_id != 0)
                {
                    this.permiso = new Permiso(this.permiso_id);
                }

                return this.permiso;
            }
        }
        public Rol Rol
        {
            get
            {
                if (this.rol == null && this.rol_id != 0)
                {
                    this.rol = new Rol(this.rol_id);
                }

                return this.rol;
            }
        }

        public RolPermiso(int rolId, int permisoId)
        {
            this.rol_id = rolId;
            this.permiso_id = permisoId;
            this.permiso = null;
            this.rol = null;
        }

        public List<KeyValuePair<string, string>> eliminar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();

            ConexionSQL conn = new ConexionSQL();
            string sql = "DELETE FROM WHERE_EN_EL_DELETE_FROM.roles_permisos WHERE rol_id=" + this.rol_id.ToString() + " AND permiso_id = " + this.permiso_id.ToString();
            int eliminado = conn.actualizarDatos(sql);

            if (eliminado != 1)
            {
                errores.Add(new KeyValuePair<string, string>("general", "No se pudo eliminar el permiso."));
            }

            return errores;
        }
        private List<KeyValuePair<string, string>> insertar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();
            try
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "INSERT INTO WHERE_EN_EL_DELETE_FROM.roles_permisos (rol_id, permiso_id) VALUES (" + this.rol_id.ToString() + ", " + this.permiso_id.ToString() + ")";
                int insertado = conn.ejecutarComandoSQL(sql);

                if (insertado != 1)
                {
                    errores.Add(new KeyValuePair<string, string>("general", "El permiso no pudo ser guardado."));
                }
            }
            catch (Exception e)
            {
                errores.Add(new KeyValuePair<string, string>("general", e.Message));
            }

            return errores;
        }

        public List<KeyValuePair<string, string>> guardar()
        {
            List<KeyValuePair<string, string>> errores = this.validar();
            if (errores.Count==0)
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "SELECT rol_id FROM WHERE_EN_EL_DELETE_FROM.roles_permisos WHERE rol_id=" + this.rol_id.ToString() + " AND permiso_id = " + this.permiso_id.ToString();
                DataTable dt = conn.cargarTablaSQL(sql);
                if (dt.Rows.Count == 0)
                {
                    errores = errores.Concat(this.insertar()).ToList();
                }
                else
                {
                    errores.Add(new KeyValuePair<string, string>("general", "El permiso '" + this.Permiso.Nombre + "' ya esta asociado al rol '" + this.Rol.Nombre + "'."));
                }
            }

            return errores;
        }
        public List<KeyValuePair<string, string>> validar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();

            if (this.rol_id == 0 && this.permiso_id == 0)
            {
                errores.Add(new KeyValuePair<string, string>("general", "El rol y el permiso no son validos."));
            }
            else if (this.rol_id == 0)
            {
                errores.Add(new KeyValuePair<string, string>("rol", "El rol no es valido."));
            }
            else if (this.permiso_id == 0)
            {
                errores.Add(new KeyValuePair<string, string>("permiso", "El permiso no es valido."));
            }

            return errores;
        }
    }
}
