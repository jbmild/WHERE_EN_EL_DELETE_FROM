using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class MostrarHoteles
    {
        internal void CargarHoteles()
        {
            
        }

        internal void CargarHoteles(System.Windows.Forms.ComboBox comboBoxHoteles)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dt = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            dt.Rows.InsertAt(dt.NewRow(), 0);
            comboBoxHoteles.DataSource = dt;
            comboBoxHoteles.SelectedIndex = 0;
            comboBoxHoteles.DisplayMember = "direccion";
            comboBoxHoteles.ValueMember = "hotel_id";
        }
    }
}
