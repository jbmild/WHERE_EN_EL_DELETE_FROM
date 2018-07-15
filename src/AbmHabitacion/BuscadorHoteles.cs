using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscadorHoteles
    {
        internal string ejecutar(string consulta, System.Windows.Forms.ComboBox comboBoxHoteles, int hayHotel)
        {
            
            if (comboBoxHoteles.SelectedText == "")
            {
                hayHotel = 0;
            }
            else 
            {
                consulta = consulta + " where ha.hotel_id=" + comboBoxHoteles.SelectedValue;
                hayHotel = 1;
            }
            return consulta;
        }
    }
}
