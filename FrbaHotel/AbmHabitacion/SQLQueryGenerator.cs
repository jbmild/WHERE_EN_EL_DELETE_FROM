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



        internal int InsertIntoHabitacionesNuevaHabitacion(System.Data.SqlClient.SqlConnection con, ComboBox comboBoxHotel, TextBox textBoxNumeroHabitacion, ComboBox comboBoxPisoEnHotel, bool vista, TextBox textBoxDescripcionHabitacion )
        {
            string query = String.Concat("INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones (hotel_id, numero, piso, frente, descripcion, habilitado, tipos_id)", " VALUES ( " + "@hotel" + ", " + "@numeroHabitacion" + ", " + "@piso" + ", " + "@vista" + ", " + "@descripcion" + ", " + 1 + ", " + 1 + ")");
            SqlCommand sql = new SqlCommand(query);
            sql.Connection = con;
            sql.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxHotel.SelectedValue;
            sql.Parameters.Add("@numeroHabitacion", SqlDbType.Int).Value = textBoxNumeroHabitacion.Text;
            sql.Parameters.Add("@piso", SqlDbType.Int).Value = comboBoxPisoEnHotel.SelectedValue;
            sql.Parameters.Add("@vista", SqlDbType.Bit).Value = vista;
            sql.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxDescripcionHabitacion.Text;
             return sql.ExecuteNonQuery();

        }
    }
}
