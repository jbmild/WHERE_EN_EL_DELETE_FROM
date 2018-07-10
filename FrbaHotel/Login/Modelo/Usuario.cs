using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Roles.Modelo;
using FrbaHotel.Tools;

namespace FrbaHotel.Login.Modelo
{
    public class Usuario
    {
        private int usuario_id;
        private string usuario;
        private bool habilitado;
        private int cant_intentos;

        public int UsuarioId
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
        public string NombreUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
        public int CantIntentos
        {
            get { return cant_intentos; }
            set { cant_intentos = value; }
        }

        public Usuario()
        {
        }

        public Usuario(int usuarioId)
        {
            if (usuarioId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@usuarioId", usuarioId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT usuario_id, usuario, habilitado, cant_intentos FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario_id=@usuarioId";
                DataTable data = DBInterface.seleccionar(sql, parametros);

                if (data.Rows.Count == 1)
                {
                    this.usuario_id = Convert.ToInt32(data.Rows[0][0]);
                    this.usuario = data.Rows[0][1].ToString();
                    this.habilitado = Convert.ToBoolean(data.Rows[0][2]);
                    this.cant_intentos = Convert.ToInt32(data.Rows[0][3]);
                }
            }
            else
            {
                this.usuario_id = 0;
                this.usuario = "";
                this.habilitado = false;
                this.cant_intentos = 0;
            }
        }

        public bool Login(string username, string password)
        {
            this.usuario = username;

            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter("@usuario", username);
            parametro.DbType = DbType.String;
            parametros.Add(parametro);

            parametro = new SqlParameter("@password", password);
            parametro.DbType = DbType.String;
            parametros.Add(parametro);

            string sql = "SELECT usuario_id, usuario, habilitado, cant_intentos FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario=@usuario AND contrasena=HASHBYTES('SHA2_256', CONVERT(VARCHAR(32),@password)) AND habilitado=1";
            DataTable data = DBInterface.seleccionar(sql, parametros);

            if (data.Rows.Count == 1)
            {
                this.usuario_id = Convert.ToInt32(data.Rows[0][0]);
                this.usuario = data.Rows[0][1].ToString();
                this.habilitado = Convert.ToBoolean(data.Rows[0][2]);
                this.cant_intentos = Convert.ToInt32(data.Rows[0][3]);

                this.procesarIntento();
                return true;
            }
            else
            {
                this.procesarIntento(false);
                return false;
            }
        }

        private bool procesarIntento(bool success = true)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter("@usuario", this.usuario);
            parametro.DbType = DbType.String;
            parametros.Add(parametro);

            if (success)
            {
                string sql = "UPDATE WHERE_EN_EL_DELETE_FROM.usuarios SET cant_intentos=0 WHERE usuario=@usuario";
                if (DBInterface.actualizar(sql, parametros) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql = "SELECT cant_intentos FROM WHERE_EN_EL_DELETE_FROM.usuarios WHERE usuario=@usuario AND habilitado=1";
                DataTable data = DBInterface.seleccionar(sql, parametros);

                if (data.Rows.Count == 1)
                {
                    parametros.Clear();

                    parametro = new SqlParameter("@usuario", this.usuario);
                    parametro.DbType = DbType.String;
                    parametros.Add(parametro);

                    this.cant_intentos = Convert.ToInt32(data.Rows[0][0]) + 1;
                    if (this.cant_intentos < 3)
                    {
                        parametro = new SqlParameter("@cantIntentos", this.cant_intentos);
                        parametro.DbType = DbType.Int32;
                        parametros.Add(parametro);

                        sql = "UPDATE WHERE_EN_EL_DELETE_FROM.usuarios SET cant_intentos=@cantIntentos WHERE usuario=@usuario";
                    }
                    else
                    {
                        sql = "UPDATE WHERE_EN_EL_DELETE_FROM.usuarios SET cant_intentos=0, habilitado=0 WHERE usuario=@usuario";
                    }

                    if (DBInterface.actualizar(sql, parametros) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }
        }

        public List<Rol> obtenerRolesHabilitados()
        {
            List<Rol> roles = new List<Rol>();

            List<UsuarioRol> usuariosroles = UsuariosRoles.obtenerPorUsuario(this.usuario_id);
            if (usuariosroles.Count > 0)
            {
                foreach (UsuarioRol usuariorol in usuariosroles)
                {
                    if (usuariorol.Rol.Habilitado)
                    {
                        roles.Add(usuariorol.Rol);
                    }
                }
            }

            return roles;
        }
    }
}
