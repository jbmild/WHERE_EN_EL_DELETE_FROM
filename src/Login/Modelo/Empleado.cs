using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Hoteles.Modelo;
using FrbaHotel.Tools;

namespace FrbaHotel.Login.Modelo
{
    public class Empleado
    {
        private int empleado_id = 0;
        private int usuario_id = 0;
        private string email = "";
        private string nombre = "";
        private string apellido = "";
        private string documento_tipo = "";
        private string documento_numero = "";
        private string telefono = "";
        private string direccion_calle = "";
        private string direccion_nro = "";
        private string direccion_piso = "";
        private string direccion_depto = "";
        private string direccion_localidad = "";
        private string direccion_pais = "";

        public int EmpleadoId
        {
            get { return empleado_id; }
            set { empleado_id = value; }
        }
        public int UsuarioId
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string DocumentoTipo
        {
            get { return documento_tipo; }
            set { documento_tipo = value; }
        }
        public string DocumentoNumero
        {
            get { return documento_numero; }
            set { documento_numero = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string DireccionCalle
        {
            get { return direccion_calle; }
            set { direccion_calle = value; }
        }
        public string DireccionNro
        {
            get { return direccion_nro; }
            set { direccion_nro = value; }
        }
        public string DireccionPiso
        {
            get { return direccion_piso; }
            set { direccion_piso = value; }
        }
        public string DireccionDepto
        {
            get { return direccion_depto; }
            set { direccion_depto = value; }
        }
        public string DireccionLocalidad
        {
            get { return direccion_localidad; }
            set { direccion_localidad = value; }
        }
        public string DireccionPais
        {
            get { return direccion_pais; }
            set { direccion_pais = value; }
        }

        public Empleado() { }
        public Empleado(int empleadoId)
        {
            if (empleadoId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@empleadoId", empleadoId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT empleado_id, usuario_id, mail, nombre, apellido, documento_tipo, documento_nro, telefono, direccion_calle, direccion_nro, direccion_piso, direccion_depto, direccion_localidad, direccion_pais FROM WHERE_EN_EL_DELETE_FROM.empleados WHERE empleado_id=@empleadoId";
                DataTable data = DBInterface.seleccionar(sql, parametros);

                if (data.Rows.Count == 1)
                {
                    this.empleado_id = Convert.ToInt32(data.Rows[0][0]);
                    this.usuario_id = Convert.ToInt32(data.Rows[0][1]);
                    this.email = data.Rows[0][2].ToString();
                    this.nombre = data.Rows[0][3].ToString();
                    this.apellido = data.Rows[0][4].ToString();
                    this.documento_tipo = data.Rows[0][5].ToString();
                    this.documento_numero = data.Rows[0][6].ToString();
                    this.telefono = data.Rows[0][7].ToString();
                    this.direccion_calle = data.Rows[0][8].ToString();
                    this.direccion_nro = data.Rows[0][9].ToString();
                    this.direccion_piso = data.Rows[0][10].ToString();
                    this.direccion_depto = data.Rows[0][11].ToString();
                    this.direccion_localidad = data.Rows[0][12].ToString();
                    this.direccion_pais = data.Rows[0][13].ToString();
                }
            }
        }

        public bool loadByUsuario(int usuarioId)
        {
            if (usuarioId > 0)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();

                SqlParameter parametro = new SqlParameter("@usuarioId", usuarioId);
                parametro.DbType = DbType.Int32;
                parametros.Add(parametro);

                string sql = "SELECT empleado_id, usuario_id, mail, nombre, apellido, documento_tipo, documento_nro, telefono, direccion_calle, direccion_nro, direccion_piso, direccion_depto, direccion_localidad, direccion_pais FROM WHERE_EN_EL_DELETE_FROM.empleados WHERE usuario_id=@usuarioId";
                DataTable data = DBInterface.seleccionar(sql, parametros);

                if (data.Rows.Count == 1)
                {
                    this.empleado_id = Convert.ToInt32(data.Rows[0][0]);
                    this.usuario_id = Convert.ToInt32(data.Rows[0][1]);
                    this.email = data.Rows[0][2].ToString();
                    this.nombre = data.Rows[0][3].ToString();
                    this.apellido = data.Rows[0][4].ToString();
                    this.documento_tipo = data.Rows[0][5].ToString();
                    this.documento_numero = data.Rows[0][6].ToString();
                    this.telefono = data.Rows[0][7].ToString();
                    this.direccion_calle = data.Rows[0][8].ToString();
                    this.direccion_nro = data.Rows[0][9].ToString();
                    this.direccion_piso = data.Rows[0][10].ToString();
                    this.direccion_depto = data.Rows[0][11].ToString();
                    this.direccion_localidad = data.Rows[0][12].ToString();
                    this.direccion_pais = data.Rows[0][13].ToString();

                    return true;
                }
            }

            return false;
        }
        public List<Hotel> obtenerHoteles()
        {
            if (empleado_id > 0)
            {
                List<Hotel> hoteles = new List<Hotel>();

                List<EmpleadoHotel> empleadoshoteles = EmpleadosHoteles.obtenerPorEmpleado(this.empleado_id);
                if (empleadoshoteles.Count > 0)
                {
                    foreach (EmpleadoHotel empleadohotel in empleadoshoteles)
                    {
                        hoteles.Add(empleadohotel.Hotel);
                    }
                }

                return hoteles;
            }

            throw new Exception("No fue posible cargar el empleado asociado al usuario.");
        }
    }
}
