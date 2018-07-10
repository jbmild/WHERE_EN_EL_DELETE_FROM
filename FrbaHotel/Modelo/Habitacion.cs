using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace FrbaHotel.Modelo
{
    public class Habitacion
    {
        private int _id;
        private int _hotel_id;
        private int _numero;
        private int _piso;
        private int _frente;
        private string _descripcion;
        private bool _habilitado;
        private int _tipo;
        private decimal _max_huespedes;
        private decimal _porcentual;
        private decimal _precio;

        public Habitacion() { }

        public Habitacion(int id, int hotel_id, int numero, decimal precio){
            _id = id;
            _hotel_id = hotel_id;
            _numero = numero;
            _precio = precio;
        }

        public Habitacion(int id, int hotel_id, int numero)
        {
            _id = id;
            _hotel_id = hotel_id;
            _numero = numero;
        }

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        public int numero {
            get { return _numero; }
            set { _numero = value; }
        }

        public int hotel_id {
            get { return _hotel_id;  }
            set { _hotel_id = value; }
        }

        public decimal max_huespedes {
            get { return _max_huespedes; }
            set { _max_huespedes = value; }
        }

        public decimal porcentual {
            get { return _porcentual; }
            set { _porcentual = value; }
        }

        public decimal precio {
            get { return _precio; }
            set { _precio = value; }
        }

        // Devuelve las habitaciones que estan disponibles para cierta fecha en un hotel.
        public DataTable obtenerHabitacionesDisponibles(DateTime fechaDesde, DateTime fechaHasta, int regimen_id,
                                                                int hotel_id, int tipoHabitacion_id) {

            ConexionSQL conexion = new ConexionSQL();

            SqlCommand command = new SqlCommand(@"DECLARE @FechaDesde datetime
	                DECLARE @FechaHasta datetime
	
	                SELECT @FechaDesde = convert(date, SUBSTRING(@fdesde, 0, 11), 110)
	                SELECT @FechaHasta = convert(date, SUBSTRING(@fhasta, 0, 11), 110)

	                SET NOCOUNT ON;

	                SELECT distinct
		                hab.numero AS [Nro Habitacion],
		                hot.direccion AS Hotel,
		                hot.hotel_id,
		                hab.habitacion_id,
		                habTipos.max_huespedes AS [Cant Huespedes],
                        habTipos.descripcion AS [Tipo],
		                habTipos.max_huespedes,
                        hot.estrellas_recargo AS recargo
		                /*reg.descripcion AS TipoRegimen,
		                reg.codigo AS CodigoRegimen*/
	                FROM
		                WHERE_EN_EL_DELETE_FROM.habitaciones hab
	                INNER JOIN
		                WHERE_EN_EL_DELETE_FROM.hoteles hot on
		                hot.hotel_id = hab.hotel_id
		                and (hab.hotel_id = @hotel_id or @hotel_id is null)
		                and (hab.tipos_id = @tipoHabitacion_id or @tipoHabitacion_id is null or @tipoHabitacion_id = -1)
	                /*INNER JOIN
		                WHERE_EN_EL_DELETE_FROM.regimenes_hoteles regHot on
		                regHot.hotel_id = hot.hotel_id
		                and (regHot.regimen_id = @regimen_id or @regimen_id is null or @regimen_id = -1)
	                INNER JOIN
		                WHERE_EN_EL_DELETE_FROM.regimenes reg on
		                reg.regimen_id = regHot.regimen_id*/
	                INNER JOIN
		                WHERE_EN_EL_DELETE_FROM.habitaciones_tipos habTipos on
		                habTipos.tipo_id = hab.tipos_id
	                LEFT JOIN(
		                SELECT
			                res.reserva_id,
			                resHab.habitacion_id
		                FROM
			                WHERE_EN_EL_DELETE_FROM.reservas_habitaciones resHab
		                INNER JOIN
			                WHERE_EN_EL_DELETE_FROM.reservas res on
			                res.reserva_id = resHab.reserva_id
			                and res.estado not in ('cancelada_recepcion', 'cancelada_cliente', 'cancelada_noshow', 'efectivizada')
			                and (
					                @FechaDesde is null 
					                OR 
					                @FechaHasta is null
					                OR
					                @FechaDesde between res.fecha_desde and res.fecha_hasta
					                OR
					                @FechaHasta between res.fecha_desde and res.fecha_hasta
					                OR
					                (@FechaDesde < res.fecha_desde and @FechaHasta > res.fecha_hasta)
				                )
		                ) res on res.habitacion_id = hab.habitacion_id
	                WHERE
		                res.reserva_id is null
                        AND hot.hotel_id not in (SELECT hotel_id FROM [WHERE_EN_EL_DELETE_FROM].cese_actividades WHERE 
                                    @FechaDesde between fecha_inicio and fecha_fin
					                OR
					                @FechaHasta between fecha_inicio and fecha_fin
					                OR
					                (@FechaDesde < fecha_inicio and @FechaHasta > fecha_fin) )");

            command.Connection = ConexionSQL.obtenerConexion();

            command.Parameters.Add("@fdesde", SqlDbType.VarChar).Value = fechaDesde.ToString("MM-dd-yyyy",
                                                                            CultureInfo.InvariantCulture);
            command.Parameters.Add("@fhasta", SqlDbType.VarChar).Value = fechaHasta.ToString("MM-dd-yyyy",
                                                                            CultureInfo.InvariantCulture);
            command.Parameters.Add("@regimen_id", SqlDbType.Int).Value = regimen_id;
            command.Parameters.Add("@hotel_id", SqlDbType.Int).Value = hotel_id;
            command.Parameters.Add("@tipoHabitacion_id", SqlDbType.Int).Value = tipoHabitacion_id;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;


        }
    }

    
}
