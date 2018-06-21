using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Roles.Modelo
{
    class Rol
    {
        private int rol_id;
        private string nombre;
        private bool habilitado;
        private bool esDefault;

        public int RolId
        {
            get { return rol_id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
        public bool EsDefault
        {
            get { return esDefault; }
            set { esDefault = value; }
        }

        public Rol(int rolId)
        {
            if (rolId > 0)
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "SELECT rol_id, nombre, habilitado, esDefault FROM WHERE_EN_EL_DELETE_FROM.Roles WHERE rol_id=" + rolId.ToString();
                DataTable dt = conn.cargarTablaSQL(sql);
                if (dt.Rows.Count == 1)
                {
                    this.rol_id = Convert.ToInt32(dt.Rows[0][0]);
                    this.nombre = dt.Rows[0][1].ToString();
                    this.habilitado = Convert.ToBoolean(dt.Rows[0][2]);
                    this.esDefault = Convert.ToBoolean(dt.Rows[0][3]);
                }
            }
            else
            {
                this.rol_id = 0;
                this.nombre = "";
                this.habilitado = false;
                this.esDefault = false;
            }
        }

        public List<KeyValuePair<string, string>> eliminar()
        {
            this.habilitado = false;
            return this.guardar();
        }
        private List<KeyValuePair<string, string>> insertar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();
            try
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "INSERT INTO WHERE_EN_EL_DELETE_FROM.Roles (nombre, habilitado, esDefault) VALUES ('" + this.nombre + "', " + Convert.ToInt32(this.habilitado).ToString() + ", " + Convert.ToInt32(this.esDefault).ToString() + ")";
                int modificado = conn.actualizarDatos(sql);

                if (modificado == 0)
                {
                    errores.Add(new KeyValuePair<string, string>("general", "No se pudo guardar el rol."));
                }
            }
            catch (Exception e)
            {
                errores.Add(new KeyValuePair<string, string>("general", e.Message));
            }

            return errores;
        }
        private List<KeyValuePair<string, string>> actualizar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();
            try
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "UPDATE WHERE_EN_EL_DELETE_FROM.Roles SET nombre='" + this.nombre + "',habilitado=" + Convert.ToInt32(this.habilitado).ToString() + ",esDefault=" + Convert.ToInt32(this.esDefault).ToString() + " WHERE rol_id=" + this.rol_id.ToString();
                int modificado = conn.actualizarDatos(sql);

                if (modificado == 0)
                {
                    errores.Add(new KeyValuePair<string, string>("general", "No se actualizo ningun dato del registro."));
                }
                else if (modificado > 1)
                {
                    errores.Add(new KeyValuePair<string, string>("general", "Los cambios afectaron a mas de un registro."));
                }
            }
            catch (Exception e)
            {
                errores.Add(new KeyValuePair<string,string>("general", e.Message));
            }

            return errores;
        }


        public List<KeyValuePair<string, string>> guardar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();
            if (this.rol_id > 0)
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "SELECT rol_id FROM WHERE_EN_EL_DELETE_FROM.Roles WHERE rol_id=" + this.rol_id.ToString();
                DataTable dt = conn.cargarTablaSQL(sql);
                if (dt.Rows.Count == 1)
                {
                    errores = errores.Concat(this.actualizar()).ToList();
                }
                else
                {
                    errores.Add(new KeyValuePair<string, string>("general", "El rol ya no existe"));
                }
            }
            else
            {
                errores = errores.Concat(this.insertar()).ToList();
            }

            

            return errores;
        }

        public List<KeyValuePair<string, string>> validar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();

            if (this.nombre == null || this.nombre.Length > 255 || this.nombre.Length==0)
            {
                errores.Add(new KeyValuePair<string,string>("nombre", "El nombre no puede ser nulo, vacio ni tener mas de 255 caracteres."));
            }

            return errores;
        }
    }
}
