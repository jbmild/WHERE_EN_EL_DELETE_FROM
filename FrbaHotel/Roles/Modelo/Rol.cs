﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Roles.Modelo
{
    public class Rol
    {
        private int rol_id;
        private string nombre;
        private bool habilitado;
        private bool esDefault;
        private List<Permiso> permisos_dados;
        private List<Permiso> permisos_restringidos;

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
        public List<Permiso> PermisosDados
        {
            get
            {
                if (this.permisos_dados == null)
                {
                    this.permisos_dados = RolesPermisos.obtenerPermisosDadosPorRol(this.rol_id);
                }

                return permisos_dados;
            }
            set
            {
                this.permisos_dados = value;
            }
        }
        public List<Permiso> PermisosRestringidos
        {
            get
            {
                if (this.permisos_restringidos == null)
                {
                    this.permisos_restringidos = RolesPermisos.obtenerPermisosRestringidosPorRol(this.rol_id);
                }

                return permisos_restringidos;
            }
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
                string sql = "INSERT INTO WHERE_EN_EL_DELETE_FROM.roles (nombre, habilitado, esDefault) VALUES ('" + this.nombre + "', " + Convert.ToInt32(this.habilitado).ToString() + ", " + Convert.ToInt32(this.esDefault).ToString() + ")SELECT SCOPE_IDENTITY()";
                int insertado = conn.insertarDatos(sql);

                if (this.esDefault == true)
                {
                    sql = "UPDATE WHERE_EN_EL_DELETE_FROM.roles SET esDefault = 0 WHERE rol_id<>" + this.rol_id.ToString();
                    conn.actualizarDatos(sql);
                }

                if (insertado == 0)
                {
                    errores.Add(new KeyValuePair<string, string>("general", "No se pudo guardar el rol."));
                }
                else
                {
                    this.rol_id = insertado;
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

                if (this.esDefault == true)
                {
                    sql = "UPDATE WHERE_EN_EL_DELETE_FROM.Roles SET esDefault = 0 WHERE rol_id<>" + this.rol_id.ToString();
                    conn.actualizarDatos(sql);
                }

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
            List<KeyValuePair<string, string>> errores = this.validar();

            if (errores.Count == 0)
            {
                if (this.rol_id > 0)
                {
                    ConexionSQL conn = new ConexionSQL();
                    string sql = "SELECT rol_id FROM WHERE_EN_EL_DELETE_FROM.roles WHERE rol_id=" + this.rol_id.ToString();
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
                    if (this.rol_id > 0)
                    {
                        errores = errores.Concat(RolesPermisos.actualizarPermisos(this)).ToList();
                    }
                }
            }

            return errores;
        }
        public List<KeyValuePair<string, string>> validar()
        {
            List<KeyValuePair<string, string>> errores = new List<KeyValuePair<string, string>>();

            //Valido el nombre
            if (this.nombre == null || this.nombre.Length > 255 || this.nombre.Length == 0)
            {
                errores.Add(new KeyValuePair<string, string>("nombre", "El nombre no puede ser nulo, vacio ni tener mas de 255 caracteres."));
            }
            else
            {
                ConexionSQL conn = new ConexionSQL();
                string sql = "SELECT rol_id FROM WHERE_EN_EL_DELETE_FROM.Roles WHERE nombre='" + this.nombre+"' AND rol_id<>" + this.rol_id.ToString();
                DataTable dt = conn.cargarTablaSQL(sql);
                if (dt.Rows.Count > 0)
                {
                    errores.Add(new KeyValuePair<string, string>("nombre", "El nombre ya se encuentra en uso."));
                }
            }

            return errores;
        }
    }
}
