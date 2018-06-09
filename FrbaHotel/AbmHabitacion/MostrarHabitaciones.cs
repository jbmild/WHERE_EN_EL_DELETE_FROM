using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class MostrarHabitaciones
    {
        internal void CargarHabitacionesParaHotelElegido(System.Windows.Forms.ComboBox comboBoxNumeroHabitacion, System.Windows.Forms.ComboBox comboBoxHoteles)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtpisos = c.cargarTablaSQL("select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id=" +
               comboBoxHoteles.SelectedValue + " order by numero asc");
            comboBoxNumeroHabitacion.DataSource = dtpisos;
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.ValueMember = "habitacion_id";
        }
    }
}
