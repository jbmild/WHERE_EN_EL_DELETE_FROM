using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscarHabitacion
    {
        internal void ejecutar(Consulta consulta, string p, Busqueda b)
        {
            if (p != "")
            {
                if (b.GetHotel().Equals(false) && b.GetPiso().Equals(false))
                {
                    consulta.ConcatToQuery(" where numero=" + Int32.Parse(p.ToString()));
                }
                else
                {
                    consulta.ConcatToQuery(" and numero=" + Int32.Parse(p.ToString()));
                }
                b.SetHabitacion(true);
            }
            else {
                b.SetHabitacion(false);
            }
            
        }

        internal void Cargar(ConexionSQL con, System.Windows.Forms.ComboBox comboBox, int hotelid)
        {
            DataTable result = con.cargarTablaSQL("SELECT habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + hotelid + "order by numero asc");
            result.Rows.InsertAt(result.NewRow(), 0);
            comboBox.DataSource = result;
            comboBox.SelectedIndex = 0;
            comboBox.DisplayMember = "numero";
            comboBox.ValueMember = "habitacion_id";

        }
    }
}
