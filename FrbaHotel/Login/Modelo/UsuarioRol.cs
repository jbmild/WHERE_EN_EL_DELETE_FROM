using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Roles.Modelo;

namespace FrbaHotel.Login.Modelo
{
    public class UsuarioRol
    {
        private int rol_id = 0;
        private int usuario_id = 0;
        private Usuario usuario = null;
        private Rol rol = null;

        public int UsuarioId
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
        public int RolId
        {
            get { return rol_id; }
            set { rol_id = value; }
        }
        public Usuario Usuario
        {
            get
            {
                if (this.usuario == null && this.usuario_id != 0)
                {
                    usuario = new Usuario(this.usuario_id);
                }
                return usuario;
            }
        }
        public Rol Rol
        {
            get
            {
                if (this.rol == null && this.rol_id != 0)
                {
                    rol = new Rol(this.rol_id);
                }
                return rol;
            }
        }

        public UsuarioRol(int usuarioId, int rolId)
        {
            this.rol_id = rolId;
            this.usuario_id = usuarioId;
            this.rol = null;
            this.usuario = null;
        }
    }
}
