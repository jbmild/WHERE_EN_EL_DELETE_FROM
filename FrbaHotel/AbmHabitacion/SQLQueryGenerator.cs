using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    class SQLQueryGenerator
    {
        internal void Ejecutar(ComboBox comboBoxHotel)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtHoteles = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            dtHoteles.Rows.InsertAt(dtHoteles.NewRow(), 0);
            comboBoxHotel.DataSource = dtHoteles;
            comboBoxHotel.SelectedIndex = 0;
            comboBoxHotel.DisplayMember = "direccion";
            comboBoxHotel.ValueMember = "hotel_id";
        }

        internal void HotelCambioEnAltaHabitacion(ComboBox comboBoxPisoEnHotel, ComboBox comboBoxHotel)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtPisos = c.cargarTablaSQL("select hotel_id, piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id='" + comboBoxHotel.SelectedValue + "'" + " group by hotel_id, piso order by hotel_id desc, piso desc");
            dtPisos.Rows.InsertAt(dtPisos.NewRow(), 0);
            comboBoxPisoEnHotel.DataSource = dtPisos;
            comboBoxPisoEnHotel.SelectedIndex = 0;
            comboBoxPisoEnHotel.DisplayMember = "piso";
            comboBoxPisoEnHotel.ValueMember = "piso";
        }

        internal DataTable GetHabitacionesEnAltaHotel(ComboBox comboBoxHotel, TextBox textBoxNumeroHabitacion, ConexionSQL busq)
        {
            return busq.cargarTablaSQL("SELECT ha.numero FROM WHERE_EN_EL_DELETE_FROM.habitaciones ha JOIN WHERE_EN_EL_DELETE_FROM.hoteles ho on ha.hotel_id=ho.hotel_id where " +
                      " ho.hotel_id=" + comboBoxHotel.SelectedValue + " and ha.numero=" + textBoxNumeroHabitacion.Text);
        }



        internal int InsertIntoHabitacionesNuevaHabitacion(System.Data.SqlClient.SqlConnection con, ComboBox comboBoxHotel, TextBox textBoxNumeroHabitacion, ComboBox comboBoxPisoEnHotel, bool vista, TextBox textBoxDescripcionHabitacion, ComboBox tipoHabi )
        {
            string query = String.Concat("INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones (hotel_id, numero, piso, frente, descripcion, habilitado, tipos_id)", " VALUES ( " + "@hotel" + ", " + "@numeroHabitacion" + ", " + "@piso" + ", " + "@vista" + ", " + "@descripcion" + ", " + 1 + ",@tipoHabi)");
            SqlCommand sql = new SqlCommand(query);
            sql.Connection = con;
            sql.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxHotel.SelectedValue;
            sql.Parameters.Add("@numeroHabitacion", SqlDbType.Int).Value = textBoxNumeroHabitacion.Text;
            sql.Parameters.Add("@piso", SqlDbType.Int).Value = comboBoxPisoEnHotel.SelectedValue;
            sql.Parameters.Add("@vista", SqlDbType.Bit).Value = vista;
            sql.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxDescripcionHabitacion.Text;
            sql.Parameters.Add("@tipoHabi", SqlDbType.Int).Value = tipoHabi.SelectedValue;
             return sql.ExecuteNonQuery();

        }

        internal object GetEstadia(int habitacion, string fecha, int hotelID)
        {
           
            ConexionSQL c = new ConexionSQL();
            string query = "select top 1  e.estadia_id  from WHERE_EN_EL_DELETE_FROM.estadias e" +
                " join WHERE_EN_EL_DELETE_FROM.reservas r on r.reserva_id=e.reserva_id" + 
				 " join WHERE_EN_EL_DELETE_FROM.reservas_habitaciones rh on rh.reserva_id=r.reserva_id" +
                "  join WHERE_EN_EL_DELETE_FROM.habitaciones h on rh.habitacion_id=h.habitacion_id where h.habitacion_id=" + habitacion + 
                " and rh.habitacion_id=" + habitacion +
				" and h.hotel_id=" +  hotelID + 
				" and e.ingreso_fecha>=convert(DateTime,'" + fecha + " ')" + 
				" order by e.ingreso_fecha asc"
;
            DataTable estadia = c.cargarTablaSQL(query);
           return estadia.Rows[0].ItemArray[0].ToString();
        }

        internal void CargarTiposHabitacion(ComboBox comboBoxTipoHabitacion)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable tipos = c.cargarTablaSQL("select tipo_id, descripcion from WHERE_EN_EL_DELETE_FROM.habitaciones_tipos");
            tipos.Rows.InsertAt(tipos.NewRow(), 0);
            comboBoxTipoHabitacion.DataSource = tipos;
            comboBoxTipoHabitacion.SelectedIndex = 0;
            comboBoxTipoHabitacion.DisplayMember = "descripcion";
            comboBoxTipoHabitacion.ValueMember = "tipo_id";
        }
    }
}
