using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FrbaHotel.Modelo
{
    public class Reserva
    {
        private int _id;
        private DateTime _fecha_desde;
        private DateTime _fecha_hasta;
        //private DateTime _fecha_creacion;
        private int _cliente_id;
        private int _codigo;
        //private string _estado;
        private decimal _total;
        private int _regimen_id;
        private int _hotel_id;
        private List<Habitacion> _habitaciones;
        private string _motivoCancelacion;
        private int _usuarioCancelacion;
        //completar atributos

        //nueva reserva
        public Reserva(DateTime fd, DateTime fh, int cliente_id, decimal total, int regimen_id, int hotel_id, List<Habitacion> habitaciones) {
            _fecha_desde = fd;
            _fecha_hasta = fh;
            _cliente_id = cliente_id;
            _total = total;
            _regimen_id = regimen_id;
            _hotel_id = hotel_id;
            _habitaciones = habitaciones;
        }

        public Reserva() { 
        }

        //Getters y setters
        public int id {
            get { return _id; }
            set { _id = value;  }
        }

        public DateTime fecha_desde {
            get { return _fecha_desde; }
            set { _fecha_desde = value; }
        }

        public DateTime fecha_hasta
        {
            get { return _fecha_hasta; }
            set { _fecha_hasta = value; }
        }

        public int cliente_id {
            get { return _cliente_id; }
            set { _cliente_id = value; }
        }

        public decimal total {
            get { return _total; }
            set { _total = value; }
        }

        public int regimen_id {
            get { return _regimen_id; }
            set { _regimen_id = value; }
        }

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public int hotel_id
        {
            get { return _hotel_id; }
            set { _hotel_id = value; }
        }

        public List<Habitacion> habitaciones {
            get { return _habitaciones; }
            set { _habitaciones = value; }
        }

        public string motivoCancelacion {
            get { return _motivoCancelacion; }
            set { _motivoCancelacion = value; }
        }

        public int usuarioCancelacion {
            get { return _usuarioCancelacion; }
            set { _usuarioCancelacion = value; }
        }

        public int GuardarReserva() {

            //Sumarizo total de la reserva
            SqlTransaction trans;
            SqlConnection conn = ConexionSQL.obtenerConexion();
            trans = conn.BeginTransaction();
            
            SqlCommand command = new SqlCommand(@" DECLARE @ultimoCodigo int
                                                SELECT @ultimoCodigo = MAX(codigo) FROM WHERE_EN_EL_DELETE_FROM.Reservas
                                                INSERT INTO WHERE_EN_EL_DELETE_FROM.Reservas (fecha_desde, fecha_hasta, fecha_creacion, cliente_id, codigo, usuario_id, total, regimen_id, hotel_id)
                                                VALUES(@fdesde, @fhasta, getdate(), @cliente_id, @ultimoCodigo+1, @usuario_id, @total, @regimen_id, @hotel_id)
                                                SELECT SCOPE_IDENTITY()");
            command.Connection = conn;
            command.Transaction = trans;
            
            
            command.Parameters.Add("@fdesde", SqlDbType.DateTime).Value = _fecha_desde;
            command.Parameters.Add("@fhasta", SqlDbType.DateTime).Value = _fecha_hasta;
            command.Parameters.Add("@cliente_id", SqlDbType.Int).Value = cliente_id;
            command.Parameters.Add("@usuario_id", SqlDbType.Int).Value = 1;
            command.Parameters.Add("@total", SqlDbType.Decimal).Value = _total;
            command.Parameters.Add("@regimen_id", SqlDbType.Int).Value = _regimen_id;
            command.Parameters.Add("@hotel_id", SqlDbType.Int).Value = _hotel_id;

            int idReserva = 0;
            try
            {
                idReserva = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex) {
                throw (ex);
            }

            command.CommandText = @"INSERT INTO WHERE_EN_EL_DELETE_FROM.Reservas_Habitaciones (habitacion_id, reserva_id, precio_diario)
                                                VALUES(@habitacion_id, @reserva_id, @precio_diario)";

            command.Parameters.Clear();
            command.Parameters.Add("@habitacion_id", SqlDbType.Int);
            command.Parameters.Add("@reserva_id", SqlDbType.Int);
            command.Parameters.Add("@precio_diario", SqlDbType.Decimal);

            int exito = 0;
            int codigo = 0;
            try
            {
                foreach (Habitacion hab in _habitaciones)
                {
                    command.Parameters["@habitacion_id"].Value = hab.id;
                    command.Parameters["@reserva_id"].Value = idReserva;
                    command.Parameters["@precio_diario"].Value = hab.precio;
                    exito = command.ExecuteNonQuery();
                }
                trans.Commit();
                
            }
            catch (Exception ex) {
                trans.Rollback();
                throw (ex);
            }

            SqlCommand command3 = new SqlCommand(" SELECT codigo FROM WHERE_EN_EL_DELETE_FROM.Reservas WHERE reserva_id = " + idReserva);
            command3.Connection = ConexionSQL.obtenerConexion();

            return codigo = Convert.ToInt32(command3.ExecuteScalar());
            
        }

        public int cancelarReserva() {

            string query = @"UPDATE WHERE_EN_EL_DELETE_FROM.Reservas SET Estado='cancelada_{0}', cancelacion_fecha=getdate(), cancelacion_usuario_id=" + _usuarioCancelacion +
                                ", motivo_cancelacion='" + motivoCancelacion + "' WHERE codigo=" + codigo;

            //TODO: Completar con usuario logueado
            query = query.Replace("{0}", _usuarioCancelacion == 1 ? "cliente" : "recepcion");
            SqlCommand command2 = new SqlCommand(query);

            command2.Connection = ConexionSQL.obtenerConexion();
            int exito = command2.ExecuteNonQuery();

            return exito;

        }
    }
}
