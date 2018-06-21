using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Roles.Modelo
{
    public class Permiso
    {
        private int permiso_id;
        private string nombre;

        public int PermisoId
        {
            get { return permiso_id; }
            set { permiso_id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Permiso(int permisoId)
        {
            if (permisoId > 0)
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "SELECT permiso_id, nombre FROM WHERE_EN_EL_DELETE_FROM.permisos WHERE permiso_id=" + permisoId.ToString();
                DataTable dt = conn.cargarTablaSQL(sql);
                if (dt.Rows.Count == 1)
                {
                    this.permiso_id = Convert.ToInt32(dt.Rows[0][0]);
                    this.nombre = dt.Rows[0][1].ToString();
                }
            }
            else
            {
                this.permiso_id = 0;
                this.nombre = "";
            }
        }

        public Permiso(int permisoId, string nombre)
        {
            this.permiso_id = permisoId;
            this.nombre = nombre;
        }
    }
}
